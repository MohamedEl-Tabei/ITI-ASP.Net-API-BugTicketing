using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BugTicketingDAL.Migrations
{
    /// <inheritdoc />
    public partial class m03 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b172061-cc4b-416d-8559-4dcb240cd012",
                column: "NormalizedName",
                value: "MANAGER");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4179d4b9-6aa8-4e27-8293-9fd69b331e8a",
                column: "NormalizedName",
                value: "DEVELOPER");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bcd832ec-cae3-4b7b-baa6-f9f02b9858c0",
                column: "NormalizedName",
                value: "TESTER");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b172061-cc4b-416d-8559-4dcb240cd012",
                column: "NormalizedName",
                value: null);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4179d4b9-6aa8-4e27-8293-9fd69b331e8a",
                column: "NormalizedName",
                value: null);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bcd832ec-cae3-4b7b-baa6-f9f02b9858c0",
                column: "NormalizedName",
                value: null);
        }
    }
}
