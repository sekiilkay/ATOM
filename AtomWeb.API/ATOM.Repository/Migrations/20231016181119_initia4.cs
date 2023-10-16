using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATOM.Repository.Migrations
{
    /// <inheritdoc />
    public partial class initia4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GatheringCenterId",
                table: "HelpPopulations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HelpCenterId",
                table: "HelpPopulations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_HelpPopulations_GatheringCenterId",
                table: "HelpPopulations",
                column: "GatheringCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_HelpPopulations_HelpCenterId",
                table: "HelpPopulations",
                column: "HelpCenterId");

            migrationBuilder.AddForeignKey(
                name: "FK_HelpPopulations_GatheringCenters_GatheringCenterId",
                table: "HelpPopulations",
                column: "GatheringCenterId",
                principalTable: "GatheringCenters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HelpPopulations_HelpCenters_HelpCenterId",
                table: "HelpPopulations",
                column: "HelpCenterId",
                principalTable: "HelpCenters",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HelpPopulations_GatheringCenters_GatheringCenterId",
                table: "HelpPopulations");

            migrationBuilder.DropForeignKey(
                name: "FK_HelpPopulations_HelpCenters_HelpCenterId",
                table: "HelpPopulations");

            migrationBuilder.DropIndex(
                name: "IX_HelpPopulations_GatheringCenterId",
                table: "HelpPopulations");

            migrationBuilder.DropIndex(
                name: "IX_HelpPopulations_HelpCenterId",
                table: "HelpPopulations");

            migrationBuilder.DropColumn(
                name: "GatheringCenterId",
                table: "HelpPopulations");

            migrationBuilder.DropColumn(
                name: "HelpCenterId",
                table: "HelpPopulations");
        }
    }
}
