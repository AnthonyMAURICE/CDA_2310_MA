using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestAPI.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "continent",
                columns: table => new
                {
                    continent_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    continent_name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    continent_area = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_continent", x => x.continent_id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    country_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    country_name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    country_area = table.Column<int>(type: "int", nullable: false),
                    country_code = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.country_id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Countries_country_code",
                table: "Countries",
                column: "country_code",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "continent");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
