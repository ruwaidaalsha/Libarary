using Libarary.Models.Books;
using Libarary.Models.Enum;
using Libarary.Models.Libarary_system;
using Libarary.Models.Storage;
using Libarary.Models.Trans;

namespace Libarary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tCentral City Library Management System \n");


            Author author = new Author
            {
                AuthorID = 1,
                Name = "J.K. Rowling",
                Nationality = "British",
                NotabkeWorks = "Harry Potter Series"
            };

            Publisher publisher = new Publisher
            {
                PublisherID = 1,
                Name = "Bloomsbury Publishing",
                ContactDetails = "info@bloomsbury.com"
            };

            Genre genre = new Genre
            {
                GenreID = 1,
                Name = "Fantasy"
            };


            Book book = new Book
            {
                BookID = 1001,
                Title = "Harry Potter and the Philosopher's Stone",
                ISBN = 9780,
                PublicationYear = new DateOnly(1997, 1, 1),
                status = AvailbilityStatus.Available,
                Publisher = publisher,
                Genre = genre

            };


            LibraryMember member = new LibraryMember
            {
                MemberID = 2001,
                Name = "Ahmad Al-Harthy",
                Address = "Muscat, Oman",
                ContactDetalis = "ahmad@example.com",
                Membership = MembershipStatus.Regular
            };

            LibraryStaff staff = new LibraryStaff
            {
                StuffID = 1,
                Name = "Sara Al-Balushi",
                Email = "sara@library.com",
                Phone = 9123456,
                Position = Positions.Librarian
            };


            LibararyBranche branch = new LibararyBranche
            {
                BranchID = 101,
                Name = "Central Branch",
                Address = "Downtown, Muscat",
                ContactInformation = "central@library.com"
            };


            BookStorage storage = new BookStorage();
            storage.AddBook(book);



            TransactionRecord transaction = new TransactionRecord
            {
                TransactionID = 1,
                Penalties = 0,
                Book = book,
                LibraryMember = member,
                Date = DateOnly.FromDateTime(DateTime.Now),
            };

            Console.WriteLine("\nTransaction Details:");
            Console.WriteLine($"Book Borrowed: {transaction.Book.Title}");
            Console.WriteLine($"Borrowed by: {transaction.LibraryMember.Name}");
            Console.WriteLine($"Date: {transaction.Date}");
            Console.WriteLine($"Handled by: {staff.Name}");
            Console.WriteLine("\nBook successfully borrowed!");


          

          
            Console.WriteLine("\nTransaction Details:");
            Console.WriteLine($"Book Borrowed: {transaction.Book.Title}");
            Console.WriteLine($"Borrowed by: {transaction.LibraryMember.Name}");
            Console.WriteLine($"Date: {transaction.Date}");
            Console.WriteLine($"Handled by: {staff.Name}");
            Console.WriteLine("\nBook successfully borrowed!");

            Console.WriteLine("\n End of Program ");
        }
    }
}

        

