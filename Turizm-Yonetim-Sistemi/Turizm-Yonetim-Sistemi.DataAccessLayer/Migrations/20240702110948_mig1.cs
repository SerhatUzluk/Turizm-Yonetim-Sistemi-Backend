using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Turizm_Yonetim_Sistemi.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Firmas",
                columns: table => new
                {
                    FirmaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MailAdres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelefonNumarasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirmaAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firmas", x => x.FirmaID);
                });

            migrationBuilder.CreateTable(
                name: "Musteris",
                columns: table => new
                {
                    KullaniciID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MailAdres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleID = table.Column<int>(type: "int", nullable: false),
                    TelefonNumarasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cinsiyet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KimlikNo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musteris", x => x.KullaniciID);
                });

            migrationBuilder.CreateTable(
                name: "Personels",
                columns: table => new
                {
                    PersonelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Puan = table.Column<int>(type: "int", nullable: false),
                    Maas = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Yas = table.Column<int>(type: "int", nullable: false),
                    PersonelTipi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personels", x => x.PersonelID);
                });

            migrationBuilder.CreateTable(
                name: "RotaBilgisis",
                columns: table => new
                {
                    RotaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KalkisYeri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VarisYeri = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RotaBilgisis", x => x.RotaID);
                });

            migrationBuilder.CreateTable(
                name: "Terminals",
                columns: table => new
                {
                    TerminalID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sehir = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Long = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TerminalAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terminals", x => x.TerminalID);
                });

            migrationBuilder.CreateTable(
                name: "Gorevlis",
                columns: table => new
                {
                    KullaniciID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MailAdres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleID = table.Column<int>(type: "int", nullable: false),
                    TelefonNumarasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirmaID = table.Column<int>(type: "int", nullable: false),
                    Unvan = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gorevlis", x => x.KullaniciID);
                    table.ForeignKey(
                        name: "FK_Gorevlis_Firmas_FirmaID",
                        column: x => x.FirmaID,
                        principalTable: "Firmas",
                        principalColumn: "FirmaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kampanyas",
                columns: table => new
                {
                    KampanyaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirmaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kampanyas", x => x.KampanyaID);
                    table.ForeignKey(
                        name: "FK_Kampanyas_Firmas_FirmaID",
                        column: x => x.FirmaID,
                        principalTable: "Firmas",
                        principalColumn: "FirmaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tasits",
                columns: table => new
                {
                    TasitID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kapasite = table.Column<int>(type: "int", nullable: false),
                    Plaka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KullanimDurumu = table.Column<bool>(type: "bit", nullable: false),
                    FirmaID = table.Column<int>(type: "int", nullable: false),
                    TasitTuru = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasits", x => x.TasitID);
                    table.ForeignKey(
                        name: "FK_Tasits_Firmas_FirmaID",
                        column: x => x.FirmaID,
                        principalTable: "Firmas",
                        principalColumn: "FirmaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vardiyas",
                columns: table => new
                {
                    VardiyaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PztBaslangic = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PztBitis = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SaliBaslangic = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SaliBitis = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CrsBaslangic = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CrsBitis = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PrsBaslangic = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PrsBitis = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CumBaslangic = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CumBitis = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CmtBaslangic = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CmtBitis = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PzrBaslangic = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PzrBitis = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VardiyaBaslangicTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VardiyaBitisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PersonelID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vardiyas", x => x.VardiyaID);
                    table.ForeignKey(
                        name: "FK_Vardiyas_Personels_PersonelID",
                        column: x => x.PersonelID,
                        principalTable: "Personels",
                        principalColumn: "PersonelID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sefers",
                columns: table => new
                {
                    SeferID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TasitID = table.Column<int>(type: "int", nullable: false),
                    KalkisZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VarisZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirmaID = table.Column<int>(type: "int", nullable: false),
                    BiletSatisFiyati = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RotaID = table.Column<int>(type: "int", nullable: false),
                    RotaBilgisiID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sefers", x => x.SeferID);
                    table.ForeignKey(
                        name: "FK_Sefers_RotaBilgisis_RotaBilgisiID",
                        column: x => x.RotaBilgisiID,
                        principalTable: "RotaBilgisis",
                        principalColumn: "RotaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sefers_Tasits_TasitID",
                        column: x => x.TasitID,
                        principalTable: "Tasits",
                        principalColumn: "TasitID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bilets",
                columns: table => new
                {
                    BiletID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriID = table.Column<int>(type: "int", nullable: false),
                    KoltukNo = table.Column<int>(type: "int", nullable: false),
                    SeferID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bilets", x => x.BiletID);
                    table.ForeignKey(
                        name: "FK_Bilets_Musteris_MusteriID",
                        column: x => x.MusteriID,
                        principalTable: "Musteris",
                        principalColumn: "KullaniciID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bilets_Sefers_SeferID",
                        column: x => x.SeferID,
                        principalTable: "Sefers",
                        principalColumn: "SeferID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bilets_MusteriID",
                table: "Bilets",
                column: "MusteriID");

            migrationBuilder.CreateIndex(
                name: "IX_Bilets_SeferID",
                table: "Bilets",
                column: "SeferID");

            migrationBuilder.CreateIndex(
                name: "IX_Gorevlis_FirmaID",
                table: "Gorevlis",
                column: "FirmaID");

            migrationBuilder.CreateIndex(
                name: "IX_Kampanyas_FirmaID",
                table: "Kampanyas",
                column: "FirmaID");

            migrationBuilder.CreateIndex(
                name: "IX_Sefers_RotaBilgisiID",
                table: "Sefers",
                column: "RotaBilgisiID");

            migrationBuilder.CreateIndex(
                name: "IX_Sefers_TasitID",
                table: "Sefers",
                column: "TasitID");

            migrationBuilder.CreateIndex(
                name: "IX_Tasits_FirmaID",
                table: "Tasits",
                column: "FirmaID");

            migrationBuilder.CreateIndex(
                name: "IX_Vardiyas_PersonelID",
                table: "Vardiyas",
                column: "PersonelID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bilets");

            migrationBuilder.DropTable(
                name: "Gorevlis");

            migrationBuilder.DropTable(
                name: "Kampanyas");

            migrationBuilder.DropTable(
                name: "Terminals");

            migrationBuilder.DropTable(
                name: "Vardiyas");

            migrationBuilder.DropTable(
                name: "Musteris");

            migrationBuilder.DropTable(
                name: "Sefers");

            migrationBuilder.DropTable(
                name: "Personels");

            migrationBuilder.DropTable(
                name: "RotaBilgisis");

            migrationBuilder.DropTable(
                name: "Tasits");

            migrationBuilder.DropTable(
                name: "Firmas");
        }
    }
}
