using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorProject.Data.Migrations
{
    public partial class AddedDisplayNameToModelProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0256fcc5-7718-4a7a-af21-ce740f8307e7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "349ad1f1-6532-4211-88a6-259d8a48df49");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5234d037-a8ea-46c5-8d41-16ba49ebc946");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "0256fcc5-7718-4a7a-af21-ce740f8307e7", "85afcc74-de7b-4605-9273-cbfcb511e10a", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5234d037-a8ea-46c5-8d41-16ba49ebc946", "803e5d6f-f167-4799-a3d3-ef8c50e43727", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "349ad1f1-6532-4211-88a6-259d8a48df49", "234271e6-67dc-4430-a74d-0ab656d51c79", "Employee", "EMPLOYEE" });
        }
    }
}
