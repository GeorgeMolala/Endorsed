using Microsoft.EntityFrameworkCore.Migrations;

namespace Endorsed.Migrations
{
    public partial class SecondAttempt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Provinces_Addresses_AddressID",
                table: "Provinces");

            migrationBuilder.DropIndex(
                name: "IX_Provinces_AddressID",
                table: "Provinces");

            migrationBuilder.DropColumn(
                name: "AddressID",
                table: "Provinces");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_ProvinceID",
                table: "Addresses",
                column: "ProvinceID");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Provinces_ProvinceID",
                table: "Addresses",
                column: "ProvinceID",
                principalTable: "Provinces",
                principalColumn: "ProvinceID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Provinces_ProvinceID",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_ProvinceID",
                table: "Addresses");

            migrationBuilder.AddColumn<int>(
                name: "AddressID",
                table: "Provinces",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Provinces_AddressID",
                table: "Provinces",
                column: "AddressID");

            migrationBuilder.AddForeignKey(
                name: "FK_Provinces_Addresses_AddressID",
                table: "Provinces",
                column: "AddressID",
                principalTable: "Addresses",
                principalColumn: "AddressID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
