using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorProject.Data.Migrations
{
    public partial class FixedRoleBuilder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "748ba04d-fd34-415e-b29f-5b0575e68741");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea714f56-83a8-4454-b45b-332bc81d40c7");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "ea714f56-83a8-4454-b45b-332bc81d40c7", "8b4b53ea-2967-4c33-b9ff-e9de8d8b11c3", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "748ba04d-fd34-415e-b29f-5b0575e68741", "367ea36f-80d2-49a0-bdbf-2393648e53c3", "Employee", "EMPLOYEE" });
        }
    }
}
