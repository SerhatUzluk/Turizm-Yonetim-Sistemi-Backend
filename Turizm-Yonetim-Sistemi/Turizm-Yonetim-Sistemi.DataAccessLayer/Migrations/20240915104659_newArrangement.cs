using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Turizm_Yonetim_Sistemi.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class newArrangement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bilets_Musteris_MusteriID",
                table: "Bilets");

            migrationBuilder.DropForeignKey(
                name: "FK_Bilets_Sefers_SeferID",
                table: "Bilets");

            migrationBuilder.DropForeignKey(
                name: "FK_Kampanyas_Firmas_FirmaID",
                table: "Kampanyas");

            migrationBuilder.DropForeignKey(
                name: "FK_Sefers_RotaBilgisis_RotaBilgisiID",
                table: "Sefers");

            migrationBuilder.DropForeignKey(
                name: "FK_Sefers_Tasits_TasitID",
                table: "Sefers");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasits_Firmas_FirmaID",
                table: "Tasits");

            migrationBuilder.DropForeignKey(
                name: "FK_Vardiyas_Personels_PersonelID",
                table: "Vardiyas");

            migrationBuilder.DropTable(
                name: "Gorevlis");

            migrationBuilder.DropIndex(
                name: "IX_Sefers_RotaBilgisiID",
                table: "Sefers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vardiyas",
                table: "Vardiyas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Terminals",
                table: "Terminals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tasits",
                table: "Tasits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Personels",
                table: "Personels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Musteris",
                table: "Musteris");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kampanyas",
                table: "Kampanyas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bilets",
                table: "Bilets");

            migrationBuilder.DropColumn(
                name: "RotaBilgisiID",
                table: "Sefers");

            migrationBuilder.DropColumn(
                name: "MailAdres",
                table: "Musteris");

            migrationBuilder.DropColumn(
                name: "Sifre",
                table: "Musteris");

            migrationBuilder.DropColumn(
                name: "TelefonNumarasi",
                table: "Musteris");

            migrationBuilder.RenameTable(
                name: "Vardiyas",
                newName: "Vardiyalar");

            migrationBuilder.RenameTable(
                name: "Terminals",
                newName: "Terminaller");

            migrationBuilder.RenameTable(
                name: "Tasits",
                newName: "Tasitlar");

            migrationBuilder.RenameTable(
                name: "Personels",
                newName: "Personeller");

            migrationBuilder.RenameTable(
                name: "Musteris",
                newName: "Musteri");

            migrationBuilder.RenameTable(
                name: "Kampanyas",
                newName: "Kampanyalar");

            migrationBuilder.RenameTable(
                name: "Bilets",
                newName: "Biletler");

            migrationBuilder.RenameIndex(
                name: "IX_Vardiyas_PersonelID",
                table: "Vardiyalar",
                newName: "IX_Vardiyalar_PersonelID");

            migrationBuilder.RenameIndex(
                name: "IX_Tasits_FirmaID",
                table: "Tasitlar",
                newName: "IX_Tasitlar_FirmaID");

            migrationBuilder.RenameColumn(
                name: "RoleID",
                table: "Musteri",
                newName: "AccessFailedCount");

            migrationBuilder.RenameIndex(
                name: "IX_Kampanyas_FirmaID",
                table: "Kampanyalar",
                newName: "IX_Kampanyalar_FirmaID");

            migrationBuilder.RenameIndex(
                name: "IX_Bilets_SeferID",
                table: "Biletler",
                newName: "IX_Biletler_SeferID");

            migrationBuilder.RenameIndex(
                name: "IX_Bilets_MusteriID",
                table: "Biletler",
                newName: "IX_Biletler_MusteriID");

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Musteri",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Musteri",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Musteri",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "Musteri",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Musteri",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Musteri",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Musteri",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Musteri",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Musteri",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Musteri",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Musteri",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Musteri",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Musteri",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Musteri",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vardiyalar",
                table: "Vardiyalar",
                column: "VardiyaID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Terminaller",
                table: "Terminaller",
                column: "TerminalID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tasitlar",
                table: "Tasitlar",
                column: "TasitID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Personeller",
                table: "Personeller",
                column: "PersonelID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Musteri",
                table: "Musteri",
                column: "KullaniciID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kampanyalar",
                table: "Kampanyalar",
                column: "KampanyaID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Biletler",
                table: "Biletler",
                column: "BiletID");

            migrationBuilder.CreateIndex(
                name: "IX_Sefers_RotaID",
                table: "Sefers",
                column: "RotaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Biletler_Musteri_MusteriID",
                table: "Biletler",
                column: "MusteriID",
                principalTable: "Musteri",
                principalColumn: "KullaniciID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Biletler_Sefers_SeferID",
                table: "Biletler",
                column: "SeferID",
                principalTable: "Sefers",
                principalColumn: "SeferID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kampanyalar_Firmas_FirmaID",
                table: "Kampanyalar",
                column: "FirmaID",
                principalTable: "Firmas",
                principalColumn: "FirmaID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sefers_RotaBilgisis_RotaID",
                table: "Sefers",
                column: "RotaID",
                principalTable: "RotaBilgisis",
                principalColumn: "RotaID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sefers_Tasitlar_TasitID",
                table: "Sefers",
                column: "TasitID",
                principalTable: "Tasitlar",
                principalColumn: "TasitID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasitlar_Firmas_FirmaID",
                table: "Tasitlar",
                column: "FirmaID",
                principalTable: "Firmas",
                principalColumn: "FirmaID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vardiyalar_Personeller_PersonelID",
                table: "Vardiyalar",
                column: "PersonelID",
                principalTable: "Personeller",
                principalColumn: "PersonelID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Biletler_Musteri_MusteriID",
                table: "Biletler");

            migrationBuilder.DropForeignKey(
                name: "FK_Biletler_Sefers_SeferID",
                table: "Biletler");

            migrationBuilder.DropForeignKey(
                name: "FK_Kampanyalar_Firmas_FirmaID",
                table: "Kampanyalar");

            migrationBuilder.DropForeignKey(
                name: "FK_Sefers_RotaBilgisis_RotaID",
                table: "Sefers");

            migrationBuilder.DropForeignKey(
                name: "FK_Sefers_Tasitlar_TasitID",
                table: "Sefers");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasitlar_Firmas_FirmaID",
                table: "Tasitlar");

            migrationBuilder.DropForeignKey(
                name: "FK_Vardiyalar_Personeller_PersonelID",
                table: "Vardiyalar");

            migrationBuilder.DropIndex(
                name: "IX_Sefers_RotaID",
                table: "Sefers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vardiyalar",
                table: "Vardiyalar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Terminaller",
                table: "Terminaller");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tasitlar",
                table: "Tasitlar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Personeller",
                table: "Personeller");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Musteri",
                table: "Musteri");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kampanyalar",
                table: "Kampanyalar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Biletler",
                table: "Biletler");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Musteri");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Musteri");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Musteri");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Musteri");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Musteri");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Musteri");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Musteri");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Musteri");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Musteri");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Musteri");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Musteri");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Musteri");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Musteri");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Musteri");

            migrationBuilder.RenameTable(
                name: "Vardiyalar",
                newName: "Vardiyas");

            migrationBuilder.RenameTable(
                name: "Terminaller",
                newName: "Terminals");

            migrationBuilder.RenameTable(
                name: "Tasitlar",
                newName: "Tasits");

            migrationBuilder.RenameTable(
                name: "Personeller",
                newName: "Personels");

            migrationBuilder.RenameTable(
                name: "Musteri",
                newName: "Musteris");

            migrationBuilder.RenameTable(
                name: "Kampanyalar",
                newName: "Kampanyas");

            migrationBuilder.RenameTable(
                name: "Biletler",
                newName: "Bilets");

            migrationBuilder.RenameIndex(
                name: "IX_Vardiyalar_PersonelID",
                table: "Vardiyas",
                newName: "IX_Vardiyas_PersonelID");

            migrationBuilder.RenameIndex(
                name: "IX_Tasitlar_FirmaID",
                table: "Tasits",
                newName: "IX_Tasits_FirmaID");

            migrationBuilder.RenameColumn(
                name: "AccessFailedCount",
                table: "Musteris",
                newName: "RoleID");

            migrationBuilder.RenameIndex(
                name: "IX_Kampanyalar_FirmaID",
                table: "Kampanyas",
                newName: "IX_Kampanyas_FirmaID");

            migrationBuilder.RenameIndex(
                name: "IX_Biletler_SeferID",
                table: "Bilets",
                newName: "IX_Bilets_SeferID");

            migrationBuilder.RenameIndex(
                name: "IX_Biletler_MusteriID",
                table: "Bilets",
                newName: "IX_Bilets_MusteriID");

            migrationBuilder.AddColumn<int>(
                name: "RotaBilgisiID",
                table: "Sefers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MailAdres",
                table: "Musteris",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Sifre",
                table: "Musteris",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TelefonNumarasi",
                table: "Musteris",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vardiyas",
                table: "Vardiyas",
                column: "VardiyaID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Terminals",
                table: "Terminals",
                column: "TerminalID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tasits",
                table: "Tasits",
                column: "TasitID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Personels",
                table: "Personels",
                column: "PersonelID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Musteris",
                table: "Musteris",
                column: "KullaniciID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kampanyas",
                table: "Kampanyas",
                column: "KampanyaID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bilets",
                table: "Bilets",
                column: "BiletID");

            migrationBuilder.CreateTable(
                name: "Gorevlis",
                columns: table => new
                {
                    KullaniciID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirmaID = table.Column<int>(type: "int", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MailAdres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleID = table.Column<int>(type: "int", nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelefonNumarasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
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

            migrationBuilder.CreateIndex(
                name: "IX_Sefers_RotaBilgisiID",
                table: "Sefers",
                column: "RotaBilgisiID");

            migrationBuilder.CreateIndex(
                name: "IX_Gorevlis_FirmaID",
                table: "Gorevlis",
                column: "FirmaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Bilets_Musteris_MusteriID",
                table: "Bilets",
                column: "MusteriID",
                principalTable: "Musteris",
                principalColumn: "KullaniciID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bilets_Sefers_SeferID",
                table: "Bilets",
                column: "SeferID",
                principalTable: "Sefers",
                principalColumn: "SeferID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kampanyas_Firmas_FirmaID",
                table: "Kampanyas",
                column: "FirmaID",
                principalTable: "Firmas",
                principalColumn: "FirmaID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sefers_RotaBilgisis_RotaBilgisiID",
                table: "Sefers",
                column: "RotaBilgisiID",
                principalTable: "RotaBilgisis",
                principalColumn: "RotaID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sefers_Tasits_TasitID",
                table: "Sefers",
                column: "TasitID",
                principalTable: "Tasits",
                principalColumn: "TasitID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasits_Firmas_FirmaID",
                table: "Tasits",
                column: "FirmaID",
                principalTable: "Firmas",
                principalColumn: "FirmaID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vardiyas_Personels_PersonelID",
                table: "Vardiyas",
                column: "PersonelID",
                principalTable: "Personels",
                principalColumn: "PersonelID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
