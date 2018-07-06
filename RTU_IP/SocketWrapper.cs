using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Configuration;

namespace RTU_IP
{
    internal class SocketWrapper : IDisposable
    {
        /*private static string IP = ConfigurationManager.AppSettings["IP"];
        private static int Port = Int32.Parse(ConfigurationManager.AppSettings["Port"]);
        private static int TimeOut = Int32.Parse(ConfigurationManager.AppSettings["SocketTimeOut"]);*/
        /*连接参数的初始化*/
        //private static string IP = "127.0.0.1";
       //private static int Port = 502;
        //private static int TimeOut = 1000;

        public ILog Logger { get; set; }//
        private Socket socket = null;//创建一个socket套接字
        private string IP;
        private int Port = 502;
        private int ID = 1;
        public SocketWrapper(string sIP, int iPort, int iID)
        {
            IP = sIP;
            Port = iPort;
            ID = iID;
        }
        public void Connect()
        {
            this.socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            this.socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.SendTimeout,1000);
            IPEndPoint ip = new IPEndPoint(IPAddress.Parse(IP), Port);
            this.socket.Connect(ip);
        }
        public void Disconnect()
        {
            socket.Disconnect(false);
            Dispose();
        }

        public byte[] Read()//读取数据
        {
            //创建一个最大长度大的数据准备接受数据，如果数据超过了最大长度的话那么需要重新定义MAX_LENGTH的长度并重新编译
            byte[] data = new byte[256];
            int rNumber = 0;//指示读取到的数据的长度
            rNumber=this.socket.Receive(data);
            byte[] result = new byte[rNumber];//保存最后的有效的数据
            Array.Copy(data, result, rNumber);//复制有效数据到result
            data = null;// 清空data
            this.Log("Receive:", result);//写日志信息
            return result;
        }
        public void Write(byte[] data)//发送数据
        {
            this.Log("Send:", data);
            this.socket.Send(data);
        }
        private void Log(string type, byte[] data)//日志记录
        {
            if (this.Logger != null)
            {
                StringBuilder logText = new StringBuilder(type);
                foreach (byte item in data)
                {
                    logText.Append(item.ToString("X2") + " ");//以16进制形式输出，便于观察和分析数据
                }
                this.Logger.Write(logText.ToString());
            }
        }

        #region IDisposable 成员
        public void Dispose()
        {
            if (this.socket != null)
            {
                this.socket.Close();
            }
        }
        #endregion
    }
}
