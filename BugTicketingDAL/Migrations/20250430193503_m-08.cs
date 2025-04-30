using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BugTicketingDAL.Migrations
{
    /// <inheritdoc />
    public partial class m08 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Attachments");

            migrationBuilder.AddColumn<byte[]>(
                name: "file",
                table: "Attachments",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "UserBugs",
                columns: new[] { "BugId", "UserId", "AssignedDate" },
                values: new object[,]
                {
                    { new Guid("aaaa1111-bbbb-2222-cccc-333333333333"), "711a4a71-6a79-4c67-a5ff-7d38d6254a90", new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("aaaa1111-bbbb-2222-cccc-333333333333"), "7a8bf7b6-4979-4729-bd78-80c1f39aad34", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bbbb2222-cccc-3333-dddd-444444444444"), "a23bb53a-7c52-4f13-8000-188ad242f04e", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cccc3333-dddd-4444-eeee-555555555555"), "711a4a71-6a79-4c67-a5ff-7d38d6254a90", new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserBugs",
                keyColumns: new[] { "BugId", "UserId" },
                keyValues: new object[] { new Guid("aaaa1111-bbbb-2222-cccc-333333333333"), "711a4a71-6a79-4c67-a5ff-7d38d6254a90" });

            migrationBuilder.DeleteData(
                table: "UserBugs",
                keyColumns: new[] { "BugId", "UserId" },
                keyValues: new object[] { new Guid("aaaa1111-bbbb-2222-cccc-333333333333"), "7a8bf7b6-4979-4729-bd78-80c1f39aad34" });

            migrationBuilder.DeleteData(
                table: "UserBugs",
                keyColumns: new[] { "BugId", "UserId" },
                keyValues: new object[] { new Guid("bbbb2222-cccc-3333-dddd-444444444444"), "a23bb53a-7c52-4f13-8000-188ad242f04e" });

            migrationBuilder.DeleteData(
                table: "UserBugs",
                keyColumns: new[] { "BugId", "UserId" },
                keyValues: new object[] { new Guid("cccc3333-dddd-4444-eeee-555555555555"), "711a4a71-6a79-4c67-a5ff-7d38d6254a90" });

            migrationBuilder.DropColumn(
                name: "file",
                table: "Attachments");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Attachments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
