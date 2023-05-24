using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web_programlama.Migrations
{
    /// <inheritdoc />
    public partial class gonulluduzen : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "g_isim",
                table: "Gonullus");

            migrationBuilder.DropColumn(
                name: "g_meslegi",
                table: "Gonullus");

            migrationBuilder.DropColumn(
                name: "g_soyisim",
                table: "Gonullus");

            migrationBuilder.DropColumn(
                name: "y_mail",
                table: "Gonullus");

            migrationBuilder.DropColumn(
                name: "y_sifre",
                table: "Gonullus");

            migrationBuilder.AlterColumn<string>(
                name: "yasi",
                table: "Gonullus",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "isim",
                table: "Gonullus",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mail",
                table: "Gonullus",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "meslegi",
                table: "Gonullus",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "sifre",
                table: "Gonullus",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "soyisim",
                table: "Gonullus",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isim",
                table: "Gonullus");

            migrationBuilder.DropColumn(
                name: "mail",
                table: "Gonullus");

            migrationBuilder.DropColumn(
                name: "meslegi",
                table: "Gonullus");

            migrationBuilder.DropColumn(
                name: "sifre",
                table: "Gonullus");

            migrationBuilder.DropColumn(
                name: "soyisim",
                table: "Gonullus");

            migrationBuilder.AlterColumn<string>(
                name: "yasi",
                table: "Gonullus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "g_isim",
                table: "Gonullus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "g_meslegi",
                table: "Gonullus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "g_soyisim",
                table: "Gonullus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "y_mail",
                table: "Gonullus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "y_sifre",
                table: "Gonullus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
