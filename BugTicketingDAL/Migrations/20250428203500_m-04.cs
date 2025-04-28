using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BugTicketingDAL.Migrations
{
    /// <inheritdoc />
    public partial class m04 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "711a4a71-6a79-4c67-a5ff-7d38d6254a90", 0, "20081146-a801-4276-a6de-90cfad6482cb", "MohamedEltabei@gmail.com", false, false, null, "MOHAMEDELTABEI@GMAIL.COM", "MOHAMEDELTABEI", "AQAAAAIAAYagAAAAEIbBRmKhMQgMjXnpWE7kV5XW1EJTM1VUyaPHN/83fTdH7FF0F4TPCfPO7LayX4VgiQ==", "d66b27d9-be5e-4a6e-8d32-1ebbe1209c73", false, "MohamedEltabei" },
                    { "7a8bf7b6-4979-4729-bd78-80c1f39aad34", 0, "15968bc9-945c-491b-8926-c33725488e4d", "KarimHelmy@gmail.com", false, false, null, "KARIMHELMY@GMAIL.COM", "KARIMHELMY", "AQAAAAIAAYagAAAAEIbBRmKhMQgMjXnpWE7kV5XW1EJTM1VUyaPHN/83fTdH7FF0F4TPCfPO7LayX4VgiQ==", "b2e99ab2-b261-438a-b9bf-3428da1a1e9e", false, "KarimHelmy" },
                    { "8f4b2288-bff8-4030-927e-e32bfdc9f90f", 0, "9db81390-5c91-4ab8-ad53-c158cf5fb130", "BasemAtia@gmail.com", false, false, null, "BASEMATIA@GMAIL.COM", "BASEMATIA", "AQAAAAIAAYagAAAAEIbBRmKhMQgMjXnpWE7kV5XW1EJTM1VUyaPHN/83fTdH7FF0F4TPCfPO7LayX4VgiQ==", "f7833d18-b3a1-4ebf-b0ad-680f3dfb7be0", false, "BasemAtia" },
                    { "981fec6c-2d2a-4843-99bf-a5f9d4baf85b", 0, "21df4f63-ae4b-4de9-a2f1-7a4b2f028e87", "OmerAraby@gmail.com", false, false, null, "OMERARABY@GMAIL.COM", "OMERARABY", "AQAAAAIAAYagAAAAEIbBRmKhMQgMjXnpWE7kV5XW1EJTM1VUyaPHN/83fTdH7FF0F4TPCfPO7LayX4VgiQ==", "3a7d3936-5157-42ca-95fc-b85e03ede5a4", false, "OmerAraby" },
                    { "a23bb53a-7c52-4f13-8000-188ad242f04e", 0, "15ca0019-f57e-418d-a1ef-3b91ce1279ad", "HaniAbdo@gmail.com", false, false, null, "HANIABDO@GMAIL.COM", "HANIABDO", "AQAAAAIAAYagAAAAEIbBRmKhMQgMjXnpWE7kV5XW1EJTM1VUyaPHN/83fTdH7FF0F4TPCfPO7LayX4VgiQ==", "baea035c-8f2c-4d5c-9972-72092c40044b", false, "HaniAbdo" },
                    { "e6c01d4f-bc6a-4fc3-afe3-62de02997dcf", 0, "f483a3ef-4d79-4b53-b0c9-34bc6fe74b31", "AlaaEisa@gmail.com", false, false, null, "ALAAEISA@GMAIL.COM", "ALAAEISA", "AQAAAAIAAYagAAAAEIbBRmKhMQgMjXnpWE7kV5XW1EJTM1VUyaPHN/83fTdH7FF0F4TPCfPO7LayX4VgiQ==", "332de8d3-301c-49dd-a11b-78ab7e8dd0d4", false, "AlaaEisa" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "711a4a71-6a79-4c67-a5ff-7d38d6254a90");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7a8bf7b6-4979-4729-bd78-80c1f39aad34");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f4b2288-bff8-4030-927e-e32bfdc9f90f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "981fec6c-2d2a-4843-99bf-a5f9d4baf85b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a23bb53a-7c52-4f13-8000-188ad242f04e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6c01d4f-bc6a-4fc3-afe3-62de02997dcf");
        }
    }
}
