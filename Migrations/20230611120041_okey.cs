using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web_programlama.Migrations
{
    /// <inheritdoc />
    public partial class okey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    a_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    a_tc = table.Column<int>(type: "int", nullable: false),
                    sifre = table.Column<int>(type: "int", nullable: false),
                    isim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    a_soyisim = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.a_id);
                });

            migrationBuilder.CreateTable(
                name: "Depremzedes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tc_no = table.Column<int>(type: "int", nullable: false),
                    isim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    soyisim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cinsiyet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    adres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    aile_no = table.Column<int>(type: "int", nullable: false),
                    istek_no = table.Column<int>(type: "int", nullable: false),
                    sifre = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depremzedes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Gonullus",
                columns: table => new
                {
                    g_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    g_tc = table.Column<int>(type: "int", nullable: false),
                    isim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    soyisim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    meslegi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    yasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefon = table.Column<int>(type: "int", nullable: false),
                    sifre = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gonullus", x => x.g_id);
                });

            migrationBuilder.CreateTable(
                name: "Habers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icerik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ihtiyaclars",
                columns: table => new
                {
                    i_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    i_adi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    i_miktari = table.Column<int>(type: "int", nullable: false),
                    istek_adresi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ozel_istek = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ihtiyaclars", x => x.i_id);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicis",
                columns: table => new
                {
                    k_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    k_tc = table.Column<int>(type: "int", nullable: true),
                    k_yetki_turu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sifre = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicis", x => x.k_id);
                });

            migrationBuilder.CreateTable(
                name: "Toplanma_Alanis",
                columns: table => new
                {
                    a_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    a_kodu = table.Column<int>(type: "int", nullable: false),
                    a_adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    a_niteligi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    a_tcsi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Toplanma_Alanis", x => x.a_id);
                });

            migrationBuilder.CreateTable(
                name: "uruns",
                columns: table => new
                {
                    isim = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    adet = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_uruns", x => x.isim);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Yetkilis",
                columns: table => new
                {
                    y_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    y_tc = table.Column<int>(type: "int", nullable: false),
                    isim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    y_soyadi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    y_d_tarihi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    y_mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sifre = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yetkilis", x => x.y_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Depremzedes");

            migrationBuilder.DropTable(
                name: "Gonullus");

            migrationBuilder.DropTable(
                name: "Habers");

            migrationBuilder.DropTable(
                name: "ihtiyaclars");

            migrationBuilder.DropTable(
                name: "Kullanicis");

            migrationBuilder.DropTable(
                name: "Toplanma_Alanis");

            migrationBuilder.DropTable(
                name: "uruns");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "Yetkilis");
        }
    }
}
