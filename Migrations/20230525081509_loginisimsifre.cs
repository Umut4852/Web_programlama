using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web_programlama.Migrations
{
    /// <inheritdoc />
    public partial class loginisimsifre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "y_isim",
                table: "Yetkilis");

            migrationBuilder.DropColumn(
                name: "y_sifre",
                table: "Yetkilis");

            migrationBuilder.DropColumn(
                name: "k_sifre",
                table: "Kullanicis");

            migrationBuilder.RenameColumn(
                name: "k_adi",
                table: "Kullanicis",
                newName: "isim");

            migrationBuilder.RenameColumn(
                name: "a_sifre",
                table: "Admins",
                newName: "sifre");

            migrationBuilder.RenameColumn(
                name: "a_isim",
                table: "Admins",
                newName: "isim");

            migrationBuilder.AlterColumn<string>(
                name: "y_soyadi",
                table: "Yetkilis",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "y_mail",
                table: "Yetkilis",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "y_d_tarihi",
                table: "Yetkilis",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "isim",
                table: "Yetkilis",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "sifre",
                table: "Yetkilis",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "sifre",
                table: "Kullanicis",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "sifre",
                table: "Gonullus",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "soyisim",
                table: "Depremzedes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "isim",
                table: "Depremzedes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "cinsiyet",
                table: "Depremzedes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "adres",
                table: "Depremzedes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "sifre",
                table: "Depremzedes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isim",
                table: "Yetkilis");

            migrationBuilder.DropColumn(
                name: "sifre",
                table: "Yetkilis");

            migrationBuilder.DropColumn(
                name: "sifre",
                table: "Kullanicis");

            migrationBuilder.DropColumn(
                name: "sifre",
                table: "Depremzedes");

            migrationBuilder.RenameColumn(
                name: "isim",
                table: "Kullanicis",
                newName: "k_adi");

            migrationBuilder.RenameColumn(
                name: "sifre",
                table: "Admins",
                newName: "a_sifre");

            migrationBuilder.RenameColumn(
                name: "isim",
                table: "Admins",
                newName: "a_isim");

            migrationBuilder.AlterColumn<string>(
                name: "y_soyadi",
                table: "Yetkilis",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "y_mail",
                table: "Yetkilis",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "y_d_tarihi",
                table: "Yetkilis",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "y_isim",
                table: "Yetkilis",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "y_sifre",
                table: "Yetkilis",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "k_sifre",
                table: "Kullanicis",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "sifre",
                table: "Gonullus",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "soyisim",
                table: "Depremzedes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "isim",
                table: "Depremzedes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cinsiyet",
                table: "Depremzedes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "adres",
                table: "Depremzedes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
