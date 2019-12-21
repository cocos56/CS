using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManagementSystem.Cache;
using BookManagementSystem.View;
using BookManagementSystem.Frameworrk;

namespace BookManagementSystem.Model
{
    public class User:Role
    {
        //显示用户手中图书
        private int bookCount = 0;
        private int Id = 0;

        Dictionary<int, Book> bookList = new Dictionary<int, Book>();


        /// <summary>
        /// 用户借书的数量
        /// </summary>
        public int Limit { get; set; }

        public int Id1
        {
            get
            {
                return Id++;
            }

        }

        public int BookCount
        {
            get
            {
                return bookCount;
            }

            set
            {
                bookCount = value;
            }
        }

        public override string ToString()
        {
            return string.Format("ID:{0} Username:{1} IdentifyType:{2}",ID,Username,IdentifyType.ToString());
        }
        /// <summary>
        /// 增加书到字典
        /// </summary>
        /// <param name="book">将要增加的书</param>
        /// <param name="count">增加书的数</param>
        public void AddUserDic(Book book,int count,int bookid)
        {
            if (BookCount==Limit ||(BookCount + count) > Limit)
            {
                Error("**************用户借书数量超出权限，借书失败!***************");
                return;
            }
            else
            {
                if(!ExistByBookId(bookid))
                {
                    AddBook(book, count);
                }
                else
                {
                    bookList[bookid].Count += count;
                }
                BookCount += count;
                BookCache.Instance.UpdateBookCount_Reduce(book,count);
            }
        }
        public void DeleteUserDic(Book book, int count)
        {
            if(BookCount>0&&BookCount>=count)
            {
                int id= GetDictID(book);
                if((bookList[id].Count-count)==0)
                {
                    BookCount -= count;
                    bookList.Remove(id);
                } 
                else
                {
                    BookCount -= count;
                    ReduceBook(book, count);
                }
                BookCache.Instance.UpdateBookCount_Add(book, count);
            }
            else
            {
                Error("********用户还书失败!*************");
            }

        }
        public int GetDictID(Book book)
        {
            return bookList.Keys.ToList().Find((item) =>
            {
                return bookList[item].BookId ==book.BookId;
            });
        }
        public void Error(string error)
        {
            Console.WriteLine("**************错误提示**************");
            Console.WriteLine(error);
        }
        public void ShowUserBook()
        {
            
            Console.WriteLine("*************展示用户手中所有图书*********");
            if(bookList.Count==0)
            {
                Error("********用户手中无书*********");
            }
            else
            {
                List<Book> booklist = bookList.Values.ToList();
                UIManager.Instance.Open<ShowBookInfoView>().ShowBooksInfo(booklist);
            }
        }
        public  bool ExistByBookId(int bookid)
        {
            return bookList.Values.ToList().Exists((item) =>
            {
                return item.BookId == bookid;
            });
        }
        public Book GetBookByBookId(int bookId)
        {
            return bookList[bookId];
        }

        public void AddBook(Book oldbook, int addCount)
        {
            //增加书
            Book book = new Book()
            {
                BookId = oldbook.BookId,
                ISBN = oldbook.ISBN,
                BookName = oldbook.BookName,
                Author = oldbook.Author,
                Count = addCount
            };
            bookList.Add(book.BookId, book);
        }
        public void ReduceBook(Book book, int reduceCount)
        {
            //减少同名书
  
            int id = GetDictID(book);
            bookList[id].Count -= reduceCount;
        }

    }
}
