using System.Net.Sockets;

namespace ChatRoomServer
{
    /// <summary>
    /// 用于处理接收信息的委托
    /// </summary>
    public delegate void DGReceiveMsg(Socket socket);
}