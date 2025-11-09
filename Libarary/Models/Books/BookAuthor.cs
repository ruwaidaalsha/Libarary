using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libarary.Models.Books
{
    public class BookAuthor
    {
        [ForeignKey(nameof(Author))]
        public int AuthorID { get; set; }
        public Author Author { get; set; }



        [ForeignKey(nameof(Book))]
        public int BookID { get; set; }
        public Book Book { get; set; }

    }
}
