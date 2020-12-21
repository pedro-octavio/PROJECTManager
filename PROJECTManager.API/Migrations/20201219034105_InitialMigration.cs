using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PROJECTManager.API.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 4200, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CreateDate", "Description", "Name" },
                values: new object[] { "p02bz8aql1", new DateTime(2017, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "A System of control collaborators.", "HR System" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CreateDate", "Description", "Name" },
                values: new object[] { "a02mxlzp1a", new DateTime(2019, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Legacy system.", "Storage System Project" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CreateDate", "Description", "Name" },
                values: new object[] { "ms910alqx7", new DateTime(2020, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Rules Implementation in Bank Client" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
