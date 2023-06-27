using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Drivers.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreId = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    DriverId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Year = table.Column<int>(type: "INTEGER", nullable: false),
                    Rating = table.Column<int>(type: "INTEGER", nullable: false),
                    GenreId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.DriverId);
                    table.ForeignKey(
                        name: "FK_Drivers_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "FirstName" },
                values: new object[] { "A", "Action" });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "FirstName" },
                values: new object[] { "C", "Comedy" });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "FirstName" },
                values: new object[] { "D", "Drama" });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "FirstName" },
                values: new object[] { "H", "Horror" });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "FirstName" },
                values: new object[] { "M", "Musical" });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "FirstName" },
                values: new object[] { "R", "RomCom" });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "FirstName" },
                values: new object[] { "S", "SciFi" });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "DriverId", "FirstName", "GenreId", "LastName", "Rating", "Year" },
                values: new object[] { 2, "Wonder Woman", "A", "ok", 3, 2017 });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "DriverId", "FirstName", "GenreId", "LastName", "Rating", "Year" },
                values: new object[] { 3, "Moonstruck", "R", "ok", 4, 1988 });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "DriverId", "FirstName", "GenreId", "LastName", "Rating", "Year" },
                values: new object[] { 4, "Casablanca", "D", "ok", 5, 1942 });

            migrationBuilder.CreateIndex(
                name: "IX_Drivers_GenreId",
                table: "Drivers",
                column: "GenreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
