using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web_programlama.Migrations
{
    /// <inheritdoc />
    public partial class OzeLIstekEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ozel_istek",
                table: "ihtiyaclars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ozel_istek",
                table: "ihtiyaclars");
        }
    }
}
