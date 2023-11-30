using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Migrations
{
    /// <inheritdoc />
    public partial class NEW8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Checkout_Checkout_CheckoutId1",
                table: "Checkout");

            migrationBuilder.DropColumn(
                name: "CheckoutId1",
                table: "Checkout");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CheckoutId1",
                table: "Checkout",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Checkout_Checkout_CheckoutId1",
                table: "Checkout",
                column: "CheckoutId1",
                principalTable: "Checkout",
                principalColumn: "CheckoutId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
