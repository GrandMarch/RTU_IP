using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Windows.Forms;
using System.Net;
namespace RTU_IP
{
    public enum FunctionCode : byte
    {
        /// <summary>
        /// Read Multiple Registers
        /// </summary>
        Read = 3,

        /// <summary>
        /// Write Multiple Registers
        /// </summary>
        Write = 16
    }

    class ModBusTCPWrapper : IDisposable
    {
        //public static ModBusTCPWrapper Instance = new ModBusTCPWrapper();
        private string IP;
        private int Port=502;
        private byte ID = 1;
        private SocketWrapper socketWrapper;
        public ModBusTCPWrapper(string sIP,int iPort,byte iID)
        {
            IP = sIP;
            Port = iPort;
            ID = iID;
            socketWrapper = new SocketWrapper(sIP, iPort, iID);
        }

        bool connected = false;
        public ILog Logger { get; set; }
        public  void Connect()
        {
            this.socketWrapper.Logger = this.Logger;
            this.socketWrapper.Connect();
            this.connected = true;
        }
        public void DisConnect()
        {
            socketWrapper.Disconnect();
            connected = false;
        }

        public  byte[] ReadConfigration()
        {
            this.Connect();
            List<byte> sendData = new List<byte>(255);
            //[1].Send
            sendData.AddRange(ValueHelper.Instance.GetBytes(this.NextDataIndex()));//1~2.(Transaction Identifier)
            sendData.AddRange(new Byte[] { 0, 0 });//3~4:Protocol Identifier,0 = MODBUS protocol
            sendData.AddRange(ValueHelper.Instance.GetBytes((short)2));//5~6:后续的Byte数量（针对读读取配置后面有2个byte）
            sendData.Add(ID);//7:Unit Identifier:This field is used for intra-system routing purpose.
            sendData.Add(0x62);//8.Function Code 
            socketWrapper.Write(sendData.ToArray()); //发送读请求

            //[2].防止连续读写引起前台UI线程阻塞
            Application.DoEvents();
            
            //[3].读取Response Header : 完后会返回8个byte的Response Header
            byte[] receiveData = socketWrapper.Read();//缓冲区中的数据总量不超过256byte，一次读256byte，防止残余数据影响下次读取
            short identifier = (short)((receiveData[0] << 8) + receiveData[1]);

            //[4].读取返回数据：根据ResponseHeader，读取后续的数据
            if (identifier != CurrentDataIndex) //请求的数据标识与返回的标识不一致，则丢掉数据包
            {
                return new Byte[0];
            }
            //byte length = receiveData[8];//最后一个字节，记录寄存器中数据的Byte数
            byte[] result = new byte[29];
            if (receiveData.Length >= 9)
            {
                Array.Copy(receiveData, 8, result, 0, 29);
            }
            else
            {
                result = null;
            }
            DisConnect();
            return result;          
        }
        public  byte[] Receive(short DevNum,short StartAddr,short RegNum,byte Command)//支持3和4号命令
        {
            this.Connect();
            List<byte> sendData = new List<byte>(255);
            //[1].Send
            sendData.AddRange(ValueHelper.Instance.GetBytes(this.NextDataIndex()));//1~2.(Transaction Identifier)
            sendData.AddRange(new Byte[] { 0, 0 });//3~4:Protocol Identifier,0 = MODBUS protocol
            sendData.AddRange(ValueHelper.Instance.GetBytes((short)6));//5~6:后续的Byte数量（针对读请求，后续为6个byte）
            sendData.Add(1);//7:Unit Identifier:This field is used for intra-system routing purpose.
            sendData.Add(Command);//8.Function Code : 3 (Read Multiple Register)
            sendData.AddRange(ValueHelper.Instance.GetBytes(StartAddr));//9~10.起始地址
            sendData.AddRange(ValueHelper.Instance.GetBytes((short)RegNum));//11~12.需要读取的寄存器数量
            this.socketWrapper.Write(sendData.ToArray()); //发送读请求

            //[2].防止连续读写引起前台UI线程阻塞
            Application.DoEvents();

            //[3].读取Response Header : 完后会返回8个byte的Response Header
            byte[] receiveData = this.socketWrapper.Read();//缓冲区中的数据总量不超过MAX_LENGTH
            short identifier = (short)((((short)receiveData[0]) << 8) + receiveData[1]);

            //[4].读取返回数据：根据ResponseHeader，读取后续的数据
            if (identifier != this.CurrentDataIndex) //请求的数据标识与返回的标识不一致，则丢掉数据包
            {
                return new Byte[0];
            }
            byte length = receiveData[8];//最后一个字节，记录寄存器中数据的Byte数
            byte[] result = new byte[length];
            Array.Copy(receiveData, 9, result, 0, length);
            return result;
        }
        public  void SetConfigration(byte[] data)
        {
            this.Connect();
            List<byte> values = new List<byte>();
            //[1].Write Header：MODBUS Application Protocol header
            values.AddRange(ValueHelper.Instance.GetBytes(this.NextDataIndex()));//1~2.(Transaction Identifier)
            values.AddRange(new Byte[] { 0, 0 });//3~4:Protocol Identifier,0 = MODBUS protocol
            values.AddRange(ValueHelper.Instance.GetBytes((byte)(0x1F)));//5~6:后续的Byte数量,固定长度
            values.Add(ID);//7:Unit Identifier:This field is used for intra-system routing purpose.
            values.Add((byte)0x63);//8.Function Code : 16 (Write Multiple Register)
            //values.AddRange(ValueHelper.Instance.GetBytes(StartingAddress));//9~10.起始地址
            //values.AddRange(ValueHelper.Instance.GetBytes((short)(data.Length / 2)));//11~12.寄存器数量
            //values.Add((byte)data.Length);//13.数据的Byte数量

            //[2].增加数据
            values.AddRange(data);//14~End:需要发送的数据

            //[3].写数据
            this.socketWrapper.Write(values.ToArray());

            //[4].防止连续读写引起前台UI线程阻塞
            Application.DoEvents();

            //[5].读取Response: 写完后读取返回结果
            /*暂时先不读取返回的数据*/
            byte[] responseHeader = this.socketWrapper.Read();
            this.DisConnect();
        }
        #region Transaction Identifier
        /// <summary>
        /// 数据序号标识
        /// </summary>
        private byte dataIndex = 0;

        protected byte CurrentDataIndex
        {
            get { return this.dataIndex; }
        }

        protected byte NextDataIndex()
        {
            return ++this.dataIndex;
        }
        #endregion
        #region IDisposable 成员
        public virtual void Dispose()
        {
        }
        #endregion
    }
}
