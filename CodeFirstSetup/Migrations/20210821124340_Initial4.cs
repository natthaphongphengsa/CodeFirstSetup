using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstSetup.Migrations
{
    public partial class Initial4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateIndex(
                name: "IX_truck_Manufactureid",
                table: "truck",
                column: "Manufactureid");

            migrationBuilder.CreateIndex(
                name: "IX_car_Manufacturerid",
                table: "car",
                column: "Manufacturerid");

            migrationBuilder.AddForeignKey(
                name: "FK_car_manufacturers_Manufacturerid",
                table: "car",
                column: "Manufacturerid",
                principalTable: "manufacturers",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_truck_manufacturers_Manufactureid",
                table: "truck",
                column: "Manufactureid",
                principalTable: "manufacturers",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_car_manufacturers_Manufacturerid",
                table: "car");

            migrationBuilder.DropForeignKey(
                name: "FK_truck_manufacturers_Manufactureid",
                table: "truck");

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
    }
}
