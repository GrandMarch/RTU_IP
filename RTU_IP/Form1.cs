using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RTU_IP
{    
    public partial class Form1 : Form,ILog, IDisposable
    {
        private ModBusTCPWrapper Wrapper = null;
        #region ILog 成员
        public void Write(string log)
        {
            this.txtLog.AppendText(log + Environment.NewLine);
            this.txtLog.Select(this.txtLog.TextLength, 0);
            this.txtLog.ScrollToCaret();
        }
        
        #endregion
        public Form1()
        {
            InitializeComponent();
            //this.Wrapper = new ModBusTCPWrapper();
            //this.Wrapper.Logger = this;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.Wrapper!=null)
            {
                this.Wrapper.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Wrapper.Receive(1, 0, 21, 0x03);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            bool checkFlag = false;
            checkFlag = IPCheck.IsIPAddress(txtIP.Text.Trim());// 检查IP是否合法
            if (!checkFlag)//如果IP地址出错那么给出错误提示并返回函数
            {
                MessageBox.Show("IP地址错误！", "Error");
                return;
            }
            checkFlag = IPCheck.IsIPPort(txtPort.Text.Trim());//检查端口是否合法
            if (!checkFlag)//如果端口设置错误那么给出错误提示并返回函数
            {
                MessageBox.Show("端口设置错误！", "Error");
                return;
            }
            //检查都通过的话全局变量赋值
            GlobalTag.IP = txtIP.Text.Trim();
            GlobalTag.Port = Convert.ToInt32(txtPort.Text.Trim());
            //建立连接
            this.Wrapper = new ModBusTCPWrapper();
            this.Wrapper.Logger = this;
            try
            {
                this.Wrapper.Receive(1, 0, 1, 0x03);//尝试读取一个寄存器
                GlobalTag.SocketConnected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"错误",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                
                GlobalTag.SocketConnected = false;//捕获到异常那么就是没有建立成功
            }
            if (GlobalTag.SocketConnected)
            {
                constatus.Text = "已连接";
                //btnReadConfig.Enabled = false;
            }
            else
            {
                constatus.Text = "未连接";
                //btnReadConfig.Enabled = false;
            }
        }
        private void btnReadConfig_Click(object sender, EventArgs e)
        {
            byte[] resualt=null;
            try
            {
                resualt=this.Wrapper.ReadConfigration();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (resualt == null)
            {
                MessageBox.Show("读取配置命令返回的数据长度错误", "读取错误");
            }
            else
            {
                txtReadMAC.Text = resualt[0].ToString("X2") + "-" + resualt[1].ToString("X2") + "-" + resualt[2].ToString("X2") + "-" + resualt[3].ToString("X2") +"-"+ resualt[4].ToString("X2") + "-" + resualt[5].ToString("X2");
                txtReadIP.Text = Convert.ToInt16(resualt[6]).ToString() + "." + Convert.ToInt16(resualt[7]).ToString() + "." + Convert.ToInt16(resualt[8]).ToString() + "." + Convert.ToInt16(resualt[9]).ToString();
                txtReadSub.Text = Convert.ToInt16(resualt[10]).ToString() + "." + Convert.ToInt16(resualt[11]).ToString() + "." + Convert.ToInt16(resualt[12]).ToString() + "." + Convert.ToInt16(resualt[13]).ToString();
                txtReadGW.Text = Convert.ToInt16(resualt[14]).ToString() + "." + Convert.ToInt16(resualt[15]).ToString() + "." + Convert.ToInt16(resualt[16]).ToString() + "." + Convert.ToInt16(resualt[17]).ToString();
                txtReadDNS.Text = Convert.ToInt16(resualt[18]).ToString() + "." + Convert.ToInt16(resualt[19]).ToString() + "." + Convert.ToInt16(resualt[20]).ToString() + "." + Convert.ToInt16(resualt[21]).ToString();
                txtReadDHCP.Text = Convert.ToInt16(resualt[22]).ToString();
                //byte[] data={resualt[23],resualt[24]};
                uint  value = (uint)(Convert.ToUInt16(resualt[23]) * 256) + (uint)(Convert.ToUInt16(resualt[24]));
                //value=ValueHelper.Instance.GetShort(data);
                txtReadServerPort.Text = value.ToString();
                txtReadServerIP.Text = Convert.ToInt16(resualt[25]).ToString() + "." + Convert.ToInt16(resualt[26]).ToString() + "." + Convert.ToInt16(resualt[27]).ToString() + "." + Convert.ToInt16(resualt[28]).ToString();
            }            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            //btnReadConfig.Enabled = false;
        }
        
        private void btnSetConfig_Click(object sender, EventArgs e)
        {
            List<byte> datas = new List<byte>();
            string[] str = txtReadMAC.Text.Split('-');//将mac地址转换为bytes
            foreach (string ss in str)
            {
                datas.Add(Convert.ToByte(ss,16));//先转换为
            }
            str = txtReadIP.Text.Split('.');//将IP地址转换为bytes
            foreach (string ss in str)
            {
                datas.Add(Convert.ToByte(ss));
            }
            str = txtReadSub.Text.Split('.');//将子网掩码转换为bytes
            foreach (string ss in str)
            {
                datas.Add(Convert.ToByte(ss));
            }
            str = txtReadGW.Text.Split('.');//将网关转换为bytes
            foreach (string ss in str)
            {
                datas.Add(Convert.ToByte(ss));
            }
            str = txtReadDNS.Text.Split('.');//将DNS转换为bytes
            foreach (string ss in str)
            {
                datas.Add(Convert.ToByte(ss));
            }
            datas.Add(Convert.ToByte(txtReadDHCP.Text));//将DHCP转换为byte
            datas.AddRange(ValueHelper.Instance.GetBytes((short)Convert.ToUInt16(txtReadServerPort.Text)));//服务器端口
            
            str = txtReadServerIP.Text.Split('.');//将服务器IP地址转换为bytes
            foreach (string ss in str)
            {
                datas.Add(Convert.ToByte(ss));
            }
            this.Wrapper.SetConfigration(datas.ToArray());//发送数据
        }
    }
    #region 静态类GlobalTag，所有的全局变量在此处定义
    public static class GlobalTag
    {
        public const  int MAX_LENGTH = 256;//socket接收数据最大的数据长度
        public static string IP = "127.0.0.1";//modbus从站的IP
        public static int Port = 502;//modbus从站的端口
        public static int TimeOut = 1000;//socket超时时间
        public static bool SocketConnected = false;
       
    }
    #endregion
    
}
