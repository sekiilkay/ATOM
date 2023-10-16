using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATOM.Repository.Migrations
{
    /// <inheritdoc />
    public partial class Create : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsClaimed",
                table: "WreckPopulations",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Latitude",
                table: "AspNetUsers",
                type: "decimal(8,6)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Longitude",
                table: "AspNetUsers",
                type: "decimal(8,6)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsClaimed",
                table: "WreckPopulations");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "AspNetUsers");
        }
    }
}
