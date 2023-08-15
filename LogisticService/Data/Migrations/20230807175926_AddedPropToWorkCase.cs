using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LogisticService.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedPropToWorkCase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Location",
                table: "WorkCases",
                newName: "Origin");

            migrationBuilder.AddColumn<string>(
                name: "Destination",
                table: "WorkCases",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TravelMode",
                table: "WorkCases",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Destination",
                table: "WorkCases");

            migrationBuilder.DropColumn(
                name: "TravelMode",
                table: "WorkCases");

            migrationBuilder.RenameColumn(
                name: "Origin",
                table: "WorkCases",
                newName: "Location");
        }
    }
}
