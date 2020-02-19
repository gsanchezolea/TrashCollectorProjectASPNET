using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorProject.Data.Migrations
{
    public partial class AddedCustomerAndEmployeeRolesToAppDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6fbfff-fa1b-4005-bbdd-c297043e3908");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ea714f56-83a8-4454-b45b-332bc81d40c7", "8b4b53ea-2967-4c33-b9ff-e9de8d8b11c3", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "748ba04d-fd34-415e-b29f-5b0575e68741", "367ea36f-80d2-49a0-bdbf-2393648e53c3", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "3d6fbfff-fa1b-4005-bbdd-c297043e3908", "d271bed3-c5f4-41fa-b578-ae63113edbac", "Admin", "ADMIN" });
        }
    }
}
