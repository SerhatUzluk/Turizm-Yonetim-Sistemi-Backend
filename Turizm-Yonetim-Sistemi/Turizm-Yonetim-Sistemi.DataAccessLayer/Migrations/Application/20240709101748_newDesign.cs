using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Turizm_Yonetim_Sistemi.DataAccessLayer.Migrations.Application
{
    /// <inheritdoc />
    public partial class newDesign : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "TelefonNumarasi",
                table: "Musteriler");

            migrationBuilder.InsertData(
                table: "IdentityRole<string>",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2a8c9112-2728-479f-b7ad-e8ec55ee8235", null, "Yonetici", "YONETICI" },
                    { "48182cc7-ac42-47a8-9e72-5afadd5a3a93", null, "Planlama", "PLANLAMA" },
                    { "eb92ba9e-d13c-4368-92e7-a89097199f6c", null, "Kullanici", "KULLANICI" },
                    { "faafecc6-acc7-4ed5-9345-996a50072420", null, "Satis", "SATIS" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole<string>",
                keyColumn: "Id",
                keyValue: "2a8c9112-2728-479f-b7ad-e8ec55ee8235");

            migrationBuilder.DeleteData(
                table: "IdentityRole<string>",
                keyColumn: "Id",
                keyValue: "48182cc7-ac42-47a8-9e72-5afadd5a3a93");

            migrationBuilder.DeleteData(
                table: "IdentityRole<string>",
                keyColumn: "Id",
                keyValue: "eb92ba9e-d13c-4368-92e7-a89097199f6c");

            migrationBuilder.DeleteData(
                table: "IdentityRole<string>",
                keyColumn: "Id",
                keyValue: "faafecc6-acc7-4ed5-9345-996a50072420");

            migrationBuilder.AddColumn<string>(
                name: "TelefonNumarasi",
                table: "Musteriler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
    }
}
