using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCOREWPF.Migrations
{
    public partial class BookCategoryRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CatergoryId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Books_CatergoryId",
                table: "Books",
                column: "CatergoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Categories_CatergoryId",
                table: "Books",
                column: "CatergoryId",
                principalTable: "Categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Categories_CatergoryId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_CatergoryId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "CatergoryId",
                table: "Books");
        }
    }
}
