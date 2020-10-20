using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCurrencyApp.Migrations
{
    public partial class updatemodels5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Currency",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    numCode = table.Column<int>(nullable: false),
                    fullName = table.Column<string>(nullable: true),
                    title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currency", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Rate",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dataRate = table.Column<DateTime>(nullable: false),
                    value = table.Column<decimal>(nullable: false),
                    nominal = table.Column<int>(nullable: false),
                    Currencyid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rate", x => x.id);
                    table.ForeignKey(
                        name: "FK_Rate_Currency_Currencyid",
                        column: x => x.Currencyid,
                        principalTable: "Currency",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rate_Currencyid",
                table: "Rate",
                column: "Currencyid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rate");

            migrationBuilder.DropTable(
                name: "Currency");
        }
    }
}
