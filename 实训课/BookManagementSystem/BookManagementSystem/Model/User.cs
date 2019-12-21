using BookManagementSystem.Frameworrk;
using BookManagementSystem.View;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public void ShowUserBook()
        {

            Console.WriteLine("*************展示用户手中所有图书*********");
            if (bookList.Count == 0)
            {
                Utils.Error("********用户手中无书*********");
            }
            else
            {
                List<Book> booklist = bookList.Values.ToList();
                UIManager.Instance.Open<ShowBookInfoView>().ShowBooksInfo(booklist);
            }
        }
    }
}