using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManagementSystem.Frameworrk;
using BookManagementSystem.Model;
using BookManagementSystem.View;
using BookManagementSystem.Cache;

namespace BookManagementSystem.Controller
{
    public class BorrowAndReturnBookController:Singleton<BorrowAndReturnBookController>
    {
        public void AddUserBook(User user,int count,int bookId)
        {
            if (BookCache.Instance.ExistBookByBookId(bookId))
            {
                Book  book= BookCache.Instance.GetBookByBookId(bookId);
                user.AddUserDic(book, count);
            }
            else
            {
                Error("图书不存在，借书失败！");
            }
        }
        public void DeleteUserBook(int bookId, int count, User user)
        {
            if (user.ExistByBookId(bookId))
            {
                Book book = BookCache.Instance.GetBookByBookId(bookId);
                user.DeleteUserDic(book, count);
            }
            else
            {
                Error("图书不存在，还书失败！");
            }
        }
        public void OpenBorrowView()
        {
            UIManager.Instance.Open<BorrowBookView>().borrowbook();
            OpenBorrowBookMainView();
        }
        public void OpenReturnView()
        {
            UIManager.Instance.Open<ReturnBookView>().returnBook();
            OpenRetrunBookMainView();
        }
        public void OpenUserMainView()
        {
            UIManager.Instance.Open<UserMainView>().userMain();
        }
        public void OpenRetrunBookMainView()
        {
            UIManager.Instance.Open<ReturnBookMainView>().returnbookView();
        }
        public void OpenBorrowBookMainView()
        {
            UIManager.Instance.Open<BorrowBookMinView >().broowbookview();
        }
        public void Error(string error)
        {
            Console.WriteLine("错误提示！");
            Console.WriteLine(error);
        }
        public void OpenShowUserBookList()
        {
            User user = DataManager.Instance.CurrentRole as User;
            user.ShowUserBook();
            OpenUserMainView();
        }
    }
}
