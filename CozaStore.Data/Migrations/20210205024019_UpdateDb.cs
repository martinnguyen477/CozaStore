namespace CozaStore.Data.Migrations
{
    using System;
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class UpdateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "BillDate",
                table: "OrderDetail");

            migrationBuilder.DropColumn(
                name: "Discount",
                table: "OrderDetail");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "OrderDetail");

            migrationBuilder.DropColumn(
                name: "OrderShipAddress",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "OrderShipPhone",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "ShipDate",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Contact");

            migrationBuilder.AddColumn<int>(
                name: "Orders",
                table: "Topic",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "Topic",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Slide",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "Slide",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Product",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Product",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PriceSale",
                table: "Product",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "ProductDetail",
                table: "Product",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Post",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Detail",
                table: "Post",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ShipAddress",
                table: "Order",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ShipEmail",
                table: "Order",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ShipPhone",
                table: "Order",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Contact",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Message",
                table: "Contact",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Contact",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Orders",
                table: "Category",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "Category",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FullName", "Message", "PhoneNumber" },
                values: new object[] { "Nguyễn Quốc Cường", "Yêu cầu cửa hàng thêm quần áo", "0377077630" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FullName", "Message", "PhoneNumber" },
                values: new object[] { "Nguyễn Quốc Khánh", "Yêu cầu cửa hàng thêm quần áo", "0377077630" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FullName", "Message", "PhoneNumber" },
                values: new object[] { "Nguyễn Quốc Duy", "Yêu cầu cửa hàng thêm quần áo", "0377077630" });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ShipAddress", "ShipEmail", "ShipPhone" },
                values: new object[] { "351A Lạc Long Quân P5 Quận 11 TP.Hồ Chí Minh", "nqcuong720@gmail.com", "0377077630" });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ShipAddress", "ShipEmail", "ShipPhone" },
                values: new object[] { "351A Lạc Long Quân P5 Quận 11 TP.Hồ Chí Minh", "nqcuong720@gmail.com", "0377077630" });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ShipAddress", "ShipEmail", "ShipPhone" },
                values: new object[] { "351A Lạc Long Quân P5 Quận 11 TP.Hồ Chí Minh", "nqcuong720@gmail.com", "0377077630" });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ShipAddress", "ShipEmail", "ShipPhone" },
                values: new object[] { "351A Lạc Long Quân P5 Quận 11 TP.Hồ Chí Minh", "nqcuong720@gmail.com", "0377077630" });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ShipAddress", "ShipEmail", "ShipPhone" },
                values: new object[] { "351A Lạc Long Quân P5 Quận 11 TP.Hồ Chí Minh", "nqcuong720@gmail.com", "0377077630" });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ShipAddress", "ShipEmail", "ShipPhone" },
                values: new object[] { "351A Lạc Long Quân P5 Quận 11 TP.Hồ Chí Minh", "nqcuong720@gmail.com", "0377077630" });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "Detail",
                value: "Mừng xuân, mừng đảng");

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2,
                column: "Detail",
                value: "Mừng giáng sinh");

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 3,
                column: "Detail",
                value: "Mừng khai trương");

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 4,
                column: "Detail",
                value: "Siêu giảm giá !");

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 5,
                column: "Detail",
                value: "Ngày quốc tế phụ nữ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Orders",
                table: "Topic");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Topic");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Slide");

            migrationBuilder.DropColumn(
                name: "Order",
                table: "Slide");

            migrationBuilder.DropColumn(
                name: "PriceSale",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ProductDetail",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Detail",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "ShipAddress",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "ShipEmail",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "ShipPhone",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "Message",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "Orders",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Category");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Post",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Post",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BillDate",
                table: "OrderDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Discount",
                table: "OrderDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Total",
                table: "OrderDetail",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "OrderShipAddress",
                table: "Order",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OrderShipPhone",
                table: "Order",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "ShipDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Contact",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Yêu cầu cửa hàng thêm quần áo");

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Yêu cầu cửa hàng thêm quần áo");

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Yêu cầu cửa hàng thêm quần áo");

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "OrderShipAddress", "OrderShipPhone", "ShipDate" },
                values: new object[] { "351A Lạc Long Quân P5 Quận 11 TP.Hồ Chí Minh", "0377077630", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "OrderShipAddress", "OrderShipPhone", "ShipDate" },
                values: new object[] { "351A Lạc Long Quân P5 Quận 11 TP.Hồ Chí Minh", "0377077630", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "OrderShipAddress", "OrderShipPhone", "ShipDate" },
                values: new object[] { "351A Lạc Long Quân P5 Quận 11 TP.Hồ Chí Minh", "0377077630", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "OrderShipAddress", "OrderShipPhone", "ShipDate" },
                values: new object[] { "351A Lạc Long Quân P5 Quận 11 TP.Hồ Chí Minh", "0377077630", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "OrderShipAddress", "OrderShipPhone", "ShipDate" },
                values: new object[] { "351A Lạc Long Quân P5 Quận 11 TP.Hồ Chí Minh", "0377077630", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "OrderShipAddress", "OrderShipPhone", "ShipDate" },
                values: new object[] { "351A Lạc Long Quân P5 Quận 11 TP.Hồ Chí Minh", "0377077630", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BillDate", "Discount", "Total" },
                values: new object[] { new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 9000000m });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BillDate", "Discount", "Total" },
                values: new object[] { new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 9000000m });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BillDate", "Discount", "Total" },
                values: new object[] { new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 9000000m });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BillDate", "Discount", "Total" },
                values: new object[] { new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 9000000m });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BillDate", "Discount", "Total" },
                values: new object[] { new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 9000000m });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BillDate", "Discount", "Total" },
                values: new object[] { new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 9000000m });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BillDate", "Discount", "Total" },
                values: new object[] { new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 9000000m });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Mừng xuân, mừng đảng");

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Mừng giáng sinh");

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Mừng khai trương");

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Siêu giảm giá !");

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "Ngày quốc tế phụ nữ");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Color", "Size" },
                values: new object[] { "Black", "XS" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Color", "Size" },
                values: new object[] { "Black", "XS" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Color", "Size" },
                values: new object[] { "Black", "XS" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Color", "Size" },
                values: new object[] { "Black", "XS" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Color", "Size" },
                values: new object[] { "Black", "XS" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Color", "Size" },
                values: new object[] { "Black", "XS" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Color", "Size" },
                values: new object[] { "Black", "XS" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Color", "Size" },
                values: new object[] { "Black", "XS" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Color", "Size" },
                values: new object[] { "Black", "XS" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Color", "Size" },
                values: new object[] { "Black", "XS" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Color", "Size" },
                values: new object[] { "Black", "XS" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Color", "Size" },
                values: new object[] { "Black", "XS" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Color", "Size" },
                values: new object[] { "Black", "XS" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Color", "Size" },
                values: new object[] { "Black", "XS" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Color", "Size" },
                values: new object[] { "Black", "XS" });
        }
    }
}
