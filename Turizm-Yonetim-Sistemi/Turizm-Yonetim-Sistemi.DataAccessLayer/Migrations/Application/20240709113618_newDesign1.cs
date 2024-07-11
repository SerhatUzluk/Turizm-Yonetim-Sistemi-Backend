using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Turizm_Yonetim_Sistemi.DataAccessLayer.Migrations.Application
{
    /// <inheritdoc />
    public partial class newDesign1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "TelefonNumarasi",
                table: "FirmaGorevlileri");

            migrationBuilder.InsertData(
                table: "IdentityRole<string>",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2cc320ae-cf85-43f0-94bc-fb21b6bf0c04", null, "Yonetici", "YONETICI" },
                    { "36f85687-4aad-4b5e-b0cf-d8bac22541ee", null, "Satis", "SATIS" },
                    { "883f7fd4-1ac3-44e4-aabb-b96fbe5235ff", null, "Kullanici", "KULLANICI" },
                    { "c9500ff5-8251-41e1-b1ee-1bf61890f019", null, "Planlama", "PLANLAMA" },
                    { "fab11dd7-6ac6-4f62-84e4-4abcfc420ff8", null, "Musteri", "MUSTERI" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole<string>",
                keyColumn: "Id",
                keyValue: "2cc320ae-cf85-43f0-94bc-fb21b6bf0c04");

            migrationBuilder.DeleteData(
                table: "IdentityRole<string>",
                keyColumn: "Id",
                keyValue: "36f85687-4aad-4b5e-b0cf-d8bac22541ee");

            migrationBuilder.DeleteData(
                table: "IdentityRole<string>",
                keyColumn: "Id",
                keyValue: "883f7fd4-1ac3-44e4-aabb-b96fbe5235ff");

            migrationBuilder.DeleteData(
                table: "IdentityRole<string>",
                keyColumn: "Id",
                keyValue: "c9500ff5-8251-41e1-b1ee-1bf61890f019");

            migrationBuilder.DeleteData(
                table: "IdentityRole<string>",
                keyColumn: "Id",
                keyValue: "fab11dd7-6ac6-4f62-84e4-4abcfc420ff8");

            migrationBuilder.AddColumn<string>(
                name: "TelefonNumarasi",
                table: "FirmaGorevlileri",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
    }
}
