using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Drivers.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    DriverId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Dob = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    SSN = table.Column<int>(type: "INTEGER", nullable: false),
                    PostCode = table.Column<int>(type: "INTEGER", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    License = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.DriverId);
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "DriverId", "Address", "Dob", "Email", "FirstName", "LastName", "License", "Phone", "PostCode", "SSN" },
                values: new object[] { 4, "Chicago", "01/01/1998", "", "Vinod", "Chilaka", "", "53456435", null, 34532434 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drivers");
        }
    }
}
