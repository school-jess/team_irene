using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pos_library.Migrations
{
    /// <inheritdoc />
    public partial class MatchedCodeToERD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // this was me
            // migrationBuilder.RenameColumn(
            //     name: "sales_detail_id",
            //     table: "SaleDetail",
            //     newName: "sale_detail_id");

            migrationBuilder.AlterColumn<decimal>(
                name: "unit_price",
                table: "SaleDetail",
                type: "decimal(6,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "sale_date",
                table: "Sale",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2025, 4, 13, 13, 33, 52, 765, DateTimeKind.Local).AddTicks(8223),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "Product",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2025, 4, 13, 13, 33, 52, 766, DateTimeKind.Local).AddTicks(3030));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "Inventory",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2025, 4, 13, 13, 33, 52, 766, DateTimeKind.Local).AddTicks(4831),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "Employee",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2025, 4, 13, 13, 33, 52, 766, DateTimeKind.Local).AddTicks(1173),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "Customer",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "04/13/2025 13:33:52",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255);

            migrationBuilder.CreateIndex(
                name: "IX_Customer_email",
                table: "Customer",
                column: "email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Customer_email",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "created_at",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "sale_detail_id",
                table: "SaleDetail",
                newName: "sales_detail_id");

            migrationBuilder.AlterColumn<decimal>(
                name: "unit_price",
                table: "SaleDetail",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,2)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "sale_date",
                table: "Sale",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2025, 4, 13, 13, 33, 52, 765, DateTimeKind.Local).AddTicks(8223));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "Inventory",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2025, 4, 13, 13, 33, 52, 766, DateTimeKind.Local).AddTicks(4831));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "Employee",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2025, 4, 13, 13, 33, 52, 766, DateTimeKind.Local).AddTicks(1173));

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "Customer",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255,
                oldDefaultValue: "04/13/2025 13:33:52");
        }
    }
}
