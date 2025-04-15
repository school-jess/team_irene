using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pos_library.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedInventoryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "last_updated",
                table: "Inventory",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "product_id",
                table: "Inventory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "quantity",
                table: "Inventory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_product_id",
                table: "Inventory",
                column: "product_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_Product_product_id",
                table: "Inventory",
                column: "product_id",
                principalTable: "Product",
                principalColumn: "product_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_Product_product_id",
                table: "Inventory");

            migrationBuilder.DropIndex(
                name: "IX_Inventory_product_id",
                table: "Inventory");

            migrationBuilder.DropColumn(
                name: "last_updated",
                table: "Inventory");

            migrationBuilder.DropColumn(
                name: "product_id",
                table: "Inventory");

            migrationBuilder.DropColumn(
                name: "quantity",
                table: "Inventory");
        }
    }
}
