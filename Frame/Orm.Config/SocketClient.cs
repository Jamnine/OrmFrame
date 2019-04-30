using System;
using System.Net.Sockets;
using System.Threading;

namespace Orm.Config
{
    public class SocketClient
    {
        //定义IP属性，唯一界定客户端
        public string IP = null;
        public string UserID = null;
        public string UserName = null;

        //注册断开客户端事件        
        public delegate void clientdisConnect(object sender, EventArgs e);
        public event clientdisConnect OnClientdisConnect;

        //注册收到客户端消息事件
        public delegate void clientMessage(object sender, EventArgs e, string message);
        /// <summary>
        /// 注册收到客户端消息事件
        /// </summary>
        public event clientMessage OnclientMessage;

        //变量
        private Socket clientSocket = null;
        private Thread thread;
        private bool flag = true;


        //构造函数
        public SocketClient()
        {
            try
            {
                clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                clientSocket.Connect(System.Configuration.ConfigurationManager.AppSettings["ServerIP"], 8545);
                thread = new Thread(new ThreadStart(WaitForSendData));
                thread.IsBackground = true;
                thread.Name = clientSocket.RemoteEndPoint.ToString();
                thread.Start();
            }
            catch (Exception)
            {
                return;
            }
        }

        /// <summary>
        /// 等待数据通信函数
        /// </summary>
        private void WaitForSendData()
        {
            string message = null;
            while (flag)
            {
                if (clientSocket.Connected)
                {
                    try
                    {
                        byte[] bytes = new byte[1024];
                        int bytesRec = clientSocket.Receive(bytes);
                        if (bytesRec > 0)
                        {
                            message = System.Text.Encoding.UTF8.GetString(bytes);

                            if (OnclientMessage != null)
                            {
                                OnclientMessage(this, new EventArgs(), message);
                            }
                        }
                    }
                    catch (Exception)
                    {
                        killSelf();
                    }
                }
                else
                {
                    killSelf();
                }
            }
        }

        /// <summary>
        /// 客户端自毁方法
        /// </summary>
        public void killSelf()
        {
            flag = false;

            if (clientSocket != null && clientSocket.Connected)
            {
                clientSocket.Close();
                clientSocket = null;
            }

            //一定要写在线程结束前，否则不触发
            if (OnClientdisConnect != null)
            {
                OnClientdisConnect(this, new EventArgs());
            }

            if (thread != null && thread.IsAlive)
            {
                thread.Abort();
                thread = null;
            }
        }

        //向客户端发送信息方法
        public void setMessage(string message)
        {
            try
            {
                byte[] sendbytes = System.Text.Encoding.UTF8.GetBytes(message);
                int successSendBtyes = clientSocket.Send(sendbytes, sendbytes.Length, SocketFlags.None);
            }
            catch (Exception)
            {

            }
        }
        //代码结束
    }
}
