using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManagementSystem.Cache;
using BookManagementSystem.Controller;
namespace BookManagementSystem.View
{
    public  class SearchBookMainView:BaseView
    {
        public void  SearchBookView()
        {
            Console.WriteLine("*************查询书主界面******************");
            Console.WriteLine("*************1.按图书名字查找**********");
            Console.WriteLine("*************2.按图书ISBN查找******************");
            Console.WriteLine("*************3.按图书作者查找**********************");
            Console.WriteLine("*************4.列出所有图书**********************");
            Console.WriteLine("*************5.返回上一层******************");
            string res = Utils.Input("请输入你要做的操作：");
            switch (res)
            {
                case"1":
                    SearchBookController.Instance.FindBookByBookName();
                    break;
                case "2":
                    SearchBookController.Instance.FindBookByBookISBN();
                    break;
                case "3":
                    SearchBookController.Instance.FindBookByBookAuthor();
                    break;
                case "4":
                    SearchBookController.Instance.FindAllBook();
                    break;
                case "5":
                    ManagerController.Instance.OpenUserMainView();
                    break;
                default:
                    break;
            }
        }
    }
}
