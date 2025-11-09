using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Libarary.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBookStorageKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bookStorages_LibararyBranches_BranchID",
                table: "bookStorages");

            migrationBuilder.DropIndex(
                name: "IX_bookStorages_BranchID",
                table: "bookStorages");

            migrationBuilder.RenameColumn(
                name: "Positions",
                table: "libraryStaffs",
                newName: "Position");

            migrationBuilder.RenameColumn(
                name: "AvailbilityStatus",
                table: "books",
                newName: "status");

            migrationBuilder.AlterColumn<string>(
                name: "ContactDetails",
                table: "publishers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ContactDetalis",
                table: "libraryMembers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "LibararyBranches",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "LibararyBrancheBranchID",
                table: "bookStorages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_bookStorages_LibararyBrancheBranchID",
                table: "bookStorages",
                column: "LibararyBrancheBranchID");

            migrationBuilder.AddForeignKey(
                name: "FK_bookStorages_LibararyBranches_LibararyBrancheBranchID",
                table: "bookStorages",
                column: "LibararyBrancheBranchID",
                principalTable: "LibararyBranches",
                principalColumn: "BranchID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bookStorages_LibararyBranches_LibararyBrancheBranchID",
                table: "bookStorages");

            migrationBuilder.DropIndex(
                name: "IX_bookStorages_LibararyBrancheBranchID",
                table: "bookStorages");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "LibararyBranches");

            migrationBuilder.DropColumn(
                name: "LibararyBrancheBranchID",
                table: "bookStorages");

            migrationBuilder.RenameColumn(
                name: "Position",
                table: "libraryStaffs",
                newName: "Positions");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "books",
                newName: "AvailbilityStatus");

            migrationBuilder.AlterColumn<int>(
                name: "ContactDetails",
                table: "publishers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "ContactDetalis",
                table: "libraryMembers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_bookStorages_BranchID",
                table: "bookStorages",
                column: "BranchID");

            migrationBuilder.AddForeignKey(
                name: "FK_bookStorages_LibararyBranches_BranchID",
                table: "bookStorages",
                column: "BranchID",
                principalTable: "LibararyBranches",
                principalColumn: "BranchID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
