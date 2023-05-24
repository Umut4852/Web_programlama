using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web_programlama.Migrations
{
    /// <inheritdoc />
    public partial class ihtiyacdelete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "bagis_miktari",
                table: "ihtiyaclars");

            migrationBuilder.AlterColumn<string>(
                name: "ozel_istek",
                table: "ihtiyaclars",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "istek_adresi",
                table: "ihtiyaclars",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "i_adi",
                table: "ihtiyaclars",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ozel_istek",
                table: "ihtiyaclars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "istek_adresi",
                table: "ihtiyaclars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "i_adi",
                table: "ihtiyaclars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "bagis_miktari",
                table: "ihtiyaclars",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
