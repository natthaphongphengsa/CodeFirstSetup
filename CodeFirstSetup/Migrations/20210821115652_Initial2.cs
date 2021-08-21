using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstSetup.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_car_Manufacturer_Manufacturerid",
                table: "car");

            migrationBuilder.DropForeignKey(
                name: "FK_truck_Manufacturer_Manufactureid",
                table: "truck");

            migrationBuilder.DropTable(
                name: "Manufacturer");

            migrationBuilder.DropIndex(
                name: "IX_truck_Manufactureid",
                table: "truck");

            migrationBuilder.DropIndex(
                name: "IX_car_Manufacturerid",
                table: "car");

            migrationBuilder.DropColumn(
                name: "Manufactureid",
                table: "truck");

            migrationBuilder.DropColumn(
                name: "Manufacturerid",
                table: "car");

            migrationBuilder.AddColumn<string>(
                name: "Manufacture",
                table: "truck",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Manufacturer",
                table: "car",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Manufacture",
                table: "truck");

            migrationBuilder.DropColumn(
                name: "Manufacturer",
                table: "car");

            migrationBuilder.AddColumn<int>(
                name: "Manufactureid",
                table: "truck",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Manufacturerid",
                table: "car",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Manufacturer",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturer", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_truck_Manufactureid",
                table: "truck",
                column: "Manufactureid");

            migrationBuilder.CreateIndex(
                name: "IX_car_Manufacturerid",
                table: "car",
                column: "Manufacturerid");

            migrationBuilder.AddForeignKey(
                name: "FK_car_Manufacturer_Manufacturerid",
                table: "car",
                column: "Manufacturerid",
                principalTable: "Manufacturer",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_truck_Manufacturer_Manufactureid",
                table: "truck",
                column: "Manufactureid",
                principalTable: "Manufacturer",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
