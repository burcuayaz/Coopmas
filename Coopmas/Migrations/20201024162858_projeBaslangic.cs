using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Coopmas.Migrations
{
    public partial class projeBaslangic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "admins",
                columns: table => new
                {
                    AdminID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kullanici = table.Column<string>(type: "Varchar(20)", nullable: true),
                    Sifre = table.Column<string>(type: "Varchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admins", x => x.AdminID);
                });

            migrationBuilder.CreateTable(
                name: "hizmetlers",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HizmetAdi = table.Column<string>(nullable: true),
                    Ozellik = table.Column<string>(nullable: true),
                    Fiyat = table.Column<int>(nullable: false),
                    Dokumantasyon = table.Column<string>(nullable: true),
                    Satisİletisim = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hizmetlers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "İletisims",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    adsoyad = table.Column<string>(nullable: true),
                    eposta = table.Column<string>(nullable: true),
                    konu = table.Column<string>(nullable: true),
                    mesaj = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_İletisims", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "taleps",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    soru1 = table.Column<string>(nullable: true),
                    soru2 = table.Column<DateTime>(nullable: false),
                    soru3 = table.Column<string>(nullable: true),
                    soru4 = table.Column<int>(nullable: false),
                    email = table.Column<string>(nullable: true),
                    telephone = table.Column<int>(nullable: false),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_taleps", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "urunlers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AD = table.Column<string>(nullable: true),
                    Ozellik = table.Column<string>(nullable: true),
                    Fiyat = table.Column<int>(nullable: false),
                    Dokumantasyon = table.Column<string>(nullable: true),
                    Satisİletisim = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_urunlers", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admins");

            migrationBuilder.DropTable(
                name: "hizmetlers");

            migrationBuilder.DropTable(
                name: "İletisims");

            migrationBuilder.DropTable(
                name: "taleps");

            migrationBuilder.DropTable(
                name: "urunlers");
        }
    }
}
