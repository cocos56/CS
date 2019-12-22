using System;
using BookManagementSystem.Frameworrk;
using BookManagementSystem.Model;
using BookManagementSystem.View;
using BookManagementSystem.Cache;

namespace BookManagementSystem.Controller
{
    public class BorrowAndReturnBookController:Singleton<BorrowAndReturnBookController>
    {
        /// <summary>
        /// 借书
        /// </summary>
        /// <param name="user">用户名</param>
        /// <param name="count">数量</param>
        /// <param name="bookId">借的书的id</param>
        public void AddUserBook(User user,int count,int bookId)
        {
            //判断是不是在图书馆存在
            if (BookCache.Instance.ExistBookByBookId(bookId))
            {
                Book  book= BookCache.Instance.GetBookByBookId(bookId);
                if(book.Count<count)
                {
                    Error("图书数量不够，借书失败");
                }
                else
                {
                    user.AddUserDic(book, count, bookId, user);
                }
                
            }
            else
            {
                Error("图书不存在，借书失败！");
            }
        }

           public void AddUserBookByName(User user,int count,string  bookname)
        {
            //判断是不是在图书馆存在
            if (BookCache.Instance.ExistByName(bookname))
            {
                Book  book= BookCache.Instance.GetBookByName(bookname);
                if (book.Count < count)
                {
                    Error("图书数量不够，借书失败");
                }
                else
                {
                    user.AddUserDic(book, count, bookname, user);
                }
            }
            else
            {
                Error("图书不存在，借书失败！");
            }
        }

        /// <summary>
        /// 手中的id
        /// </summary>
        /// <param name="bookId">输入图书的id</param>
        /// <param name="count"></param>
        /// <param name="user"></param>
        public void DeleteUserBook(int bookId, int count, User user)
        {
            //判断是不是在用户手中存在
            if (user.ExistByBookId(bookId))
            {
                //从bookId取得书
                Book book = BookCache.Instance.GetBookByBookId(bookId);
                Book book1 = user.GetBookByBookId(bookId);
                if(book1.Count<count)
                {
                    Error("图书数量不够，还书失败！");
                }
                else
                {
                    user.DeleteUserDic(book, count, user);
                }
                
            }
            else
            {
                Error("图书不存在，还书失败！");
            }
        }
        /// <summary>
        /// 通过书名还书
        /// </summary>
        /// <param name="bookId"></param>
        /// <param name="count"></param>
        /// <param name="user"></param>
        public void DeleteUserBook(string  bookId, int count, User user)
        {
            //判断是不是在用户手中存在
            if (user.ExistByName(bookId))
            {
                //从bookId取得书
                Book book = BookCache.Instance.GetBookByName(bookId);
                Book book1 = user.GetBookByNameBook(bookId);
                if (book1.Count < count)
                {
                    Error("图书数量不够，还书失败！");
                }
                else
                {
                    user.DeleteUserDic(book, count, user);
                }
            }
            else
            {
                Error("图书不存在，还书失败！");
            }
        }



        /// <summary>
        /// 借书还书界面
        /// </summary>

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

        public void OpenBorrowViewByName()
        {
            UIManager.Instance.Open<BorrowBookView>().borrowbookByName();
            OpenBorrowBookMainView();
        }
        public void OpenReturnViewByName()
        {
            UIManager.Instance.Open<ReturnBookView>().returnBookByBookName();
            OpenRetrunBookMainView();
        }

        /// <summary>
        /// 借书还书界面
        /// </summary>






        public void OpenUserMainView()
        {
            UIManager.Instance.Open<UserMainView>().userMain();
        }
        //打开还书主界面
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