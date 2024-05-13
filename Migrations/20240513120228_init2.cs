using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_BorrowingRecords_BookId",
                table: "BorrowingRecords",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowingRecords_PatronId",
                table: "BorrowingRecords",
                column: "PatronId");

            migrationBuilder.AddForeignKey(
                name: "FK_BorrowingRecords_Books_BookId",
                table: "BorrowingRecords",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BorrowingRecords_Patrons_PatronId",
                table: "BorrowingRecords",
                column: "PatronId",
                principalTable: "Patrons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BorrowingRecords_Books_BookId",
                table: "BorrowingRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_BorrowingRecords_Patrons_PatronId",
                table: "BorrowingRecords");

            migrationBuilder.DropIndex(
                name: "IX_BorrowingRecords_BookId",
                table: "BorrowingRecords");

            migrationBuilder.DropIndex(
                name: "IX_BorrowingRecords_PatronId",
                table: "BorrowingRecords");
        }
    }
}
