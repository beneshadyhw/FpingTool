using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FpingTool
{
    public partial class Form2 : Form
    {
        public string hostName { get { return hostNameBox.Text; } }
        public string hostIp { get { return hostIpBox.Text; } }

        public Form2()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            //hostName = hostNameBox.Text;
            //hostIp = hostIpBox.Text;
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
