using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Turizm_Yonetim_Sistemi.DataAccessLayer.Migrations.Application
{
    /// <inheritdoc />
    public partial class idGeneration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole<string>",
                keyColumn: "Id",
                keyValue: "29a5fec0-1452-401b-8072-84d83fcddbf6");

            migrationBuilder.DeleteData(
                table: "IdentityRole<string>",
                keyColumn: "Id",
                keyValue: "3ddee005-18f4-43de-96e6-356751ec8800");

            migrationBuilder.DeleteData(
                table: "IdentityRole<string>",
                keyColumn: "Id",
                keyValue: "a04b1ede-4704-4fb3-abfd-33abe4d917bf");

            migrationBuilder.DeleteData(
                table: "IdentityRole<string>",
                keyColumn: "Id",
                keyValue: "f3bbe272-02b8-44cc-ade8-9b9f82516748");

            migrationBuilder.InsertData(
                table: "IdentityRole<string>",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3bd7206f-604c-4eef-9f21-472d73b4a09c", null, "Planlama", "PLANLAMA" },
                    { "3ebe4b48-c02e-4f67-a9f7-9de622b6f8ac", null, "Kullanici", "KULLANICI" },
                    { "46e9d5e5-d9ab-4487-b029-776176b5b80f", null, "Yonetici", "YONETICI" },
                    { "ee9e77db-706a-4738-b3ca-68c1884b2fa2", null, "Satis", "SATIS" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole<string>",
                keyColumn: "Id",
                keyValue: "3bd7206f-604c-4eef-9f21-472d73b4a09c");

            migrationBuilder.DeleteData(
                table: "IdentityRole<string>",
                keyColumn: "Id",
                keyValue: "3ebe4b48-c02e-4f67-a9f7-9de622b6f8ac");

            migrationBuilder.DeleteData(
                table: "IdentityRole<string>",
                keyColumn: "Id",
                keyValue: "46e9d5e5-d9ab-4487-b029-776176b5b80f");

            migrationBuilder.DeleteData(
                table: "IdentityRole<string>",
                keyColumn: "Id",
                keyValue: "ee9e77db-706a-4738-b3ca-68c1884b2fa2");

            migrationBuilder.InsertData(
                table: "IdentityRole<string>",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "29a5fec0-1452-401b-8072-84d83fcddbf6", null, "Planlama", "PLANLAMA" },
                    { "3ddee005-18f4-43de-96e6-356751ec8800", null, "Satis", "SATIS" },
                    { "a04b1ede-4704-4fb3-abfd-33abe4d917bf", null, "Kullanici", "KULLANICI" },
                    { "f3bbe272-02b8-44cc-ade8-9b9f82516748", null, "Yonetici", "YONETICI" }
                });
        }
    }
}
