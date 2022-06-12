using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class UpdateRequestComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d17e2d8-e406-4dcc-964e-0bc47c803830",
                column: "ConcurrencyStamp",
                value: "a7e70779-baa3-4a9b-85c3-71e3e291f124");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d17e4d8-e409-4dcb-964e-0bc47dd03830",
                column: "ConcurrencyStamp",
                value: "428f454a-93aa-4def-a122-1b682ff8780f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d17e2d8-e406-4dcb-964e-0bc47c803830",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a20e544-df3a-475d-9dcb-8e2b7a61b51d", "AQAAAAEAACcQAAAAEGOEHAGlePVElLhIRM613GAS6ivbE27MUZjG2YLEYmYfn1rjCt8wV934FJisPuaE3w==", "703e6802-e6a0-410f-a865-7c967efc25af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d17e2d8-e406-4dcb-caac-0bc47c803830",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25a32f52-6c3a-41d1-b8de-fba00f1258b9", "AQAAAAEAACcQAAAAEHzDBIGi08PulQqAHSDGWV8gJjWAVZI8WlXkJWCaGOPTIHmO0ykGzpXcZkhkIzGjaQ==", "610ff152-4965-469f-9dfb-a2804691bcc8" });
        }
    }
}
