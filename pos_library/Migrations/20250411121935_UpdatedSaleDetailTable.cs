using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pos_library.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedSaleDetailTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "product_id",
                table: "SaleDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "quantity",
                table: "SaleDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "sale_id",
                table: "SaleDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "unit_price",
                table: "SaleDetail",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateIndex(
                name: "IX_SaleDetail_product_id",
                table: "SaleDetail",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_SaleDetail_sale_id",
                table: "SaleDetail",
                column: "sale_id");

            migrationBuilder.AddForeignKey(
                name: "FK_SaleDetail_Product_product_id",
                table: "SaleDetail",
                column: "product_id",
                principalTable: "Product",
                principalColumn: "product_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleDetail_Sale_sale_id",
                table: "SaleDetail",
                column: "sale_id",
                principalTable: "Sale",
                principalColumn: "sale_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SaleDetail_Product_product_id",
                table: "SaleDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleDetail_Sale_sale_id",
                table: "SaleDetail");

            migrationBuilder.DropIndex(
                name: "IX_SaleDetail_product_id",
                table: "SaleDetail");

            migrationBuilder.DropIndex(
                name: "IX_SaleDetail_sale_id",
                table: "SaleDetail");

            migrationBuilder.DropColumn(
                name: "product_id",
                table: "SaleDetail");

            migrationBuilder.DropColumn(
                name: "quantity",
                table: "SaleDetail");

            migrationBuilder.DropColumn(
                name: "sale_id",
                table: "SaleDetail");

            migrationBuilder.DropColumn(
                name: "unit_price",
                table: "SaleDetail");
        }
    }
}
