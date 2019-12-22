using BookManagementSystem.Frameworrk;
using BookManagementSystem.Model;
using BookManagementSystem.Cache;
using BookManagementSystem.View;

namespace BookManagementSystem.Controller
{
    public class BookController:Singleton<BookController>
    {
        public void AddBook(string isbn,string bookname,string author,int addCount)
        {
            Book book = BookCache.Instance.GetBookByISBN(isbn);
            if (book == null)
            {
                book = BookCache.Instance.AddBook(isbn, bookname, author, addCount);
                
            }
            else
            {
                BookCache.Instance.UpdateBookCount_Add(book,addCount);

            }
            UIManager.Instance.Open<ShowBookInfoView>().ShowBookInfo(book);
            UIManager.Instance.Open<ManagerBookView>().ManagerBook();
        }

        /// <summary>
        /// 删除图书
        /// </summary>
        public void DeleteBook(int bookId)
        {
            if (BookCache.Instance.ExistBookByBookId(bookId))
            {
                BookCache.Instance.DeleteBook(bookId);
            }
            else
            {
                UIManager.Instance.Open<ShowBookInfoView>().Error("图书不存在，不能删除图书！");
            }
            UIManager.Instance.Open<ManagerBookView>().ManagerBook();
        }
    }
}