using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Collections;
using System.Text.RegularExpressions;


namespace FpingTool
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Powershell runspace
        /// </summary>
        private Runspace runSpace;

        /// <summary>
        /// The active PipelineExecutor instance
        /// </summary>
        private PipelineExecutor pipelineExecutor;

        private string PATH = Path.GetTempPath();

        //cmd parameters

        public Dictionary<string, string> hostnamePairs = new Dictionary<string, string>
            {
                {"华南-广州", "obs.cn-south-1.myhuaweicloud.com" },
                {"华北-北京一", "obs.cn-north-1.myhuaweicloud.com"},
                {"华东-上海二", "obs.cn-east-2.myhuaweicloud.com" },
                {"fa62", "139.9.44.145" }
            };

        //private string hostNameValue;

        private string dashTimeValue;

        private string dashSizeValue;

        private string dashNumValue;

        //ini file
        //private IniFile ini = new IniFile(PATH);


        public MainForm()
        {
            InitializeComponent();
            // create Powershell runspace
            runSpace = RunspaceFactory.CreateRunspace();
            // open it
            runSpace.Open();
        }

        //helper functions
        public void WriteLog(string documentName, string msg)
        {
            string errorLogFilePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log");
            if (!System.IO.Directory.Exists(errorLogFilePath))
            {
                System.IO.Directory.CreateDirectory(errorLogFilePath);
            }
            string logFile = System.IO.Path.Combine(errorLogFilePath, documentName + "@" + DateTime.Today.ToString("yyyy-MM-dd") + ".txt");
            bool writeBaseInfo = System.IO.File.Exists(logFile);
            StreamWriter swLogFile = new StreamWriter(logFile, true, Encoding.Unicode);
            swLogFile.WriteLine(DateTime.Now.ToString("HH:mm:ss") + "\t" + msg);
            swLogFile.Close();
            swLogFile.Dispose();
        }

        private String CmdStruct()
        {
            string host = hostCombo.SelectedValue.ToString();
            string cmd = String.Format(" {0} -t {1} -s {2} -n {3} -j", host, 
                dashTimeValue, dashSizeValue, dashNumValue);
            Console.WriteLine(cmd);
            return cmd;
        }

        private bool listBoxChanged = false;

        private void AppendLine(string line)
        {
            //TODO: extract data from line
            listBoxChanged = true;
            if (FpingResultBox.Items.Count > 15000) FpingResultBox.Items.RemoveAt(0);
            FpingResultBox.Items.Add(line);
            FpingResultBox.TopIndex = FpingResultBox.Items.Count - 1;
        }

        private void pipelineExecutor_OnDataEnd(PipelineExecutor sender)
        {
            if (sender.Pipeline.PipelineStateInfo.State == PipelineState.Failed)
            {
                AppendLine(string.Format("Error in script: {0}", sender.Pipeline.PipelineStateInfo.Reason));
            }
            else
            {
                AppendLine("Ready.");
                ReadResults();
            }
        }

        private void pipelineExecutor_OnDataReady(PipelineExecutor sender, ICollection<PSObject> data)
        {
            foreach (PSObject obj in data)
            {
                AppendLine(obj.ToString());
            }
        }

        void pipelineExecutor_OnErrorReady(PipelineExecutor sender, ICollection<object> data)
        {
            foreach (object e in data)
            {
                AppendLine("Error : " + e.ToString());
            }
        }

        private void StopScript()
        {
            if (pipelineExecutor != null)
            {
                pipelineExecutor.OnDataReady -= new PipelineExecutor.DataReadyDelegate(pipelineExecutor_OnDataReady);
                pipelineExecutor.OnDataEnd -= new PipelineExecutor.DataEndDelegate(pipelineExecutor_OnDataEnd);
                pipelineExecutor.Stop();
                pipelineExecutor = null;
            }
        }

        private void ReadResults()
        {
            //读取丢包率
            string lossInfo = FpingResultBox.Items[FpingResultBox.Items.Count - 4].ToString();
            string re = @".*?(\d+).*?(\d+).*?(\d+)";
            Regex lossRe = new Regex(re, RegexOptions.IgnoreCase | RegexOptions.Singleline);
            Match lossMatch = lossRe.Match(lossInfo);
            if (lossMatch.Success)
            {
                int sent = int.Parse(lossMatch.Groups[1].ToString());
                int received = int.Parse(lossMatch.Groups[2].ToString());
                int lost = int.Parse(lossMatch.Groups[3].ToString());
                decimal lossPercent = Math.Round((decimal)lost / sent*100, 2);
                lossValue.Text = lossPercent.ToString() + "%";
            }

            //读取时延
            string delayInfo = FpingResultBox.Items[FpingResultBox.Items.Count - 2].ToString();

            string re1 = ".*?"; // Non-greedy match on filler
            string re2 = "([+-]?\\d*\\.\\d+)(?![-+0-9\\.])";    // Float 1

            string re4delay = string.Concat(Enumerable.Repeat(re1+re2, 3));
            Regex delayRe = new Regex(re4delay, RegexOptions.IgnoreCase | RegexOptions.Singleline);
            Match delayMatch = delayRe.Match(delayInfo);
            if (delayMatch.Success)
            {
                String min = delayMatch.Groups[1].ToString();
                String max = delayMatch.Groups[2].ToString();
                String avg = delayMatch.Groups[3].ToString();
                delayValue.Text = avg;
            }

            //读取抖动
            string jitterInfo = FpingResultBox.Items[FpingResultBox.Items.Count - 7].ToString();
            int found = jitterInfo.IndexOf("jitter=");
            string jitter = jitterInfo.Substring(found + 7).Split(' ')[0];
            jitterValue.Text = jitter;
        }

        //private string[] ReadRegex(string re, string info)
        //{
        //    string[] results = new string[20];
        //    MatchCollection mc;
        //    Regex r = new Regex(re, RegexOptions.IgnoreCase | RegexOptions.Singleline);
        //    mc = r.Matches(info);
        //    for (int i = 0; i < mc.Count; i++)
        //    {
        //        results[i] = mc[i].Value;
        //        Console.WriteLine(mc[i].Value);
        //    }
        //    return results;
        //}


        private void startButton_Click(object sender, EventArgs e)
        {
            SetValues();
            string path = Path.Combine(PATH, "Fping.exe");
            Console.WriteLine(path);
            File.WriteAllBytes(path, FpingTool.Properties.Resources.Fping);
            string cmd = path + CmdStruct();

            FpingResultBox.Items.Clear();
            AppendLine("Starting script...");
            pipelineExecutor = new PipelineExecutor(runSpace, this, cmd);
            pipelineExecutor.OnDataReady += new PipelineExecutor.DataReadyDelegate(pipelineExecutor_OnDataReady);
            pipelineExecutor.OnDataEnd += new PipelineExecutor.DataEndDelegate(pipelineExecutor_OnDataEnd);
            pipelineExecutor.OnErrorReady += new PipelineExecutor.ErrorReadyDelegate(pipelineExecutor_OnErrorReady);
            pipelineExecutor.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (listBoxChanged)
            {
                FpingResultBox.EndUpdate();
                FpingResultBox.Update();
                listBoxChanged = false;
                FpingResultBox.BeginUpdate();
            }
            else
            {
                FpingResultBox.EndUpdate();
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            StopScript();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            StopScript();
            this.Close();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            string cur = System.Environment.CurrentDirectory;
            string path = Path.Combine(cur, "test_network.ini");
            Console.WriteLine(path);
            IniFile ini = new IniFile(path);
            AppendLine(ini.IniReadValue("host", "fa62"));
            ArrayList hosts = ini.ReadKeys("host");
            foreach (string o in hosts)
            {
                Console.WriteLine(o);
            }
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            using (Form2 f2 = new Form2())
            {
                if(f2.ShowDialog() == DialogResult.OK)
                {
                    Console.WriteLine("yes");
                    hostnamePairs.Add(f2.hostName, f2.hostIp);
                    MainForm_Load(sender, e);
                }
            }
        }

        private void SetValues()
        {
            dashTimeValue = dashTime.Text;
            dashSizeValue = dashSize.Text;
            dashNumValue = dashNum.Text;
        }

        private void dashTime_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            string tString = textBox.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("请输入数字！");
                    textBox.Text = "";
                    return;
                }

            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            dashTime.Text = "1";
            dashSize.Text = "1500";
            dashNum.Text = "15000";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            hostCombo.DataSource = new BindingSource(hostnamePairs, null);
            hostCombo.DisplayMember = "Key";
            hostCombo.ValueMember = "Value";
            hostCombo.SelectedIndex = 0;
        }

        private void hostCombo_Click(object sender, EventArgs e)
        {

        }
    }
}
