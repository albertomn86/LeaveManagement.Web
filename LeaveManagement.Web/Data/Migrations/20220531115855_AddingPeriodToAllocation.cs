using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmployeedId",
                table: "LeaveAllocations",
                newName: "EmployeeId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d17e2d8-e406-4dcc-964e-0bc47c803830",
                column: "ConcurrencyStamp",
                value: "2a59a32c-39dc-4fb4-9ae6-12949d53ff5c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d17e4d8-e409-4dcb-964e-0bc47dd03830",
                column: "ConcurrencyStamp",
                value: "4de184f7-5cda-4050-aa9e-04ab227c5936");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d17e2d8-e406-4dcb-964e-0bc47c803830",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5d0dfbb-9a73-4c0c-920c-00c1a698ca9f", "AQAAAAEAACcQAAAAECO3jrwqwOTJug16g6KgUPK4Da38kQoCGbTg+QNo6+hKWqIMiDK9fNl1yjjXV3105Q==", "dc06fa48-b989-4a2b-9df1-a4c60161795e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d17e2d8-e406-4dcb-caac-0bc47c803830",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e7cdeec-26d3-4c1f-9eb5-9c44899f8706", "AQAAAAEAACcQAAAAEBLoHAkGJ+f1tp4xqj0H6maSLTX3PR1HYAQFx0uh4qe+2eWchCWYU942ydEvafVQ8g==", "ba5523a3-eeea-446c-b25a-43dafcd3ace6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "LeaveAllocations",
                newName: "EmployeedId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d17e2d8-e406-4dcc-964e-0bc47c803830",
                column: "ConcurrencyStamp",
                value: "a777829a-3674-4c7f-b641-94c5bd4c7e47");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d17e4d8-e409-4dcb-964e-0bc47dd03830",
                column: "ConcurrencyStamp",
                value: "37f8ba5e-848f-4322-946e-2701ad93922d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d17e2d8-e406-4dcb-964e-0bc47c803830",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "feb92f7b-9ec0-46d0-87c5-f19d4ed1e89a", "AQAAAAEAACcQAAAAEKCp5xpaaNuFfjQNW0GXefz8wgB8jZcUVI5WO/PCzuB+nTo6Z7CCbhz9AKhCSRs6lQ==", "0745beb0-db43-43d2-890e-def6134b5a0e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d17e2d8-e406-4dcb-caac-0bc47c803830",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e517825-eeec-4385-a2f4-d5c2476ff254", "AQAAAAEAACcQAAAAEPo4vDp2cIY705KNpTUDNDlVLVndo1xBDOCFBHMZEQfN/ZkyIAmXsW6AtSFScd846A==", "54956992-f7d5-464b-b4ef-3487b2cfa052" });
        }
    }
}
