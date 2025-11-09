using Libarary.Models.Books;
using Libarary.Models.Libarary_system;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libarary.Models.Trans
{
    public class TransactionRecord
    {
        [Key]
        public int TransactionID { get; set; }
        public DateOnly Date { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Penalties { get; set; }


        [ForeignKey(nameof(Book))]
        public int BookID { get; set; }
        public Book Book { get; set; }

        [ForeignKey(nameof(LibraryMember))]
        public int MemberID { get; set; }
        public LibraryMember LibraryMember { get; set; }

        [ForeignKey(nameof(LibraryStaff))]
        public int StuffID { get; set; }
        public LibraryStaff LibraryStaff { get; set; }


    }
}
