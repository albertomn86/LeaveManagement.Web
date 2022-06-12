using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d17e2d8-e406-4dcc-964e-0bc47c803830",
                column: "ConcurrencyStamp",
                value: "6890b077-fe4e-494d-97e1-48b57a8bac85");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d17e4d8-e409-4dcb-964e-0bc47dd03830",
                column: "ConcurrencyStamp",
                value: "0ea354e6-a68e-4168-bef8-dfaa9bba820c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d17e2d8-e406-4dcb-964e-0bc47c803830",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72c31ac1-19b4-4f7c-aa3f-71a730056f28", "AQAAAAEAACcQAAAAEEUXnY5iappxBTgUOxKfFqc/sAn2nKRqJWqQogabnjWCXUBVCVIQQGnl3AKAhemK4w==", "43dda643-6179-4eff-9e21-abfb710e7a89" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d17e2d8-e406-4dcb-caac-0bc47c803830",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0e91b61-15ea-4973-8352-88c8f1ec1c49", "AQAAAAEAACcQAAAAEEjWG+QlE9/c8JUVVxGbGNAZdWe9ladpVVOBQ8tVfZSbpybcYz+ojCdLrEpWm3iVrw==", "ebce8966-fd7f-45d2-aa59-5e64a9dc650f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d17e2d8-e406-4dcc-964e-0bc47c803830",
                column: "ConcurrencyStamp",
                value: "bab36137-6e4c-4886-818c-3df251cc9c7e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d17e4d8-e409-4dcb-964e-0bc47dd03830",
                column: "ConcurrencyStamp",
                value: "613c8d44-fb14-49c6-b56f-29e8df2e6145");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d17e2d8-e406-4dcb-964e-0bc47c803830",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cbc54f50-d7a1-4d4a-a7ff-0a966477d3ae", "AQAAAAEAACcQAAAAEN9BYZJ5CB57WNCcSpunM4gQfZzNDuk3ZKw/+/YvpnlEnMP3v4cJHc59PvONpaCpRQ==", "fee532ec-cf63-40be-b7cb-efd2505347ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d17e2d8-e406-4dcb-caac-0bc47c803830",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b49a400-b654-4ed6-8802-4d6741482a67", "AQAAAAEAACcQAAAAEDV2ntrTjL+1hPqdlTC+36cZHnTIO/mZNiUqYVKKi/oiUexK/5r4ipDwLna/BKslyA==", "087ab2fe-288a-4f6e-aba6-c3abcd158748" });
        }
    }
}
