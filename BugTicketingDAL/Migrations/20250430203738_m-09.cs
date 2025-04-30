using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BugTicketingDAL.Migrations
{
    /// <inheritdoc />
    public partial class m09 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "file",
                table: "Attachments");

            migrationBuilder.AddColumn<string>(
                name: "filePath",
                table: "Attachments",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "filePath",
                table: "Attachments");

            migrationBuilder.AddColumn<byte[]>(
                name: "file",
                table: "Attachments",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
