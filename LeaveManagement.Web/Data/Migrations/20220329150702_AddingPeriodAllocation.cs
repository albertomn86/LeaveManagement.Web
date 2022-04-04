using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddingPeriodAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmployeddId",
                table: "LeaveAllocations",
                newName: "EmployeedId");

            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.RenameColumn(
                name: "EmployeedId",
                table: "LeaveAllocations",
                newName: "EmployeddId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d17e2d8-e406-4dcc-964e-0bc47c803830",
                column: "ConcurrencyStamp",
                value: "430f25a2-f8bc-47a1-9f93-e1a500252bf8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d17e4d8-e409-4dcb-964e-0bc47dd03830",
                column: "ConcurrencyStamp",
                value: "ce2993d9-1600-4dbe-9a5f-448185ec01a1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d17e2d8-e406-4dcb-964e-0bc47c803830",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad2413ab-6f5e-45c8-afbf-d408d087d8bb", "AQAAAAEAACcQAAAAEFO7h58K8uDO95c8m/9Z7RJaPfXayZ2RApf6+2rRliN0XqOQB8CQlrVfzkPJt3QyUA==", "012961e0-6fcc-4091-927d-317ead2722cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d17e2d8-e406-4dcb-caac-0bc47c803830",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d77e2a86-0c0a-446e-9fe6-3036d3462a72", "AQAAAAEAACcQAAAAEHjbTH7hDb+tpYJWdocU1TQQZNAPFpGPimmDlpWVGP6ulK/miUEK2+BPPFj3/s5BYw==", "f5bedf89-a7b8-466f-8142-4ee09fe4f50e" });
        }
    }
}
