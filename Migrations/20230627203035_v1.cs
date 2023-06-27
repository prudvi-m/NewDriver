using System;
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
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    SSN = table.Column<int>(type: "INTEGER", nullable: false),
                    PostCode = table.Column<int>(type: "INTEGER", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    DriverLicense = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.DriverId);
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "DriverId", "Address", "DateOfBirth", "DriverLicense", "Email", "FirstName", "LastName", "Phone", "PostCode", "SSN" },
                values: new object[] { 1, "NY", new DateTime(1989, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", "Johnson", "Mitchel", "1221221221", null, 2353453 });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "DriverId", "Address", "DateOfBirth", "DriverLicense", "Email", "FirstName", "LastName", "Phone", "PostCode", "SSN" },
                values: new object[] { 2, "Sydney", new DateTime(1992, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", "Mitchel", "Strac", "2121212121", null, 456435 });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "DriverId", "Address", "DateOfBirth", "DriverLicense", "Email", "FirstName", "LastName", "Phone", "PostCode", "SSN" },
                values: new object[] { 3, "Brisbane", new DateTime(1990, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", "Breet", "Lee", "7676767676", null, 23123234 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drivers");
        }
    }
}
