using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libarary.Models.Books
{
    public class Genre
    {
        [Key]
        public int GenreID { get; set; }
        public string Name { get; set; }
        public ICollection<Book> book { get; set; } = new List<Book>();
  

    }
}
