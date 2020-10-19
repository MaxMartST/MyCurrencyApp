using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCurrencyApp.Migrations
{
    public partial class UpdatedCurrencyModel : Migration
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
                    title = table.Column<string>(nullable: true),
                    value = table.Column<decimal>(nullable: false),
                    nominal = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currency", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Currency");
        }
    }
}
