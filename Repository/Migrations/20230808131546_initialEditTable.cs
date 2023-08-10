using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagementSystem.Repository.Migrations
{
    /// <inheritdoc />
    public partial class initialEditTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BorrowedBook_Books_BookId",
                table: "BorrowedBook");

            migrationBuilder.DropForeignKey(
                name: "FK_BorrowedBook_Users_UserId",
                table: "BorrowedBook");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BorrowedBook",
                table: "BorrowedBook");

            migrationBuilder.RenameTable(
                name: "BorrowedBook",
                newName: "BorrowedBooks");

            migrationBuilder.RenameIndex(
                name: "IX_BorrowedBook_UserId",
                table: "BorrowedBooks",
                newName: "IX_BorrowedBooks_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_BorrowedBook_BookId",
                table: "BorrowedBooks",
                newName: "IX_BorrowedBooks_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BorrowedBooks",
                table: "BorrowedBooks",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BorrowedBooks_Books_BookId",
                table: "BorrowedBooks",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BorrowedBooks_Users_UserId",
                table: "BorrowedBooks",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BorrowedBooks_Books_BookId",
                table: "BorrowedBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_BorrowedBooks_Users_UserId",
                table: "BorrowedBooks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BorrowedBooks",
                table: "BorrowedBooks");

            migrationBuilder.RenameTable(
                name: "BorrowedBooks",
                newName: "BorrowedBook");

            migrationBuilder.RenameIndex(
                name: "IX_BorrowedBooks_UserId",
                table: "BorrowedBook",
                newName: "IX_BorrowedBook_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_BorrowedBooks_BookId",
                table: "BorrowedBook",
                newName: "IX_BorrowedBook_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BorrowedBook",
                table: "BorrowedBook",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BorrowedBook_Books_BookId",
                table: "BorrowedBook",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BorrowedBook_Users_UserId",
                table: "BorrowedBook",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
