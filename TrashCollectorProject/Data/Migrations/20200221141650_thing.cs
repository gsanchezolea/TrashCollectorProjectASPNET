using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorProject.Data.Migrations
{
    public partial class thing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0df38d16-a107-47cb-a496-aa5306e3ab20");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b3bf4c5c-bcb3-4de3-80ba-1a29fb780bb9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "daf616f8-97c1-4215-b926-fa0a74b8c8e3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c122a2bc-4ee0-4be6-a44a-3e80a300b489", "840fa575-9565-46ef-9bcc-feeec8b85127", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "afec1f25-3af4-48d9-8cc7-708f12f0d342", "8282c7c9-a5fd-478c-b283-12a3bc24b9e4", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d6847726-a623-4d08-baaf-46acd6b0e117", "f394b4d9-7b17-4fff-a25f-f131bedbc489", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "afec1f25-3af4-48d9-8cc7-708f12f0d342");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c122a2bc-4ee0-4be6-a44a-3e80a300b489");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6847726-a623-4d08-baaf-46acd6b0e117");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b3bf4c5c-bcb3-4de3-80ba-1a29fb780bb9", "3c6176a9-0012-4da5-993d-05f98f566af4", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0df38d16-a107-47cb-a496-aa5306e3ab20", "11bce380-2198-4d2d-b933-e2bbe9330df1", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "daf616f8-97c1-4215-b926-fa0a74b8c8e3", "7e903353-546f-4e25-bdcf-2cbf6e1287d0", "Employee", "EMPLOYEE" });
        }
    }
}
