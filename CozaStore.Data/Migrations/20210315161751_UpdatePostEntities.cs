using Microsoft.EntityFrameworkCore.Migrations;

namespace CozaStore.Data.Migrations
{
    public partial class UpdatePostEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Detail",
                table: "Post");

            migrationBuilder.AddColumn<string>(
                name: " Description",
                table: "Post",
                nullable: false,
                defaultValue: " ");

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: " Description",
                value: "Mừng xuân, mừng đảng");

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2,
                column: " Description",
                value: "Mừng giáng sinh");

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 3,
                column: " Description",
                value: "Mừng khai trương");

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 4,
                column: " Description",
                value: "Siêu giảm giá !");

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 5,
                column: " Description",
                value: "Ngày quốc tế phụ nữ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: " Description",
                table: "Post");

            migrationBuilder.AddColumn<string>(
                name: "Detail",
                table: "Post",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: " ");

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
    }
}
