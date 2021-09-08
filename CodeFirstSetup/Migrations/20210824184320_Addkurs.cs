using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstSetup.Migrations
{
    public partial class Addkurs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "kurs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModeified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Startday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LectureDay = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kurs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "kurs");
        }
    }
}
