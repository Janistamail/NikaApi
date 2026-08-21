using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nika.Migrations
{
    /// <inheritdoc />
    public partial class PreordateDays : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPreOrder",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "PreOrderDays",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PreOrderDays",
                table: "Products");

            migrationBuilder.AddColumn<bool>(
                name: "IsPreOrder",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
