using System;
using System.Net.Sockets;
using System.Threading;//线程

namespace ChatRoomServer
{
    public class ClientManager
    {
        #region 1.0 全局   通信套接字+Socket _skSend; 
        /// <summary>
        /// 全局   通信套接字
        /// </summary>
        Socket _skReceive;
        public Socket SkReceive
        {
            get { return _skReceive; }
        } 
        #endregion

        #region 全局委托+DGRemoveClient _dgRemoveClient;
        /// <summary>
        /// 全局委托+DGRemoveClient _dgRemoveClient;
        /// </summary>
        DGRemoveClient _dgRemoveClient; 
        #endregion

        #region 2.0 全局委托+DGReceiveMsg _dg; 
        /// <summary>
        /// 全局委托
        /// </summary>
        DGReceiveMsg _dg;
        #endregion

        #region 全局委托-把用户从在线列表移除
        /// <summary>
        /// 全局委托-把用户从在线列表移除
        /// </summary>
        DGAppendMsg _dgApMsg; 
        #endregion

        #region 3.0 构造函数初始化全局变量+ClientManager(Socket socket, DGReceiveMsg dg)
        /// <summary>
        /// 构造函数初始化全局变量
        /// </summary>
        public ClientManager(Socket socket, DGReceiveMsg dgRev, DGRemoveClient dgDel, DGAppendMsg dgApMsg)
        {
            _skReceive = socket;
            _dg = dgRev;
            _dgRemoveClient = dgDel;
            _dgApMsg = dgApMsg;
            dgApMsg(_skReceive.RemoteEndPoint.ToString()+"进来了........");

            //通过线程接收处理接收到的数据
            Thread th = new Thread(Receiving);
            //设置为后台线程
            th.IsBackground = true;
            //开启线程
            th.Start();
        } 
        #endregion

        #region 4.0 线程控制正在接收消息+void Receiving()
        /// <summary>
        /// 线程控制正在接收消息
        /// </summary>
        private void Receiving()
        {
            try
            {
                //调用委托里的方法
                _dg(_skReceive);
            }
            catch(Exception)
            {
                //异常处理，一旦客户端下限，那么连接这个客户端的socket就会被销毁，这时就要停止线程调用的方法了
                CloseClient();
            }
        }
        #endregion

        #region 5.0 重写的tostring方法直接转成当前通信套接字的远程端点+override string ToString()
        /// <summary>
        /// 重写的tostring方法直接转成当前通信套接字的远程端点
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this._skReceive.RemoteEndPoint + "\r\n";
        } 
        #endregion

        #region 6.0 将当前用户从服务端的在线列表中移除+void CloseClient()
        /// <summary>
        /// 将当前用户从服务端的在线列表中移除
        /// </summary>
        private void CloseClient()
        {
            //向服务端添加提示
            _dgApMsg(_skReceive.RemoteEndPoint.ToString()+"已下线.........");
            //将当前用户的连接从服务端的用户列表移除
            _dgRemoveClient(this);
        } 
        #endregion
    }
}