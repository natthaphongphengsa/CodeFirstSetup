using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstSetup.Migrations
{
    public partial class Initial5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_Contry_ContryId",
                table: "users");

            migrationBuilder.DropTable(
                name: "Contry");

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

            migrationBuilder.AddForeignKey(
                name: "FK_users_contries_ContryId",
                table: "users",
                column: "ContryId",
                principalTable: "contries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_contries_ContryId",
                table: "users");

            migrationBuilder.DropTable(
                name: "contries");

            migrationBuilder.CreateTable(
                name: "Contry",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contry", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_users_Contry_ContryId",
                table: "users",
                column: "ContryId",
                principalTable: "Contry",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
