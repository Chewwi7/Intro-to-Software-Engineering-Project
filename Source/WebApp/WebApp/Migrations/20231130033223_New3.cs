using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Migrations
{
    /// <inheritdoc />
    public partial class New3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Sales",
                newName: "ZipCode");

            migrationBuilder.AddColumn<string>(
                name: "CityName",
                table: "Sales",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "InventoryId",
                table: "Sales",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "StateName",
                table: "Sales",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StreetName",
                table: "Sales",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_InventoryId",
                table: "Sales",
                column: "InventoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Inventory_InventoryId",
                table: "Sales",
                column: "InventoryId",
                principalTable: "Inventory",
                principalColumn: "InventoryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Inventory_InventoryId",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_InventoryId",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "CityName",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "InventoryId",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "StateName",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "StreetName",
                table: "Sales");

            migrationBuilder.RenameColumn(
                name: "ZipCode",
                table: "Sales",
                newName: "Address");
        }
    }
}
