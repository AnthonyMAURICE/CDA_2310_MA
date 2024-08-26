using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestAPI.Migrations
{
    /// <inheritdoc />
    public partial class updatedDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContinentId",
                table: "Countries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Countries_ContinentId",
                table: "Countries",
                column: "ContinentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_continent_ContinentId",
                table: "Countries",
                column: "ContinentId",
                principalTable: "continent",
                principalColumn: "continent_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_continent_ContinentId",
                table: "Countries");

            migrationBuilder.DropIndex(
                name: "IX_Countries_ContinentId",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "ContinentId",
                table: "Countries");
        }
    }
}
