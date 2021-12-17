using Microsoft.EntityFrameworkCore.Migrations;

namespace Eterna.Migrations
{
    public partial class CategoryIdAddedIntoPostfolios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Portfolios",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Portfolios_CategoryId",
                table: "Portfolios",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Portfolios_Categories_CategoryId",
                table: "Portfolios",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Portfolios_Categories_CategoryId",
                table: "Portfolios");

            migrationBuilder.DropIndex(
                name: "IX_Portfolios_CategoryId",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Portfolios");
        }
    }
}
