using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATOM.Repository.Migrations
{
    /// <inheritdoc />
    public partial class initial3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HelpPopulation_Categories_CategoryId",
                table: "HelpPopulation");

            migrationBuilder.DropForeignKey(
                name: "FK_HelpPopulation_Districts_DistrictId",
                table: "HelpPopulation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HelpPopulation",
                table: "HelpPopulation");

            migrationBuilder.DropColumn(
                name: "IsAccessible",
                table: "HelpDemands");

            migrationBuilder.RenameTable(
                name: "HelpPopulation",
                newName: "HelpPopulations");

            migrationBuilder.RenameIndex(
                name: "IX_HelpPopulation_DistrictId",
                table: "HelpPopulations",
                newName: "IX_HelpPopulations_DistrictId");

            migrationBuilder.RenameIndex(
                name: "IX_HelpPopulation_CategoryId",
                table: "HelpPopulations",
                newName: "IX_HelpPopulations_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HelpPopulations",
                table: "HelpPopulations",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HelpPopulations_Categories_CategoryId",
                table: "HelpPopulations",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HelpPopulations_Districts_DistrictId",
                table: "HelpPopulations",
                column: "DistrictId",
                principalTable: "Districts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HelpPopulations_Categories_CategoryId",
                table: "HelpPopulations");

            migrationBuilder.DropForeignKey(
                name: "FK_HelpPopulations_Districts_DistrictId",
                table: "HelpPopulations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HelpPopulations",
                table: "HelpPopulations");

            migrationBuilder.RenameTable(
                name: "HelpPopulations",
                newName: "HelpPopulation");

            migrationBuilder.RenameIndex(
                name: "IX_HelpPopulations_DistrictId",
                table: "HelpPopulation",
                newName: "IX_HelpPopulation_DistrictId");

            migrationBuilder.RenameIndex(
                name: "IX_HelpPopulations_CategoryId",
                table: "HelpPopulation",
                newName: "IX_HelpPopulation_CategoryId");

            migrationBuilder.AddColumn<bool>(
                name: "IsAccessible",
                table: "HelpDemands",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_HelpPopulation",
                table: "HelpPopulation",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HelpPopulation_Categories_CategoryId",
                table: "HelpPopulation",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HelpPopulation_Districts_DistrictId",
                table: "HelpPopulation",
                column: "DistrictId",
                principalTable: "Districts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
