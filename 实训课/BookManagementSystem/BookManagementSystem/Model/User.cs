using System.Collections.Generic;

namespace BookManagementSystem.Model
{
    public class User:Role
    {

        Dictionary<int, Book> bookList = new Dictionary<int, Book>();

        /// <summary>
        /// 用户借书的数量
        /// </summary>
        public int Limit { get; set; }


        public override string ToString()
        {
            return string.Format("ID:{0} Username:{1} IdentifyType:{2}",ID,Username,IdentifyType.ToString());
        }
    }
}