using Libarary.Models.Books;
using Libarary.Models.Enum;
using Libarary.Models.Trans;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Libarary.Models.Libarary_system
{
    public class LibraryMember
    {
        [Key]
        public int MemberID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactDetalis { get; set; }
       
        public MembershipStatus Membership { get; set; }

        public ICollection<TransactionRecord> transaction { get; set; } = new List<TransactionRecord>();
      



    }
}
