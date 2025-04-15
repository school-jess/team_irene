using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pos_library.Migrations
{
    /// <inheritdoc />
    public partial class ChangedTimestampDefaultValue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "sale_date",
                table: "Sale",
                type: "timestamp",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2025, 4, 13, 13, 33, 52, 765, DateTimeKind.Local).AddTicks(8223));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "Product",
                type: "timestamp",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2025, 4, 13, 13, 33, 52, 766, DateTimeKind.Local).AddTicks(3030));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "Inventory",
                type: "timestamp",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2025, 4, 13, 13, 33, 52, 766, DateTimeKind.Local).AddTicks(4831));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "Employee",
                type: "timestamp",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "Customer",
                type: "timestamp",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "sale_date",
                table: "Sale",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2025, 4, 13, 13, 33, 52, 765, DateTimeKind.Local).AddTicks(8223),
                oldClrType: typeof(DateTime),
                oldType: "timestamp",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "Product",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2025, 4, 13, 13, 33, 52, 766, DateTimeKind.Local).AddTicks(3030),
                oldClrType: typeof(DateTime),
                oldType: "timestamp",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "Inventory",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2025, 4, 13, 13, 33, 52, 766, DateTimeKind.Local).AddTicks(4831),
                oldClrType: typeof(DateTime),
                oldType: "timestamp",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "Employee",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2025, 4, 13, 13, 33, 52, 766, DateTimeKind.Local).AddTicks(1173),
                oldClrType: typeof(DateTime),
                oldType: "timestamp",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

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

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "Customer",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp");
        }
    }
}
