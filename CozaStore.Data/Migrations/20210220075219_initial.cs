using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CozaStore.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<int>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    CategoryName = table.Column<string>(nullable: false),
                    ParentId = table.Column<int>(nullable: false),
                    Orders = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<int>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    FullName = table.Column<string>(maxLength: 200, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 20, nullable: false),
                    ContactTitle = table.Column<string>(nullable: false),
                    Message = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<int>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false),
                    ShipAddress = table.Column<string>(nullable: false),
                    ShipPhone = table.Column<string>(nullable: false),
                    ShipEmail = table.Column<string>(nullable: false),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    Note = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<int>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<int>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    PostTitle = table.Column<string>(nullable: false),
                    Topic = table.Column<int>(nullable: false),
                    Image = table.Column<string>(nullable: false),
                    Detail = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<int>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    ProductDetail = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PriceSale = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SupplierId = table.Column<int>(nullable: false),
                    Image = table.Column<string>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Access = table.Column<int>(nullable: false),
                    AccessName = table.Column<string>(nullable: true),
                    Decription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Slide",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<int>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    SlideName = table.Column<string>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    Order = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slide", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<int>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    SupplierName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Topic",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<int>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    TopicName = table.Column<string>(nullable: false),
                    ParentId = table.Column<int>(nullable: false),
                    Orders = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topic", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<int>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    Sex = table.Column<string>(nullable: false),
                    Birthday = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Access = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CategoryName", "CreateBy", "CreateDate", "Orders", "ParentId", "Status", "UpdateBy", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "Collections Woman", 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Collections Man", 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Collections Children", 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Contact",
                columns: new[] { "Id", "ContactTitle", "CreateBy", "CreateDate", "Email", "FullName", "Message", "PhoneNumber", "Status", "UpdateBy", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "Tư Vấn", 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nqcuong720@gmail.com", "Nguyễn Quốc Cường", "Yêu cầu cửa hàng thêm quần áo", "0377077630", 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Phản Hồi", 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nqcuong720@gmail.com", "Nguyễn Quốc Khánh", "Yêu cầu cửa hàng thêm quần áo", "0377077630", 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Khiển Trách", 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nqcuong720@gmail.com", "Nguyễn Quốc Duy", "Yêu cầu cửa hàng thêm quần áo", "0377077630", 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "Id", "CreateBy", "CreateDate", "Note", "OrderDate", "ShipAddress", "ShipEmail", "ShipPhone", "Status", "UpdateBy", "UpdateDate", "UserID" },
                values: new object[,]
                {
                    { 6, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "None", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "351A Lạc Long Quân P5 Quận 11 TP.Hồ Chí Minh", "nqcuong720@gmail.com", "0377077630", 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 5, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "None", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "351A Lạc Long Quân P5 Quận 11 TP.Hồ Chí Minh", "nqcuong720@gmail.com", "0377077630", 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 4, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "None", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "351A Lạc Long Quân P5 Quận 11 TP.Hồ Chí Minh", "nqcuong720@gmail.com", "0377077630", 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "None", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "351A Lạc Long Quân P5 Quận 11 TP.Hồ Chí Minh", "nqcuong720@gmail.com", "0377077630", 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "None", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "351A Lạc Long Quân P5 Quận 11 TP.Hồ Chí Minh", "nqcuong720@gmail.com", "0377077630", 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 3, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "None", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "351A Lạc Long Quân P5 Quận 11 TP.Hồ Chí Minh", "nqcuong720@gmail.com", "0377077630", 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 }
                });

            migrationBuilder.InsertData(
                table: "OrderDetail",
                columns: new[] { "Id", "CreateBy", "CreateDate", "OrderId", "Price", "ProductId", "Quantity", "Status", "UpdateBy", "UpdateDate" },
                values: new object[,]
                {
                    { 7, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 45000000m, 12, 2, 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 45000000m, 5, 2, 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 45000000m, 2, 2, 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 45000000m, 4, 2, 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 45000000m, 3, 2, 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 45000000m, 1, 2, 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 45000000m, 4, 2, 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "Id", "CreateBy", "CreateDate", "Detail", "Image", "PostTitle", "Status", "Topic", "UpdateBy", "UpdateDate" },
                values: new object[,]
                {
                    { 5, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ngày quốc tế phụ nữ", "images/post/hinh.jpg", "Khuyễn mãi nhân ngày 8-3", 1, 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Siêu giảm giá !", "images/post/hinh.jpg", "Black Friday", 1, 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mừng khai trương", "images/post/hinh.jpg", "Giảm giá 50%", 1, 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mừng xuân, mừng đảng", "images/post/hinh.jpg", "Khuyến mãi Tết Tân Sửu", 1, 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mừng giáng sinh", "images/post/hinh.jpg", "Lễ Giang Sinh", 1, 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "CreateBy", "CreateDate", "Image", "Price", "PriceSale", "Description", "ProductDetail", "ProductName", "Quantity", "Status", "SupplierId", "UpdateBy", "UpdateDate" },
                values: new object[,]
                {
                    { 10, 2, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "images/product/men/aokhoacadidas.jpg", 790000m, 0m, "Áo thời trang mùa đông", null, "Áo khoác nam", 150, 1, 3, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 2, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "images/product/men/aokhoacadidas.jpg", 899000m, 0m, "Áo thời trang mùa đông", null, "Giày Bitis Hunter X 2021", 150, 1, 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "images/product/men/aokhoacadidas.jpg", 1390000m, 0m, "Áo thời trang mùa đông", null, "Váy Elise", 150, 1, 2, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 2, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "images/product/men/aokhoacadidas.jpg", 850000m, 0m, "Áo thời trang mùa đông", null, "Quần tay công sở", 150, 1, 3, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 3, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "images/product/men/aokhoacadidas.jpg", 690000m, 0m, "Áo thời trang mùa đông", null, "Áo khoác trẻ em Nike", 150, 1, 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 2, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "images/product/men/aokhoacadidas.jpg", 19000m, 0m, "Áo thời trang mùa đông", null, "Tất nữ", 150, 1, 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 3, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "images/product/men/aokhoacadidas.jpg", 220000m, 0m, "Áo thời trang mùa đông", null, "Dép Bitis", 150, 1, 4, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 3, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "images/product/men/aokhoacadidas.jpg", 190000m, 0m, "Áo thời trang mùa đông", null, "Quần thể thao trẻ em Adidas", 150, 1, 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 2, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "images/product/men/aokhoacadidas.jpg", 940000m, 0m, "Áo thời trang mùa đông", null, "Giày thể thao - Nam ", 150, 1, 3, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "images/product/men/aokhoacadidas.jpg", 390000m, 0m, "Áo thời trang mùa đông", null, "Quần thể thao nữ Adidas", 150, 1, 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 2, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "images/product/men/aokhoacadidas.jpg", 490000m, 0m, "Áo thời trang mùa đông", null, "Quần thể thao nam Adidas", 150, 1, 2, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "images/product/men/aokhoacadidas.jpg", 190000m, 0m, "Áo thời trang mùa đông", null, "Áo thể thao trẻ em Adidas", 150, 1, 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "images/product/men/aokhoacadidas.jpg", 310000m, 0m, "Áo thời trang mùa đông", null, "Áo thể thao nữ Adidas", 150, 1, 4, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 2, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "images/product/men/aokhoacadidas.jpg", 480000m, 0m, "Áo thời trang mùa đông", null, "Áo thể thao nam Adidas", 150, 1, 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "images/product/men/aokhoacadidas.jpg", 510000m, 0m, "Áo thời trang mùa đông", null, "Guốc Juno", 150, 1, 2, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "Access", "AccessName", "Decription" },
                values: new object[,]
                {
                    { 1, 0, "ADMIN", "Admin" },
                    { 2, 1, "Customer", "Customer" },
                    { 3, 2, "Sale", "Sale" },
                    { 4, 3, "Manager", "Manager" }
                });

            migrationBuilder.InsertData(
                table: "Slide",
                columns: new[] { "Id", "CreateBy", "CreateDate", "Image", "Order", "SlideName", "Status", "UpdateBy", "UpdateDate" },
                values: new object[,]
                {
                    { 5, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "Ngày nhà giáo Việt Nam", 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "Black Friday", 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "Khuyễn mãi Tết Tân Sửu", 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "Khuyễn mãi Noel", 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "Khuyễn mãi Ngày quốc tế Phụ nữ 8-3", 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Supplier",
                columns: new[] { "Id", "CreateBy", "CreateDate", "Status", "SupplierName", "UpdateBy", "UpdateDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Bitis", 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Adidas", 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Juno", 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Elise", 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Topic",
                columns: new[] { "Id", "CreateBy", "CreateDate", "Orders", "ParentId", "Status", "TopicName", "UpdateBy", "UpdateDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, 1, "Thời trang", 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, 1, "Thời trang mùa đông", 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, 1, "Thời trang mùa hè", 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, 1, "Thời trang Noel", 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Access", "Address", "Birthday", "CreateBy", "CreateDate", "Email", "FirstName", "LastName", "Password", "Phone", "Sex", "Status", "UpdateBy", "UpdateDate", "UserName" },
                values: new object[,]
                {
                    { 3, 1, "280A Lạc Long Quân Phường 5 Quận 11 TP Hồ Chí Minh", "2000-07-13", 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nqduy@gmail.com", "Duy", "Nguyễn", "nqduy", "0971561612", "Nam", 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nqduy" },
                    { 1, 0, "64 Cách Mạng Tháng 8 Phường 5 Quận 11 TP Hồ Chí Minh", "2000-07-13", 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nqcuong720@gmail.com", "Cường", "Nguyễn", "nqcuong720720", "0377077630", "Nam", 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nqcuong720" },
                    { 2, 1, "128A An Dương Vương Phường 5 Quận 11 TP Hồ Chí Minh", "2000-07-13", 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nqhai@gmail.com", "Hải", "Nguyễn", "nqhai720720", "0377077630", "Nam", 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nqhai720" },
                    { 4, 2, "351A Lạc Long Quân Phường 5 Quận 11 TP Hồ Chí Minh", "2000-07-13", 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nqkhanh@gmail.com", "Khánh", "Nguyễn", "nqkhanh", "097123561", "Nam", 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nqkhanh" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Slide");

            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.DropTable(
                name: "Topic");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
