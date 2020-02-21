using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorProject.Data.Migrations
{
    public partial class AdjustedModelsToDisplayNameAppropriately : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96795600-c9b9-460b-9fd9-a9970a566959");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e87a6a41-150d-4c64-856f-3ce9f7c4b173");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f35b3914-bedd-49cf-a32b-d4997aa95cd2");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "e87a6a41-150d-4c64-856f-3ce9f7c4b173", "1d68d606-bced-4ad1-a249-43ccb38fc966", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f35b3914-bedd-49cf-a32b-d4997aa95cd2", "02da4e19-7a2b-46be-b560-d914b5bca0cd", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "96795600-c9b9-460b-9fd9-a9970a566959", "c4d53242-2610-497d-a579-73786c43d4d6", "Employee", "EMPLOYEE" });
        }
    }
}
