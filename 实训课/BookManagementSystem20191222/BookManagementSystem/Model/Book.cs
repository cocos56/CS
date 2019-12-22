using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem.Model
{
    public class Book
    {
        /// <summary>
        /// id
        /// </summary>
        public int BookId { get; set; }
        /// <summary>
        /// ISBN
        /// </summary>
        public string ISBN { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public int Count { get; set; }

        public override string ToString()
        {
            Console.WriteLine();
            return string.Format("Id:{0} ISBN:{1} bookname:{2} Author:{3} Count:{4}",BookId,ISBN,BookName,Author,Count);
        }

    }
}
