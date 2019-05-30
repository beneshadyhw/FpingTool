namespace FpingTool
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.hostCombo = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.setButton = new System.Windows.Forms.Button();
            this.lossValue = new System.Windows.Forms.TextBox();
            this.testBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FpingResultBox = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.exitButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dashTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dashSize = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dashNum = new System.Windows.Forms.TextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.jitterValue = new System.Windows.Forms.TextBox();
            this.delayValue = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hostCombo
            // 
            this.hostCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hostCombo.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hostCombo.FormattingEnabled = true;
            this.hostCombo.Location = new System.Drawing.Point(130, 12);
            this.hostCombo.Name = "hostCombo";
            this.hostCombo.Size = new System.Drawing.Size(176, 22);
            this.hostCombo.TabIndex = 0;
            this.hostCombo.Click += new System.EventHandler(this.hostCombo_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(112, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "测试地址 Hosts";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 54);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(94, 21);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "开始";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(112, 54);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(94, 21);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "停止";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // setButton
            // 
            this.setButton.Location = new System.Drawing.Point(212, 54);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(94, 21);
            this.setButton.TabIndex = 2;
            this.setButton.Text = "添加地址";
            this.setButton.UseVisualStyleBackColor = true;
            // 
            // lossValue
            // 
            this.lossValue.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lossValue.Location = new System.Drawing.Point(84, 458);
            this.lossValue.Name = "lossValue";
            this.lossValue.ReadOnly = true;
            this.lossValue.Size = new System.Drawing.Size(75, 26);
            this.lossValue.TabIndex = 4;
            this.lossValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // testBox
            // 
            this.testBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.testBox.Location = new System.Drawing.Point(12, 490);
            this.testBox.Name = "testBox";
            this.testBox.Size = new System.Drawing.Size(517, 26);
            this.testBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(547, 461);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(547, 493);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "label1";
            // 
            // FpingResultBox
            // 
            this.FpingResultBox.FormattingEnabled = true;
            this.FpingResultBox.ItemHeight = 12;
            this.FpingResultBox.Location = new System.Drawing.Point(12, 81);
            this.FpingResultBox.Name = "FpingResultBox";
            this.FpingResultBox.Size = new System.Drawing.Size(591, 328);
            this.FpingResultBox.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(515, 522);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(102, 21);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "退出";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(407, 522);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(102, 21);
            this.exportButton.TabIndex = 7;
            this.exportButton.Text = "预留";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(317, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "间隔时间(ms)";
            // 
            // dashTime
            // 
            this.dashTime.AcceptsTab = true;
            this.dashTime.Location = new System.Drawing.Point(414, 13);
            this.dashTime.Name = "dashTime";
            this.dashTime.Size = new System.Drawing.Size(57, 21);
            this.dashTime.TabIndex = 9;
            this.dashTime.Text = "1";
            this.dashTime.TextChanged += new System.EventHandler(this.dashTime_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(317, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "发包大小(b)";
            // 
            // dashSize
            // 
            this.dashSize.AcceptsTab = true;
            this.dashSize.Location = new System.Drawing.Point(414, 54);
            this.dashSize.Name = "dashSize";
            this.dashSize.Size = new System.Drawing.Size(57, 21);
            this.dashSize.TabIndex = 9;
            this.dashSize.Text = "1500";
            this.dashSize.TextChanged += new System.EventHandler(this.dashTime_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(474, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 14);
            this.label6.TabIndex = 8;
            this.label6.Text = "发包数量";
            // 
            // dashNum
            // 
            this.dashNum.AcceptsTab = true;
            this.dashNum.Location = new System.Drawing.Point(546, 14);
            this.dashNum.Name = "dashNum";
            this.dashNum.Size = new System.Drawing.Size(57, 21);
            this.dashNum.TabIndex = 9;
            this.dashNum.Text = "15000";
            this.dashNum.TextChanged += new System.EventHandler(this.dashTime_TextChanged);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(509, 54);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(94, 21);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "重置";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F);
            this.label7.Location = new System.Drawing.Point(14, 461);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "丢包率:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F);
            this.label8.Location = new System.Drawing.Point(165, 461);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "抖动(ms):";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // jitterValue
            // 
            this.jitterValue.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.jitterValue.Location = new System.Drawing.Point(251, 458);
            this.jitterValue.Name = "jitterValue";
            this.jitterValue.ReadOnly = true;
            this.jitterValue.Size = new System.Drawing.Size(51, 26);
            this.jitterValue.TabIndex = 4;
            this.jitterValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // delayValue
            // 
            this.delayValue.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.delayValue.Location = new System.Drawing.Point(458, 458);
            this.delayValue.Name = "delayValue";
            this.delayValue.ReadOnly = true;
            this.delayValue.Size = new System.Drawing.Size(51, 26);
            this.delayValue.TabIndex = 4;
            this.delayValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F);
            this.label9.Location = new System.Drawing.Point(308, 461);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "平均往返时延(ms):";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(14, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "测试结果：";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 555);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dashSize);
            this.Controls.Add(this.dashNum);
            this.Controls.Add(this.dashTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.FpingResultBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delayValue);
            this.Controls.Add(this.testBox);
            this.Controls.Add(this.jitterValue);
            this.Controls.Add(this.lossValue);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.setButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.hostCombo);
            this.Name = "MainForm";
            this.Text = "Net_tool";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox hostCombo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.TextBox lossValue;
        private System.Windows.Forms.TextBox testBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox FpingResultBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dashTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dashSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox dashNum;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox jitterValue;
        private System.Windows.Forms.TextBox delayValue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
    }
}

