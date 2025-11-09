using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libarary.Models.Books
{
    public class Author
    {
        [Key]
        public int AuthorID { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }
        public string NotabkeWorks { get; set; }

        public ICollection<BookAuthor> bookAuthor { get; set; } = new List<BookAuthor>();

    }



}
