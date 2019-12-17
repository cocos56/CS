using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Text;
using System.Web.SessionState;//使用session的命名空间

namespace MyBlog
{
    /// <summary>
    /// 验证码     类
    /// </summary>
    public class CheckCode :IHttpHandler,IRequiresSessionState
    {
        //创建一个用于产生随机数的对象
        Random rom = new Random();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "image/jpeg";
            //创建一个图片对象，指定它的宽和高
            using(Image img = new Bitmap(80, 27))
            {
                //得到一个随机验证码字符串
                string[] strs=GetCheckCode().Split(' ');
                string chCode ="";
                foreach(string str in strs)
                {
                    chCode += str;
                }
                SaveToSession(context, "chCode", chCode.ToLower());

                DrawImgAndResponse(context, img, chCode);

            }
        }

        #region 把一个对象 存入到session中，键是key，值是value
        /// <summary>
        /// 把一个对象 存入到session中，键是key
        /// </summary>
        /// <param name="key">上写文对象</param>
        /// <param name="key">session的键</param>
        /// <param name="value">要保存到session中的值</param>
        public void SaveToSession(HttpContext context, string key, object obj)
        {
            context.Session[key] = obj;
            //创建cookie对象
            //HttpCookie cookie = new HttpCookie(key, value);
            //把cookie保存到服务器session中并把sessionId发回给浏览器
            //context.Response.Cookies.Add(cookie);
        } 
        #endregion

        #region 画验证码图片并发回给浏览器
        /// <summary>
        /// 画验证码图片并发回给浏览器
        /// </summary>
        /// <param name="context"></param>
        /// <param name="img"></param>
        /// <param name="chCode"></param>
        private void DrawImgAndResponse(HttpContext context, Image img, string chCode)
        {
            //从图片得到一个用于画这张图片的画笔
            using(Graphics g = Graphics.FromImage(img))
            {
                //用颜色清空图片
                g.Clear(Color.White);
                //画一个验证码图片的矩形
                g.DrawRectangle(Pens.Blue, new Rectangle(0, 0, img.Width - 1, img.Height - 1));
                //画噪点
                DrawPoint(g);
                //开始把验证码字符串画到图片上
                g.DrawString(chCode, new Font("Calibri", 16), Brushes.Red, new PointF(4, 2));
                //再画噪点
                DrawPoint(g);
                //将图片以二进制流的格式传到响应报文的缓冲区中
                img.Save(context.Response.OutputStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        } 
        #endregion

        #region 随机生成一个5个字符的验证码字符串(字母或者数字)
        /// <summary>
        /// 随机生成一个5个字符的验证码字符串(字母或者数字)
        /// </summary>
        /// <returns></returns>
        public string GetCheckCode()
        {
            char[] chs = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', 'A', 'B', 'C', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < 5; i++)
            {
                if(i < 4)
                {
                    sb.Append(chs[rom.Next(chs.Length)]).Append(" ");
                }
                else
                {
                    sb.Append(chs[rom.Next(chs.Length)]);
                }
            }
            return sb.ToString();
        } 
        #endregion

        /// <summary>
        /// 画噪点
        /// </summary>
        /// <param name="g"></param>
        void DrawPoint(Graphics g)
        {
            Pen[] pens = { Pens.Blue, Pens.Black, Pens.Red, Pens.Green };
            Point p1;
            Point p2;
            int length = 1;
            for(int i = 0; i < 50; i++)
            {
                p1 = new Point(rom.Next(80), rom.Next(27));
                p2 = new Point(p1.X - length, p1.Y - length);
                length = rom.Next(5);
                g.DrawLine(pens[rom.Next(pens.Length)], p1, p2);
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}