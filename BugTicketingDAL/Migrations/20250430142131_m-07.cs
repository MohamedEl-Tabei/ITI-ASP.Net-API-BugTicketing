using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BugTicketingDAL.Migrations
{
    /// <inheritdoc />
    public partial class m07 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Bugs",
                newName: "Id");

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "EndDate", "ManagerId", "Name", "StartDate", "Status" },
                values: new object[,]
                {
                    { new Guid("11111111-aaaa-4bbb-cccc-111111111111"), new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "e6c01d4f-bc6a-4fc3-afe3-62de02997dcf", "Bug Tracking System", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -1 },
                    { new Guid("22222222-bbbb-4ccc-dddd-222222222222"), new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "e6c01d4f-bc6a-4fc3-afe3-62de02997dcf", "E-Commerce Platform", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -1 },
                    { new Guid("33333333-cccc-4ddd-eeee-333333333333"), new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "8f4b2288-bff8-4030-927e-e32bfdc9f90f", "HR System", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -1 }
                });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Description", "ProjectId", "Status", "Title" },
                values: new object[,]
                {
                    { new Guid("aaaa1111-bbbb-2222-cccc-333333333333"), "When clicking the login button, nothing happens.", new Guid("11111111-aaaa-4bbb-cccc-111111111111"), -1, "Login button not working" },
                    { new Guid("bbbb2222-cccc-3333-dddd-444444444444"), "Timeout occurs when processing Visa payment.", new Guid("22222222-bbbb-4ccc-dddd-222222222222"), -1, "Payment gateway timeout" },
                    { new Guid("cccc3333-dddd-4444-eeee-555555555555"), "Profile images are not displayed on the HR system.", new Guid("33333333-cccc-4ddd-eeee-333333333333"), -1, "Employee profile image not loading" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: new Guid("aaaa1111-bbbb-2222-cccc-333333333333"));

            migrationBuilder.DeleteData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: new Guid("bbbb2222-cccc-3333-dddd-444444444444"));

            migrationBuilder.DeleteData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: new Guid("cccc3333-dddd-4444-eeee-555555555555"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("11111111-aaaa-4bbb-cccc-111111111111"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("22222222-bbbb-4ccc-dddd-222222222222"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("33333333-cccc-4ddd-eeee-333333333333"));

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Bugs",
                newName: "id");
        }
    }
}
