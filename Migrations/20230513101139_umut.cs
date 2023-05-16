using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web_programlama.Migrations
{
    /// <inheritdoc />
    public partial class umut : Migration
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
                    a_sifre = table.Column<int>(type: "int", nullable: false),
                    a_isim = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    isim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soyisim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cinsiyet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    aile_no = table.Column<int>(type: "int", nullable: false),
                    istek_no = table.Column<int>(type: "int", nullable: false)
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
                    g_isim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    g_soyisim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    g_meslegi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    yasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    y_mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefon = table.Column<int>(type: "int", nullable: false),
                    y_sifre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gonullus", x => x.g_id);
                });

            migrationBuilder.CreateTable(
                name: "Haberlers",
                columns: table => new
                {
                    h_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    son_haberler = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gida_dagitim_noktalari = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    saglik_merkezleri = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Haberlers", x => x.h_id);
                });

            migrationBuilder.CreateTable(
                name: "ihtiyaclars",
                columns: table => new
                {
                    i_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    i_adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    i_miktari = table.Column<int>(type: "int", nullable: false),
                    bagis_miktari = table.Column<int>(type: "int", nullable: false),
                    istek_adresi = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    k_tc = table.Column<int>(type: "int", nullable: false),
                    k_yetki_turu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    k_sifre = table.Column<int>(type: "int", nullable: false)
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
                name: "Yetkilis",
                columns: table => new
                {
                    y_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    y_tc = table.Column<int>(type: "int", nullable: false),
                    y_isim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    y_soyadi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    y_d_tarihi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    y_mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    y_sifre = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                name: "Haberlers");

            migrationBuilder.DropTable(
                name: "ihtiyaclars");

            migrationBuilder.DropTable(
                name: "Kullanicis");

            migrationBuilder.DropTable(
                name: "Toplanma_Alanis");

            migrationBuilder.DropTable(
                name: "Yetkilis");
        }
    }
}
