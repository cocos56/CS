using System;
using System.Net;//操作ip
using System.Net.Sockets;//socket类型
using System.Threading;
using System.Windows.Forms;

namespace ChatRoomServer
{
    public partial class Server :Form
    {
        public Server()
        {
            InitializeComponent();
            //取消控件的线程间的安全性检测
            TextBox.CheckForIllegalCrossThreadCalls = false;
            //取消控件的线程间的安全性检测
             RichTextBox.CheckForIllegalCrossThreadCalls = false;
        }

        bool _flag = true;//是否监听的标识符

        Thread thLs = null;

        #region 全局socket对象，用于接收监听和接收、发送信息+Socket _socket
        /// <summary>
        /// 全局socket对象，用于接收监听和接收、发送信息+Socket _socket
        /// </summary>
        Socket _socket = null; 
        #endregion

        //#region 用来保存每个连接的集合+List<ClientManager> _clientList
        ///// <summary>
        ///// 用来保存每个连接的集合
        ///// </summary>
        //List<ClientManager> _clientList = new List<ClientManager>(); 
        //#endregion

        #region 1.0 监听按钮   开始监听.....
        /// <summary>
        /// 1.0 开始监听.....
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBegin_Click(object sender, EventArgs e)
        {
            btnBegin.Enabled = false;//监听按钮不可用
            AppendMsg("正在监听~~~~~");
            string ip = txtIP.Text.Trim();
            string port = txtPort.Text.Trim();
            //创建一个ip地址对象
            IPAddress ipAdr = IPAddress.Parse(ip);
            //创建一个网络节点对象
            IPEndPoint ipont = new IPEndPoint(ipAdr, Convert.ToInt32(port));
            //创建   监听套接字    使用ipv4地址协议，使用流套式套接字，使用tcp传输协议
            _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //绑定套接字的端口号
            _socket.Bind(ipont);
            //设置套接字的监听队列的长度
            _socket.Listen(10);
            //使用多线程来监听客户端的连接请求
            thLs = new Thread(Listening);
            //把线程设置为后台线程
            thLs.IsBackground = true;
            //开启线程
            thLs.Start();
        } 
        #endregion

        #region 2.0 通过多线程  开始监听+void Listening()
        /// <summary>
        /// 通过线程    开始监听
        /// </summary>
        private void Listening()
        {
            try
            {
                while(_flag)//监听套接字一直处于监听状态
                {

                    //开始监听,一旦监听到客户端的连接请求，便 返回一个 【通信套接字】 负责 和客户端通信
                    Socket liSk = _socket.Accept();


                    //AppendMsg("一个新的连接进来了~~~~~");
                    //使用多线程来接收客户端每次发送过来的信息(如果不适用多线程，那么只会接收到一次信息)
                    //Thread thMsg = new Thread(ReceiveMsg);


                    //下面是把一个新链接交给一个自定义的管理对象去管理线程，同时也要线程要执行的方法以委托的方式传递过去
                    ClientManager cm = new ClientManager(liSk,ReceiveMsg,RemoveClientFromList,AppendMsg);//语法糖    第二个参数要求传的是一个委托
                    //每有一个新客户端进来就把它的信息添加到在线列表
                    AppendClientList(cm);


                    //同样把这个线程设置为后台线程
                    //thMsg.IsBackground = true;
                    //开启线程，同时把线程要调用的方法要传递的参数带过去
                    //thMsg.Start(liSk);
                }
            }
            catch(Exception ex)
            {

            }
        } 
        #endregion

        #region 3.0 多线程   接收客户端消息+void ReceiveMsg(object obj)
        /// <summary>
        /// 多线程   接收客户端消息
        /// </summary>
        private void ReceiveMsg(Socket socket)
        {
                while(true)
                {
                    //用一个字节数组接收信息
                    byte[] buffer = new byte[1024 * 1024];
                    //接收客户端信息，返回值是接收到的字节数
                    int length = socket.Receive(buffer);
                    //将字节数组通过编码转成字符串
                    string msg = System.Text.Encoding.UTF8.GetString(buffer, 0, length);
                    //将接收到的客户端的信息追加到消息框
                    AppendMsg(msg);
                }
        } 
        #endregion

        #region 4.0  将信息追加到信息框+void AppendMsg(string msg)
        /// <summary>
        /// 将信息追加到信息框
        /// </summary>
        /// <param name="msg"></param>
        private void AppendMsg(string msg)
        {
            this.rtxtMsg.Text = this.rtxtMsg.Text + msg + "\r\n";
        } 
        #endregion

        #region 5.0 将一个连接用户添加到在线用户列表+void AppendClientList(ClientManager client)
        /// <summary>
        /// 5.0 将一个连接用户添加到在线用户列表-
        /// </summary>
        /// <param name="client"></param>
        private void AppendClientList(ClientManager client)
        {
            //将一个连接用户添加到在线用户列表
            listClient.Items.Add(client);
        } 
        #endregion

        #region 6.0 直接从客户列表移除这个客户+void RemoveClientFromList(ClientManager client)
        /// <summary>
        /// 6.0 直接从客户列表移除这个客户
        /// </summary>
        /// <param name="client"></param>
        private void RemoveClientFromList(ClientManager client)
        {
            //直接从客户列表移除这个客户
            listClient.Items.Remove(client);
        } 
        #endregion

        /// <summary>
        /// 发送按钮的  点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            //如果没选择要发送给哪个客户端
            if(listClient.SelectedItem == null)
            {
                MessageBox.Show("请选择要发送到的客户端~~");
            }
            else//有选择
            {
                string msg = txtISay.Text.Trim();
                //得到服务端选中的用户，并转成客户端管理者对象
                ClientManager cm = listClient.SelectedItem as ClientManager;
                //服务端向客户端发送消息
                SendMsg(cm.SkReceive, msg);
                txtISay.Text = "";
            }
        }

        #region 发送消息的方法   由线程调用+void SendMsg(Socket socket, string msg)
        /// <summary>
        /// 发送消息的方法   由线程调用
        /// </summary>
        /// <param name="socket"></param>
        /// <param name="msg"></param>
        private void SendMsg(Socket socket, string msg)
        {
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(msg);
            //服务端先客户端发送消息
            socket.Send(buffer);
        } 
        #endregion

        private void listClient_Click(object sender, EventArgs e)
        {
            btnSend.Enabled = true;
        }

    }
}