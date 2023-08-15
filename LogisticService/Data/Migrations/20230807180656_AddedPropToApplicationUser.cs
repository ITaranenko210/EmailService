using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LogisticService.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedPropToApplicationUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TravelMode",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TravelMode",
                table: "AspNetUsers");
        }
    }
}
