using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace CodeFirstSetup.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "contries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "cv",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkLocaltion = table.Column<int>(type: "int", nullable: false),
                    DriverLicence = table.Column<bool>(type: "bit", nullable: false),
                    HaveCar = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cv", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "educations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Namn = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_educations", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "manufacturers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_manufacturers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfirmPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContryId = table.Column<int>(type: "int", nullable: true),
                    Usertype = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_users_contries_ContryId",
                        column: x => x.ContryId,
                        principalTable: "contries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CVEducation",
                columns: table => new
                {
                    EducationsId = table.Column<int>(type: "int", nullable: false),
                    cvsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CVEducation", x => new { x.EducationsId, x.cvsId });
                    table.ForeignKey(
                        name: "FK_CVEducation_cv_cvsId",
                        column: x => x.cvsId,
                        principalTable: "cv",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CVEducation_educations_EducationsId",
                        column: x => x.EducationsId,
                        principalTable: "educations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "car",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Manufacturerid = table.Column<int>(type: "int", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    RegNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HasRadio = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_car", x => x.Id);
                    table.ForeignKey(
                        name: "FK_car_manufacturers_Manufacturerid",
                        column: x => x.Manufacturerid,
                        principalTable: "manufacturers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "truck",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Manufactureid = table.Column<int>(type: "int", nullable: true),
                    LoadVolumeKvm = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    RegNumber = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_truck", x => x.Id);
                    table.ForeignKey(
                        name: "FK_truck_manufacturers_Manufactureid",
                        column: x => x.Manufactureid,
                        principalTable: "manufacturers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_car_Manufacturerid",
                table: "car",
                column: "Manufacturerid");

            migrationBuilder.CreateIndex(
                name: "IX_CVEducation_cvsId",
                table: "CVEducation",
                column: "cvsId");

            migrationBuilder.CreateIndex(
                name: "IX_truck_Manufactureid",
                table: "truck",
                column: "Manufactureid");

            migrationBuilder.CreateIndex(
                name: "IX_users_ContryId",
                table: "users",
                column: "ContryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "car");

            migrationBuilder.DropTable(
                name: "CVEducation");

            migrationBuilder.DropTable(
                name: "kurs");

            migrationBuilder.DropTable(
                name: "truck");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "cv");

            migrationBuilder.DropTable(
                name: "educations");

            migrationBuilder.DropTable(
                name: "manufacturers");

            migrationBuilder.DropTable(
                name: "contries");
        }
    }
}
