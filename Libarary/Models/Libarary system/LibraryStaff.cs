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
    public class LibraryStaff
    {
        [Key]
        public int StuffID  { get; set; }
        public string Name { get; set; }
        public Positions Position { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public ICollection<TransactionRecord> transaction { get; set; } = new List<TransactionRecord>();

    }
}
