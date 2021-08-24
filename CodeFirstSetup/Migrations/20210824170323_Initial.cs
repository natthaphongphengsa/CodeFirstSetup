using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstSetup.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_educations_cv_CVId",
                table: "educations");

            migrationBuilder.DropIndex(
                name: "IX_educations_CVId",
                table: "educations");

            migrationBuilder.DropColumn(
                name: "CVId",
                table: "educations");

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

            migrationBuilder.CreateIndex(
                name: "IX_CVEducation_cvsId",
                table: "CVEducation",
                column: "cvsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CVEducation");

            migrationBuilder.AddColumn<int>(
                name: "CVId",
                table: "educations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_educations_CVId",
                table: "educations",
                column: "CVId");

            migrationBuilder.AddForeignKey(
                name: "FK_educations_cv_CVId",
                table: "educations",
                column: "CVId",
                principalTable: "cv",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
