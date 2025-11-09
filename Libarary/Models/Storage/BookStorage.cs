using Libarary.Models.Books;
using Libarary.Models.Libarary_system;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libarary.Models.Storage
{
    public class BookStorage
    {
        public int BranchID { get; set; }
        public LibararyBranche LibararyBranche { get; set; }
        public int BookID { get; set; }
        public Book Book { get; set; }

       
        public void AddBook(Book book)
        {
            this.Book = book;
            this.BookID = book.BookID;
        }
    }
}
