using Libarary.Models.Books;
using Libarary.Models.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libarary.Models.Libarary_system
{
    public class LibararyBranche
    {
        [Key]
        public int BranchID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactInformation { get; set; }

        public ICollection<BookStorage> bookStorages { get; set; } = new List<BookStorage>();



    }
}
