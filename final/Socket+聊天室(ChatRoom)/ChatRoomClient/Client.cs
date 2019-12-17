using System;
using System.Threading;
using System.Windows.Forms;
using System.Net;//ip操作
using System.Net.Sockets;//socket套接字

namespace ChatRoomClient
{
    public partial class Client :Form
    {
        public Client()
        {
            InitializeComponent();
            RichTextBox.CheckForIllegalCrossThreadCalls = false;
        }

        bool flag = true;

        /// <summary>
        /// 全局套接字
        /// </summary>
        Socket _socket = null;

        #region 1.0 开始监听
        /// <summary>
        /// 3.0 开始监听
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBegin_Click(object sender, EventArgs e)
        {
            AppendMsg("正在连接服务器~~~~~");
            //开始连接服务器
            IPAddress ip = IPAddress.Parse(txtIP.Text.Trim());
            //获取    网络节点对象
            IPEndPoint ipont = new IPEndPoint(ip, Convert.ToInt32(txtPort.Text.Trim()));
            //创建一个用于监听    使用tcp传输协议传输的网络流
            _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //套接字尝试连接服务器
            //_socket.SendTimeout = 20000;
            try
            {
                _socket.Connect(ipont);
                AppendMsg("连接服务器成功！！！");
                //发送按钮可用
                btnSend.Enabled = true;
                //创建线程
                Thread th = new Thread(Receiving);
                //开启   接收消息  线程
                th.Start();
            }
            catch(Exception)
            {
                AppendMsg("连接服务器失败！！！");
            }
        } 
        #endregion

        #region 2.0  将信息追加到信息框+void AppendMsg(string msg)
        /// <summary>
        /// 将信息追加到信息框
        /// </summary>
        /// <param name="msg"></param>
        private void AppendMsg(string msg)
        {
            this.rtxtMsg.Text = this.rtxtMsg.Text + msg + "\r\n";
        }
        #endregion

        #region 3.0发送消息
        /// <summary>
        /// 5.0发送消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if(_socket != null)//判断是否已经连接才能发送
            {
                string msg = txtMsg.Text.Trim();
                AppendMsg(msg);
                //把字符串通过制定编码格式转成   二进制
                byte[] buffer = System.Text.Encoding.UTF8.GetBytes(msg);
                //听过套接字发送消息
                _socket.Send(buffer);
                //清空发送消息框
                txtMsg.Text = "";
            }
            else
            {
                MessageBox.Show("请先建立与服务器的连接~~~");
            }
        } 
        #endregion

        private void Receiving()
        {
            try
            {
                while(flag)
                {
                    byte[] buffer = new byte[1024 * 1024];
                    //接收消息
                    int length = _socket.Receive(buffer);
                    //将字节数组转成字符串
                    string msg = System.Text.Encoding.UTF8.GetString(buffer, 0, length);
                    //将消息添加到聊天窗口
                    AppendMsg(_socket.RemoteEndPoint.ToString() + "说：" + msg);
                }
            }
            catch(Exception)
            {
                AppendMsg("服务器端已被关闭！！！");
                btnSend.Enabled = false;
            }
        }
    }
}