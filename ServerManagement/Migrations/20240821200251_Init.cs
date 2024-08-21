using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ServerManagement.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Servers",
                columns: table => new
                {
                    ServerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsOnline = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servers", x => x.ServerId);
                });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "ServerId", "City", "IsOnline", "Name", "UserCount" },
                values: new object[,]
                {
                    { 1, "Toronto", false, "Server1", 0 },
                    { 2, "Toronto", false, "Server2", 0 },
                    { 3, "Toronto", false, "Server3", 0 },
                    { 4, "Toronto", false, "Server4", 0 },
                    { 5, "Montreal", false, "Server5", 0 },
                    { 6, "Montreal", false, "Server6", 0 },
                    { 7, "Montreal", true, "Server7", 0 },
                    { 8, "Ottawa", false, "Server8", 0 },
                    { 9, "Ottawa", false, "Server9", 0 },
                    { 10, "Calgary", false, "Server10", 0 },
                    { 11, "Calgary", true, "Server11", 0 },
                    { 12, "Halifax", false, "Server12", 0 },
                    { 13, "Halifax", false, "Server13", 0 },
                    { 14, "Halifax", true, "Server14", 0 },
                    { 15, "Halifax", true, "Server15", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Servers");
        }
    }
}
