// <copyright file="20210125145601_UpdatePrice.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.Data.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class UpdatePrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Product",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "Total",
                table: "OrderDetail",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "Quantity",
                table: "OrderDetail",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "OrderDetail",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Price", "Quantity", "Total" },
                values: new object[] { 45000000m, 2m, 9000000m });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Price", "Quantity", "Total" },
                values: new object[] { 45000000m, 2m, 9000000m });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Price", "Quantity", "Total" },
                values: new object[] { 45000000m, 2m, 9000000m });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Price", "Quantity", "Total" },
                values: new object[] { 45000000m, 2m, 9000000m });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Price", "Quantity", "Total" },
                values: new object[] { 45000000m, 2m, 9000000m });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Price", "Quantity", "Total" },
                values: new object[] { 45000000m, 2m, 9000000m });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Price", "Quantity", "Total" },
                values: new object[] { 45000000m, 2m, 9000000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: 480000m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "Price",
                value: 310000m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "Price",
                value: 190000m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "Price",
                value: 490000m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "Price",
                value: 390000m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                column: "Price",
                value: 190000m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                column: "Price",
                value: 940000m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                column: "Price",
                value: 510000m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                column: "Price",
                value: 220000m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                column: "Price",
                value: 790000m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                column: "Price",
                value: 19000m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                column: "Price",
                value: 690000m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                column: "Price",
                value: 850000m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                column: "Price",
                value: 1390000m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                column: "Price",
                value: 899000m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Price",
                table: "Product",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "Total",
                table: "OrderDetail",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "OrderDetail",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<float>(
                name: "Price",
                table: "OrderDetail",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Price", "Quantity", "Total" },
                values: new object[] { 45000000f, 2, 9000000 });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Price", "Quantity", "Total" },
                values: new object[] { 45000000f, 2, 9000000 });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Price", "Quantity", "Total" },
                values: new object[] { 45000000f, 2, 9000000 });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Price", "Quantity", "Total" },
                values: new object[] { 45000000f, 2, 9000000 });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Price", "Quantity", "Total" },
                values: new object[] { 45000000f, 2, 9000000 });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Price", "Quantity", "Total" },
                values: new object[] { 45000000f, 2, 9000000 });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Price", "Quantity", "Total" },
                values: new object[] { 45000000f, 2, 9000000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: 480000f);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "Price",
                value: 310000f);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "Price",
                value: 190000f);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "Price",
                value: 490000f);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "Price",
                value: 390000f);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                column: "Price",
                value: 190000f);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                column: "Price",
                value: 940000f);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                column: "Price",
                value: 510000f);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                column: "Price",
                value: 220000f);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                column: "Price",
                value: 790000f);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                column: "Price",
                value: 19000f);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                column: "Price",
                value: 690000f);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                column: "Price",
                value: 850000f);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                column: "Price",
                value: 1390000f);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                column: "Price",
                value: 899000f);
        }
    }
}
