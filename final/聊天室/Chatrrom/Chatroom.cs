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

namespace Chatrrom
{
    public partial class Chatroom : Form
    {
        Socket clientSocket;//客户端套接字
        string name;//用户名
        IPAddress ip;//地址信息

        /*
         * 建立修改信息委托
         * 用于在子线程中修改初始线程创建的richtextbox组件的text属性
         */
        public delegate void chMsg(string msg);

        public Chatroom()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void sendBt_Click(object sender, EventArgs e)
        {
            send();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (clientSocket !=null )
            {
                //已经存在连接
                case true:
                    MessageBox.Show("请不要随意更改用户名或服务器地址！");
                    break;

                //还没有存在连接
                default:
                    switch (textBox2.Text)
                    {
                        //空用户名
                        case "":
                            MessageBox.Show("请输入正确的用户名");
                            break;

                        //信息合法
                        default:
                            try
                            {
                                ip = IPAddress.Parse(textBox1.Text);
                            }
                            catch(System.FormatException)
                            {
                                MessageBox.Show("请输入正确的IP地址");
                                name = null;
                                ip = null;
                                clientSocket = null;
                                break;
                            }
                            richTextBox1.Text += "用户名设置为：" + textBox2.Text + "\r\n";
                            name = "[" + textBox2.Text + "]：";
                            richTextBox1.Text += "服务器IP地址设置为：" + textBox1.Text + "\r\n";
                            //创建
                            try
                            {
                                clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                                byte[] msg = new byte[256];
                                IPEndPoint port = new IPEndPoint(ip, 1234);
                                clientSocket.Connect(port);
                                richTextBox1.Text += "连接成功\r\n";

                                //先发送昵称给服务器
                                byte[] sendName = Encoding.UTF8.GetBytes(textBox2.Text);
                                clientSocket.Send(sendName);

                                //创建新线程来接收消息，防止主线程阻塞
                                Thread th = new Thread(() =>
                                {
                                    while (true)
                                    {
                                        try
                                        {
                                            clientSocket.Receive(msg, 0, 256, SocketFlags.None);
                                            string data = Encoding.UTF8.GetString(msg);
                                            chMsg mch = new chMsg((string chMsg) => { this.richTextBox1.Text += chMsg; });
                                            BeginInvoke(mch, new object[] { data });
                                        }
                                        catch (SocketException)
                                        {
                                            MessageBox.Show("服务器断开连接！请重新连接！");
                                            clientSocket.Close();
                                            name = null;
                                            ip = null;
                                            clientSocket = null;
                                            break;
                                        }
                                    }
                                });
                                th.Start();
                            }
                            catch (SocketException)
                            {
                                MessageBox.Show("连接服务器失败，请稍后重试！");
                                name = null;
                                ip = null;
                                clientSocket = null;
                            }
                            break;
                    }
                    break;
            }
        }

        private void sendTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                send();
            }
        }

        void send()
        {
            if (clientSocket == null)
            {
                MessageBox.Show("请先输入用户名和服务器地址！");
                return;
            }
            byte[] msg = Encoding.UTF8.GetBytes(name + sendTextBox.Text + "\r\n");
            clientSocket.Send(msg);
            sendTextBox.Text = "";
        }


        //自动滚屏
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }

        private void Chatroom_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (clientSocket != null)
                clientSocket.Close();
            Environment.Exit(0);
        }
    }
}
