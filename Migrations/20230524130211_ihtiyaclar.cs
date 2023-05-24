using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web_programlama.Migrations
{
    /// <inheritdoc />
    public partial class ihtiyaclar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsNeed",
                table: "ihtiyaclars");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsNeed",
                table: "ihtiyaclars",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
