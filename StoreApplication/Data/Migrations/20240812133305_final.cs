using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreApplication.Data.Migrations
{
    /// <inheritdoc />
    public partial class final : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageFileName",
                table: "Product");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageFileName",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
