using Libarary.Models.Enum;
using Libarary.Models.Storage;
using Libarary.Models.Trans;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Libarary.Models.Books
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }
        public string Title { get; set; }
        public DateOnly PublicationYear { get; set; }
        public int ISBN { get; set; }
        public AvailbilityStatus status { get;set; }

        [ForeignKey(nameof(Genre))]
        public int GenreID { get; set; }
        public Genre Genre { get; set; }

        [ForeignKey(nameof(Publisher))]
        public int PublisherID { get; set; }
        public Publisher Publisher { get; set; }

        public ICollection<TransactionRecord> transaction { get; set; } = new List<TransactionRecord>();
        public ICollection<BookAuthor> bookAuthors { get; set; } = new List<BookAuthor>();

        public ICollection<BookStorage> bookStorages { get; set; } = new List<BookStorage>();



    }
}
