using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorProject.Data.Migrations
{
    public partial class CreatedDbSets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72e6dec3-5e48-420f-aad8-8d633d7490ec");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "19e6aba7-535b-4e08-8a92-a90d7f7c22f8", "a7c976c8-c37c-4c02-a9f1-1d059b4f11b7", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "19e6aba7-535b-4e08-8a92-a90d7f7c22f8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "72e6dec3-5e48-420f-aad8-8d633d7490ec", "a05fe2b2-07e6-4d08-b9e6-628750e8dda3", "Admin", "ADMIN" });
        }
    }
}
