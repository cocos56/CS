using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace server1
{
    public partial class ChatServer : Form
    {
        Socket serverSocket;//服务器监听套接字
        List<Socket> clientList = new List<Socket>();//客户端套接字列表
        public delegate void chMsg(string msg);


        public ChatServer()
        {
            InitializeComponent();
        }

        //用于接受新的客户端连接
        void accept()
        {
            while (true)
            {
                Socket s;
                s = serverSocket.Accept();//等待客户端连接，该函数是阻塞的
                clientList.Add(s);//获取到新的客户端后将其加入客户端套接字列表中



                //开启新的线程处理该客户端的请求，防止主线程阻塞
                Thread th = new Thread(() =>
                {
                    //获取用户名
                    byte[] name = new byte[256];
                    s.Receive(name, 0, 256, SocketFlags.None);
                    string nameS = Encoding.UTF8.GetString(name);
                    //输出连接信息
                    chMsg chmsg = new chMsg((string msgOut) => { this.richTextBox1.Text += msgOut; });
                    BeginInvoke(chmsg, nameS);
                    BeginInvoke(chmsg, "已连接\r\n");

                    while (true)
                    {
                        try
                        {
                            byte[] msg = new byte[256];
                            s.Receive(msg, 0, 256, SocketFlags.None);//接受客户端消息
                            sendToAll(msg);//发送到所有客户端
                            msg = null;
                        }
                        catch (SocketException e)
                        {
                            //抓取socket连接错误，判断断开连接
                            for (int i = 0; i < clientList.Count(); i++)
                            {
                                if (clientList[i] == s)
                                {
                                    clientList.Remove(clientList[i]);
                                    BeginInvoke(chmsg, nameS);
                                    BeginInvoke(chmsg, "已断开连接");
                                    break;
                                }
                            }
                            s.Close();
                            break;
                        }
                    }
                });
                th.Start();//启动线程
            }
        }

        //将从客户端获取到的消息发送到所有客户端
        void sendToAll(byte[] msg)
        {
            foreach (Socket s in clientList)
            {
                s.Send(msg, 0, 256, SocketFlags.None);//发送消息至客户端
            }
        }

        private void server1_Load(object sender, EventArgs e)
        {
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);//实例化服务器套接字
            IPEndPoint port = new IPEndPoint(IPAddress.Any, 1234);//端口信息
            serverSocket.Bind(port);//给套接字命名
            serverSocket.Listen(100);//开始监听请求

            //建立监听线程，防止主线程阻塞
            Thread accept = new Thread(new ThreadStart(this.accept));
            accept.Start();
        }

        private void server1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
