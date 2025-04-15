using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pos_library.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedSaleTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "customer_id",
                table: "Sale",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "employee_id",
                table: "Sale",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "sale_date",
                table: "Sale",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "total_amount",
                table: "Sale",
                type: "decimal(6,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateIndex(
                name: "IX_Sale_customer_id",
                table: "Sale",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_Sale_employee_id",
                table: "Sale",
                column: "employee_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sale_Customers_customer_id",
                table: "Sale",
                column: "customer_id",
                principalTable: "Customers",
                principalColumn: "customer_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sale_Employee_employee_id",
                table: "Sale",
                column: "employee_id",
                principalTable: "Employee",
                principalColumn: "employee_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sale_Customers_customer_id",
                table: "Sale");

            migrationBuilder.DropForeignKey(
                name: "FK_Sale_Employee_employee_id",
                table: "Sale");

            migrationBuilder.DropIndex(
                name: "IX_Sale_customer_id",
                table: "Sale");

            migrationBuilder.DropIndex(
                name: "IX_Sale_employee_id",
                table: "Sale");

            migrationBuilder.DropColumn(
                name: "customer_id",
                table: "Sale");

            migrationBuilder.DropColumn(
                name: "employee_id",
                table: "Sale");

            migrationBuilder.DropColumn(
                name: "sale_date",
                table: "Sale");

            migrationBuilder.DropColumn(
                name: "total_amount",
                table: "Sale");
        }
    }
}
