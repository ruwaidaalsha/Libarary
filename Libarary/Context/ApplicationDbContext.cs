using Libarary.Models.Books;
using Libarary.Models.Libarary_system;
using Libarary.Models.Storage;
using Libarary.Models.Trans;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Libarary.Context
{
    public class ApplicationDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string con = ("Data Source = .; Database=LibararyVS;Integrated Security = True; Connect Timeout = 30;" +
                " Encrypt = true; Trust Server Certificate = True; Application Intent = ReadWrite;");
            optionsBuilder.UseSqlServer(con);

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BookAuthor>()
                .HasKey(ba => new { ba.BookID, ba.AuthorID });

            modelBuilder.Entity<BookStorage>()
                .HasKey(ba => new { ba.BookID, ba.BranchID });

        }
        

        public DbSet<Author> authors { get; set; }
        public DbSet<Book> books { get; set; }
        public DbSet<BookAuthor> booksAuthors { get; set; }
        public DbSet<Genre> genres { get; set; }
        public DbSet<Publisher> publishers { get; set; }
        public DbSet<LibararyBranche> LibararyBranches { get; set; }
        public DbSet<LibraryMember> libraryMembers { get; set; }
        public DbSet<LibraryStaff> libraryStaffs { get; set; }
        public DbSet<BookStorage> bookStorages { get; set; }
        public DbSet<TransactionRecord> transactions { get; set; }







    }
}
