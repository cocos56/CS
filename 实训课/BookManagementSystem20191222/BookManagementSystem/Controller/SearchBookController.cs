using System;
using System.Collections.Generic;
using BookManagementSystem.Frameworrk;
using BookManagementSystem.Cache;
using BookManagementSystem.Model;
using BookManagementSystem.View;

namespace BookManagementSystem.Controller
{
    public class SearchBookController:Singleton<SearchBookController>
    {
        public void FindBookByBookName()
        {
            string name = Utils.Input("请输入要查询的图书名字：");
            if (BookCache.Instance.ExistByName(name))
            {
                Book book = BookCache.Instance.GetBookByName(name);
                UIManager.Instance.Open<ShowBookInfoView>().ShowBookInfo(book);
                UIManager.Instance.Open<SearchBookMainView>().SearchBookView();
            }
        }

        public void FindBookByBookISBN()
        {
            string isbn = Utils.Input("请输入要查询的图书ISBN：");
            if (BookCache.Instance.ExistByISBN(isbn))
            {
                Book book=BookCache.Instance.GetBookByISBN(isbn);
                UIManager.Instance.Open<ShowBookInfoView>().ShowBookInfo(book);
                UIManager.Instance.Open<SearchBookMainView>().SearchBookView();
            }
        }
        public void FindBookByBookAuthor()
        {
            string name = Utils.Input("请输入要查询的图书作者名字：");
            if (BookCache.Instance.ExistByAuthorName(name))
            {
                Book book = BookCache.Instance.GetBookByAuthorName(name);
                UIManager.Instance.Open<ShowBookInfoView>().ShowBookInfo(book);
                UIManager.Instance.Open<SearchBookMainView>().SearchBookView();
            }
        }
        public void FindAllBook()
        {
            List<Book> booklist= BookCache.Instance.GetAllBooks();
            UIManager.Instance.Open<ShowBookInfoView>().ShowBooksInfo(booklist);
            UIManager.Instance.Open<SearchBookMainView>().SearchBookView();
        }
        public void Error(string error)
        {
            Console.WriteLine("**************错误提示************");
            Console.WriteLine(error);
        }
    }
}