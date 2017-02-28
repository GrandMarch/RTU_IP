namespace RTU_IP
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtReadDHCP = new System.Windows.Forms.TextBox();
            this.btnSetConfig = new System.Windows.Forms.Button();
            this.btnReadConfig = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtReadServerPort = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtReadServerIP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtReadDNS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtReadGW = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtReadSub = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReadIP = new System.Windows.Forms.TextBox();
            this.txtReadMAC = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.constatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.txtReadDHCP);
            this.groupBox3.Controls.Add(this.btnSetConfig);
            this.groupBox3.Controls.Add(this.btnReadConfig);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtReadServerPort);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtReadServerIP);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtReadDNS);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtReadGW);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtReadSub);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtReadIP);
            this.groupBox3.Controls.Add(this.txtReadMAC);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Location = new System.Drawing.Point(12, 90);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(353, 275);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "配置信息：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 160);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 12);
            this.label17.TabIndex = 21;
            this.label17.Text = "DHCP：";
            // 
            // txtReadDHCP
            // 
            this.txtReadDHCP.Location = new System.Drawing.Point(91, 157);
            this.txtReadDHCP.Name = "txtReadDHCP";
            this.txtReadDHCP.Size = new System.Drawing.Size(102, 21);
            this.txtReadDHCP.TabIndex = 20;
            this.txtReadDHCP.Text = "0";
            // 
            // btnSetConfig
            // 
            this.btnSetConfig.Location = new System.Drawing.Point(208, 194);
            this.btnSetConfig.Name = "btnSetConfig";
            this.btnSetConfig.Size = new System.Drawing.Size(139, 71);
            this.btnSetConfig.TabIndex = 18;
            this.btnSetConfig.Text = "写入配置";
            this.btnSetConfig.UseVisualStyleBackColor = true;
            this.btnSetConfig.Click += new System.EventHandler(this.btnSetConfig_Click);
            // 
            // btnReadConfig
            // 
            this.btnReadConfig.Location = new System.Drawing.Point(208, 50);
            this.btnReadConfig.Name = "btnReadConfig";
            this.btnReadConfig.Size = new System.Drawing.Size(139, 128);
            this.btnReadConfig.TabIndex = 16;
            this.btnReadConfig.Text = "读取配置";
            this.btnReadConfig.UseVisualStyleBackColor = true;
            this.btnReadConfig.Click += new System.EventHandler(this.btnReadConfig_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 12);
            this.label9.TabIndex = 15;
            this.label9.Text = "Server Port：";
            // 
            // txtReadServerPort
            // 
            this.txtReadServerPort.Location = new System.Drawing.Point(91, 236);
            this.txtReadServerPort.Name = "txtReadServerPort";
            this.txtReadServerPort.Size = new System.Drawing.Size(102, 21);
            this.txtReadServerPort.TabIndex = 14;
            this.txtReadServerPort.Text = "502";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "Server IP：";
            // 
            // txtReadServerIP
            // 
            this.txtReadServerIP.Location = new System.Drawing.Point(91, 209);
            this.txtReadServerIP.Name = "txtReadServerIP";
            this.txtReadServerIP.Size = new System.Drawing.Size(102, 21);
            this.txtReadServerIP.TabIndex = 12;
            this.txtReadServerIP.Text = "127.0.0.1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "DNS：";
            // 
            // txtReadDNS
            // 
            this.txtReadDNS.Location = new System.Drawing.Point(91, 128);
            this.txtReadDNS.Name = "txtReadDNS";
            this.txtReadDNS.Size = new System.Drawing.Size(102, 21);
            this.txtReadDNS.TabIndex = 10;
            this.txtReadDNS.Text = "127.0.0.1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "GW：";
            // 
            // txtReadGW
            // 
            this.txtReadGW.Location = new System.Drawing.Point(91, 101);
            this.txtReadGW.Name = "txtReadGW";
            this.txtReadGW.Size = new System.Drawing.Size(102, 21);
            this.txtReadGW.TabIndex = 8;
            this.txtReadGW.Text = "127.0.0.1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "Sub：";
            // 
            // txtReadSub
            // 
            this.txtReadSub.Location = new System.Drawing.Point(91, 74);
            this.txtReadSub.Name = "txtReadSub";
            this.txtReadSub.Size = new System.Drawing.Size(102, 21);
            this.txtReadSub.TabIndex = 6;
            this.txtReadSub.Text = "127.0.0.1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "IP：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "MAC：";
            // 
            // txtReadIP
            // 
            this.txtReadIP.Location = new System.Drawing.Point(91, 47);
            this.txtReadIP.Name = "txtReadIP";
            this.txtReadIP.Size = new System.Drawing.Size(102, 21);
            this.txtReadIP.TabIndex = 4;
            this.txtReadIP.Text = "127.0.0.1";
            // 
            // txtReadMAC
            // 
            this.txtReadMAC.Location = new System.Drawing.Point(91, 20);
            this.txtReadMAC.Name = "txtReadMAC";
            this.txtReadMAC.Size = new System.Drawing.Size(259, 21);
            this.txtReadMAC.TabIndex = 4;
            this.txtReadMAC.Text = "00-00-00-00-00-00";
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(6, 191);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(196, 74);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "作为主站时：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtIP);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 72);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "连接参数：";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(258, 25);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "连接";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "读10个";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port：";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(198, 25);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(54, 21);
            this.txtPort.TabIndex = 2;
            this.txtPort.Text = "502";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP：";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(42, 25);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(102, 21);
            this.txtIP.TabIndex = 0;
            this.txtIP.Text = "192.168.1.110";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtLog);
            this.groupBox4.Location = new System.Drawing.Point(12, 371);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(353, 111);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "诊断区：";
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(3, 17);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(347, 91);
            this.txtLog.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.AllowMerge = false;
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.constatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 482);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(378, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // constatus
            // 
            this.constatus.Name = "constatus";
            this.constatus.Size = new System.Drawing.Size(44, 17);
            this.constatus.Text = "未连接";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 504);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IP地址修改";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnReadConfig;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtReadServerPort;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtReadServerIP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtReadDNS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtReadGW;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtReadSub;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReadIP;
        private System.Windows.Forms.TextBox txtReadMAC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnSetConfig;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel constatus;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtReadDHCP;
        private System.Windows.Forms.Button button1;

    }
}

