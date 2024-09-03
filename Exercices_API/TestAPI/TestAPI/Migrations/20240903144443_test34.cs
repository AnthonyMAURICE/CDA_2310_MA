using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestAPI.Migrations
{
    /// <inheritdoc />
    public partial class test34 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "DepartureCityId",
                table: "Trip",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ArrivalCityId",
                table: "Trip",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Trip_ArrivalCityId",
                table: "Trip",
                column: "ArrivalCityId");

            migrationBuilder.CreateIndex(
                name: "IX_Trip_DepartureCityId",
                table: "Trip",
                column: "DepartureCityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Trip_Cities_ArrivalCityId",
                table: "Trip",
                column: "ArrivalCityId",
                principalTable: "Cities",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Trip_Cities_DepartureCityId",
                table: "Trip",
                column: "DepartureCityId",
                principalTable: "Cities",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trip_Cities_ArrivalCityId",
                table: "Trip");

            migrationBuilder.DropForeignKey(
                name: "FK_Trip_Cities_DepartureCityId",
                table: "Trip");

            migrationBuilder.DropIndex(
                name: "IX_Trip_ArrivalCityId",
                table: "Trip");

            migrationBuilder.DropIndex(
                name: "IX_Trip_DepartureCityId",
                table: "Trip");

            migrationBuilder.AlterColumn<int>(
                name: "DepartureCityId",
                table: "Trip",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ArrivalCityId",
                table: "Trip",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
