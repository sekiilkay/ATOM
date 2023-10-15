using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATOM.Repository.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProjectName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CenterTypeId",
                table: "HelpCenters",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CenterTypeId",
                table: "GatheringCenters",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CenterTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CenterTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HelpCenters_CenterTypeId",
                table: "HelpCenters",
                column: "CenterTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_GatheringCenters_CenterTypeId",
                table: "GatheringCenters",
                column: "CenterTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_GatheringCenters_CenterTypes_CenterTypeId",
                table: "GatheringCenters",
                column: "CenterTypeId",
                principalTable: "CenterTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HelpCenters_CenterTypes_CenterTypeId",
                table: "HelpCenters",
                column: "CenterTypeId",
                principalTable: "CenterTypes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GatheringCenters_CenterTypes_CenterTypeId",
                table: "GatheringCenters");

            migrationBuilder.DropForeignKey(
                name: "FK_HelpCenters_CenterTypes_CenterTypeId",
                table: "HelpCenters");

            migrationBuilder.DropTable(
                name: "CenterTypes");

            migrationBuilder.DropIndex(
                name: "IX_HelpCenters_CenterTypeId",
                table: "HelpCenters");

            migrationBuilder.DropIndex(
                name: "IX_GatheringCenters_CenterTypeId",
                table: "GatheringCenters");

            migrationBuilder.DropColumn(
                name: "CenterTypeId",
                table: "HelpCenters");

            migrationBuilder.DropColumn(
                name: "CenterTypeId",
                table: "GatheringCenters");
        }
    }
}
