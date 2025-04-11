using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pos_library.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedCustomerTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "Customers",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Customers",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "first_name",
                table: "Customers",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "last_name",
                table: "Customers",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "phone_number",
                table: "Customers",
                type: "varchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "created_at",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "email",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "first_name",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "last_name",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "phone_number",
                table: "Customers");
        }
    }
}
