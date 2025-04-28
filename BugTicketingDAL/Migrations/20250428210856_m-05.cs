using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BugTicketingDAL.Migrations
{
    /// <inheritdoc />
    public partial class m05 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "4179d4b9-6aa8-4e27-8293-9fd69b331e8a", "711a4a71-6a79-4c67-a5ff-7d38d6254a90" },
                    { "4179d4b9-6aa8-4e27-8293-9fd69b331e8a", "7a8bf7b6-4979-4729-bd78-80c1f39aad34" },
                    { "bcd832ec-cae3-4b7b-baa6-f9f02b9858c0", "7a8bf7b6-4979-4729-bd78-80c1f39aad34" },
                    { "0b172061-cc4b-416d-8559-4dcb240cd012", "8f4b2288-bff8-4030-927e-e32bfdc9f90f" },
                    { "bcd832ec-cae3-4b7b-baa6-f9f02b9858c0", "981fec6c-2d2a-4843-99bf-a5f9d4baf85b" },
                    { "4179d4b9-6aa8-4e27-8293-9fd69b331e8a", "a23bb53a-7c52-4f13-8000-188ad242f04e" },
                    { "0b172061-cc4b-416d-8559-4dcb240cd012", "e6c01d4f-bc6a-4fc3-afe3-62de02997dcf" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4179d4b9-6aa8-4e27-8293-9fd69b331e8a", "711a4a71-6a79-4c67-a5ff-7d38d6254a90" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4179d4b9-6aa8-4e27-8293-9fd69b331e8a", "7a8bf7b6-4979-4729-bd78-80c1f39aad34" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bcd832ec-cae3-4b7b-baa6-f9f02b9858c0", "7a8bf7b6-4979-4729-bd78-80c1f39aad34" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0b172061-cc4b-416d-8559-4dcb240cd012", "8f4b2288-bff8-4030-927e-e32bfdc9f90f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bcd832ec-cae3-4b7b-baa6-f9f02b9858c0", "981fec6c-2d2a-4843-99bf-a5f9d4baf85b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4179d4b9-6aa8-4e27-8293-9fd69b331e8a", "a23bb53a-7c52-4f13-8000-188ad242f04e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0b172061-cc4b-416d-8559-4dcb240cd012", "e6c01d4f-bc6a-4fc3-afe3-62de02997dcf" });
        }
    }
}
