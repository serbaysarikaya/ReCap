using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class reverts_tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rentals_Rentals_RentalId",
                table: "Rentals");

            migrationBuilder.DropIndex(
                name: "IX_Rentals_RentalId",
                table: "Rentals");

            migrationBuilder.DropColumn(
                name: "RentalId",
                table: "Rentals");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RentalId",
                table: "Rentals",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_RentalId",
                table: "Rentals",
                column: "RentalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rentals_Rentals_RentalId",
                table: "Rentals",
                column: "RentalId",
                principalTable: "Rentals",
                principalColumn: "Id");
        }
    }
}
