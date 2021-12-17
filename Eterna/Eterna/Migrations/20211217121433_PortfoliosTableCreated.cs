using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Eterna.Migrations
{
    public partial class PortfoliosTableCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Portfolios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartTitle = table.Column<string>(maxLength: 20, nullable: true),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    Desc = table.Column<string>(maxLength: 500, nullable: true),
                    ProjectUrl = table.Column<string>(maxLength: 250, nullable: true),
                    Client = table.Column<string>(maxLength: 50, nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portfolios", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Portfolios");
        }
    }
}
