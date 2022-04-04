using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUserNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ad2413ab-6f5e-45c8-afbf-d408d087d8bb", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEFO7h58K8uDO95c8m/9Z7RJaPfXayZ2RApf6+2rRliN0XqOQB8CQlrVfzkPJt3QyUA==", "012961e0-6fcc-4091-927d-317ead2722cb", "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d17e2d8-e406-4dcb-caac-0bc47c803830",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d77e2a86-0c0a-446e-9fe6-3036d3462a72", true, "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEHjbTH7hDb+tpYJWdocU1TQQZNAPFpGPimmDlpWVGP6ulK/miUEK2+BPPFj3/s5BYw==", "f5bedf89-a7b8-466f-8142-4ee09fe4f50e", "user@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d17e2d8-e406-4dcc-964e-0bc47c803830",
                column: "ConcurrencyStamp",
                value: "1f0a9076-f05d-40c1-aeb2-7df21c1ca7b5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d17e4d8-e409-4dcb-964e-0bc47dd03830",
                column: "ConcurrencyStamp",
                value: "a585f08b-c724-4a83-90c2-e1344ca82f30");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d17e2d8-e406-4dcb-964e-0bc47c803830",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "388563db-ef9f-47d1-96cd-9eac4b0cae5f", false, null, "AQAAAAEAACcQAAAAEDSZLtLGsY8ZYD0GjYby45ioAjPf7fT3R9NQckBLqgYwS3lKbeXb2JDbDokaDG0P9A==", "c0a65626-3ce2-47a6-b1ab-1cbdb67728a9", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d17e2d8-e406-4dcb-caac-0bc47c803830",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ec915e79-36b4-494c-92e3-66435e380d9f", false, null, "AQAAAAEAACcQAAAAEGQdnyL+54FPLgfEY/t+89R2u8NX0OS9SLucFLjtpTm4wIx1c6dQR3nQ6h9mSieSow==", "c9ad4982-9879-415a-a61f-98d2323464ba", null });
        }
    }
}
