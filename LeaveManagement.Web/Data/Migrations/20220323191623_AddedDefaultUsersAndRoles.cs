using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5d17e2d8-e406-4dcc-964e-0bc47c803830", "1f0a9076-f05d-40c1-aeb2-7df21c1ca7b5", "User", "USER" },
                    { "8d17e4d8-e409-4dcb-964e-0bc47dd03830", "a585f08b-c724-4a83-90c2-e1344ca82f30", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8d17e2d8-e406-4dcb-964e-0bc47c803830", 0, "388563db-ef9f-47d1-96cd-9eac4b0cae5f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEDSZLtLGsY8ZYD0GjYby45ioAjPf7fT3R9NQckBLqgYwS3lKbeXb2JDbDokaDG0P9A==", null, false, "c0a65626-3ce2-47a6-b1ab-1cbdb67728a9", null, false, null },
                    { "8d17e2d8-e406-4dcb-caac-0bc47c803830", 0, "ec915e79-36b4-494c-92e3-66435e380d9f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEGQdnyL+54FPLgfEY/t+89R2u8NX0OS9SLucFLjtpTm4wIx1c6dQR3nQ6h9mSieSow==", null, false, "c9ad4982-9879-415a-a61f-98d2323464ba", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8d17e4d8-e409-4dcb-964e-0bc47dd03830", "8d17e2d8-e406-4dcb-964e-0bc47c803830" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5d17e2d8-e406-4dcc-964e-0bc47c803830", "8d17e2d8-e406-4dcb-caac-0bc47c803830" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8d17e4d8-e409-4dcb-964e-0bc47dd03830", "8d17e2d8-e406-4dcb-964e-0bc47c803830" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5d17e2d8-e406-4dcc-964e-0bc47c803830", "8d17e2d8-e406-4dcb-caac-0bc47c803830" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d17e2d8-e406-4dcc-964e-0bc47c803830");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d17e4d8-e409-4dcb-964e-0bc47dd03830");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d17e2d8-e406-4dcb-964e-0bc47c803830");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d17e2d8-e406-4dcb-caac-0bc47c803830");
        }
    }
}
