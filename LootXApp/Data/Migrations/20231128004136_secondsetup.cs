using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LootXApp.Data.Migrations
{
    public partial class secondsetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_Inventory_CheckoutInventoryId1",
                table: "Inventory");

            migrationBuilder.DropIndex(
                name: "IX_Inventory_CheckoutInventoryId1",
                table: "Inventory");

            migrationBuilder.DropColumn(
                name: "CheckoutInventoryId",
                table: "Inventory");

            migrationBuilder.DropColumn(
                name: "CheckoutInventoryId1",
                table: "Inventory");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Inventory");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Inventory");

            migrationBuilder.CreateTable(
                name: "Checkout",
                columns: table => new
                {
                    CheckoutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InventoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InventoryPic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InventoryPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checkout", x => x.CheckoutId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Checkout");

            migrationBuilder.AddColumn<int>(
                name: "CheckoutInventoryId",
                table: "Inventory",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CheckoutInventoryId1",
                table: "Inventory",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Inventory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Inventory",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_CheckoutInventoryId1",
                table: "Inventory",
                column: "CheckoutInventoryId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_Inventory_CheckoutInventoryId1",
                table: "Inventory",
                column: "CheckoutInventoryId1",
                principalTable: "Inventory",
                principalColumn: "InventoryId");
        }
    }
}