using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCOREWPF.Migrations
{
    public partial class fluentApi1NRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Categories_CatergoryId",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "CatergoryId",
                table: "Books",
                newName: "CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Books_CatergoryId",
                table: "Books",
                newName: "IX_Books_CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Categories_CategoryID",
                table: "Books",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Categories_CategoryID",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Books",
                newName: "CatergoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Books_CategoryID",
                table: "Books",
                newName: "IX_Books_CatergoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Categories_CatergoryId",
                table: "Books",
                column: "CatergoryId",
                principalTable: "Categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
