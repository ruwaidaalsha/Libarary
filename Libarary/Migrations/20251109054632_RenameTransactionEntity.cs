using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Libarary.Migrations
{
    /// <inheritdoc />
    public partial class RenameTransactionEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "authors",
                columns: table => new
                {
                    AuthorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NotabkeWorks = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_authors", x => x.AuthorID);
                });

            migrationBuilder.CreateTable(
                name: "genres",
                columns: table => new
                {
                    GenreID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_genres", x => x.GenreID);
                });

            migrationBuilder.CreateTable(
                name: "LibararyBranches",
                columns: table => new
                {
                    BranchID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactInformation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibararyBranches", x => x.BranchID);
                });

            migrationBuilder.CreateTable(
                name: "libraryMembers",
                columns: table => new
                {
                    MemberID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactDetalis = table.Column<int>(type: "int", nullable: false),
                    Membership = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_libraryMembers", x => x.MemberID);
                });

            migrationBuilder.CreateTable(
                name: "libraryStaffs",
                columns: table => new
                {
                    StuffID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Positions = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_libraryStaffs", x => x.StuffID);
                });

            migrationBuilder.CreateTable(
                name: "publishers",
                columns: table => new
                {
                    PublisherID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactDetails = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_publishers", x => x.PublisherID);
                });

            migrationBuilder.CreateTable(
                name: "books",
                columns: table => new
                {
                    BookID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublicationYear = table.Column<DateOnly>(type: "date", nullable: false),
                    ISBN = table.Column<int>(type: "int", nullable: false),
                    AvailbilityStatus = table.Column<int>(type: "int", nullable: false),
                    GenreID = table.Column<int>(type: "int", nullable: false),
                    PublisherID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_books", x => x.BookID);
                    table.ForeignKey(
                        name: "FK_books_genres_GenreID",
                        column: x => x.GenreID,
                        principalTable: "genres",
                        principalColumn: "GenreID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_books_publishers_PublisherID",
                        column: x => x.PublisherID,
                        principalTable: "publishers",
                        principalColumn: "PublisherID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "booksAuthors",
                columns: table => new
                {
                    AuthorID = table.Column<int>(type: "int", nullable: false),
                    BookID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_booksAuthors", x => new { x.BookID, x.AuthorID });
                    table.ForeignKey(
                        name: "FK_booksAuthors_authors_AuthorID",
                        column: x => x.AuthorID,
                        principalTable: "authors",
                        principalColumn: "AuthorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_booksAuthors_books_BookID",
                        column: x => x.BookID,
                        principalTable: "books",
                        principalColumn: "BookID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "bookStorages",
                columns: table => new
                {
                    BranchID = table.Column<int>(type: "int", nullable: false),
                    BookID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookStorages", x => new { x.BookID, x.BranchID });
                    table.ForeignKey(
                        name: "FK_bookStorages_LibararyBranches_BranchID",
                        column: x => x.BranchID,
                        principalTable: "LibararyBranches",
                        principalColumn: "BranchID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_bookStorages_books_BookID",
                        column: x => x.BookID,
                        principalTable: "books",
                        principalColumn: "BookID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "transactions",
                columns: table => new
                {
                    TransactionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    Penalties = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BookID = table.Column<int>(type: "int", nullable: false),
                    MemberID = table.Column<int>(type: "int", nullable: false),
                    StuffID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transactions", x => x.TransactionID);
                    table.ForeignKey(
                        name: "FK_transactions_books_BookID",
                        column: x => x.BookID,
                        principalTable: "books",
                        principalColumn: "BookID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_transactions_libraryMembers_MemberID",
                        column: x => x.MemberID,
                        principalTable: "libraryMembers",
                        principalColumn: "MemberID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_transactions_libraryStaffs_StuffID",
                        column: x => x.StuffID,
                        principalTable: "libraryStaffs",
                        principalColumn: "StuffID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_books_GenreID",
                table: "books",
                column: "GenreID");

            migrationBuilder.CreateIndex(
                name: "IX_books_PublisherID",
                table: "books",
                column: "PublisherID");

            migrationBuilder.CreateIndex(
                name: "IX_booksAuthors_AuthorID",
                table: "booksAuthors",
                column: "AuthorID");

            migrationBuilder.CreateIndex(
                name: "IX_bookStorages_BranchID",
                table: "bookStorages",
                column: "BranchID");

            migrationBuilder.CreateIndex(
                name: "IX_transactions_BookID",
                table: "transactions",
                column: "BookID");

            migrationBuilder.CreateIndex(
                name: "IX_transactions_MemberID",
                table: "transactions",
                column: "MemberID");

            migrationBuilder.CreateIndex(
                name: "IX_transactions_StuffID",
                table: "transactions",
                column: "StuffID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "booksAuthors");

            migrationBuilder.DropTable(
                name: "bookStorages");

            migrationBuilder.DropTable(
                name: "transactions");

            migrationBuilder.DropTable(
                name: "authors");

            migrationBuilder.DropTable(
                name: "LibararyBranches");

            migrationBuilder.DropTable(
                name: "books");

            migrationBuilder.DropTable(
                name: "libraryMembers");

            migrationBuilder.DropTable(
                name: "libraryStaffs");

            migrationBuilder.DropTable(
                name: "genres");

            migrationBuilder.DropTable(
                name: "publishers");
        }
    }
}
