// <copyright file="ModelBuilderExtentions.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.Data.SeedDataDefault
{
    using System;
    using CozaStore.Model.EntitiesModel;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// SeedDataDefault.
    /// </summary>
    public static class ModelBuilderExtentions
    {
        public static void SeedDataDefault(this ModelBuilder modelbuilder)
        {
            DateTime dateTime = new DateTime(2021, 01, 01);
            modelbuilder.Entity<CategoryEntities>().HasData(
               new CategoryEntities { Id = 1, CategoryName = "Collections Woman", Status = 1, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
               new CategoryEntities { Id = 2, CategoryName = "Collections Man", Status = 1, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
               new CategoryEntities { Id = 3, CategoryName = "Collections Children", Status = 1, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime });

            modelbuilder.Entity<ContactEntities>().HasData(
                new ContactEntities { Id = 1, FullName = "Nguyễn Quốc Cường", PhoneNumber = "0377077630", ContactTitle = "Tư Vấn", Email = "nqcuong720@gmail.com", Message = "Yêu cầu cửa hàng thêm quần áo", Status = 1, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
                new ContactEntities { Id = 2, FullName = "Nguyễn Quốc Khánh", PhoneNumber = "0377077630", ContactTitle = "Phản Hồi", Email = "nqcuong720@gmail.com", Message = "Yêu cầu cửa hàng thêm quần áo", Status = 1, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
                new ContactEntities { Id = 3, FullName = "Nguyễn Quốc Duy", PhoneNumber = "0377077630", ContactTitle = "Khiển Trách", Email = "nqcuong720@gmail.com", Message = "Yêu cầu cửa hàng thêm quần áo", Status = 1, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime });
            modelbuilder.Entity<OrderEntities>().HasData(
                new OrderEntities { Id = 1, UserId = 1, OrderDate = dateTime, ShipPhone = "0377077630", ShipAdsress = "351A Lạc Long Quân P5 Quận 11 TP.Hồ Chí Minh", ShipEmail = "nqcuong720@gmail.com", Note = "None", Status = 1, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
                new OrderEntities { Id = 2, UserId = 2, OrderDate = dateTime, ShipPhone = "0377077630", ShipAdsress = "351A Lạc Long Quân P5 Quận 11 TP.Hồ Chí Minh", ShipEmail = "nqcuong720@gmail.com", Note = "None", Status = 1, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
                new OrderEntities { Id = 3, UserId = 3, OrderDate = dateTime, ShipPhone = "0377077630", ShipAdsress = "351A Lạc Long Quân P5 Quận 11 TP.Hồ Chí Minh", ShipEmail = "nqcuong720@gmail.com", Note = "None", Status = 1, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
                new OrderEntities { Id = 4, UserId = 1, OrderDate = dateTime, ShipPhone = "0377077630", ShipAdsress = "351A Lạc Long Quân P5 Quận 11 TP.Hồ Chí Minh", ShipEmail = "nqcuong720@gmail.com", Note = "None", Status = 1, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
                new OrderEntities { Id = 5, UserId = 3, OrderDate = dateTime, ShipPhone = "0377077630", ShipAdsress = "351A Lạc Long Quân P5 Quận 11 TP.Hồ Chí Minh", ShipEmail = "nqcuong720@gmail.com", Note = "None", Status = 1, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
                new OrderEntities { Id = 6, UserId = 4, OrderDate = dateTime, ShipPhone = "0377077630", ShipAdsress = "351A Lạc Long Quân P5 Quận 11 TP.Hồ Chí Minh", ShipEmail = "nqcuong720@gmail.com", Note = "None", Status = 1, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime });
            modelbuilder.Entity<OrderDetailEntities>().HasData(
                new OrderDetailEntities { Id = 1, OrderId = 1, ProductId = 1, Price = 45000000, Quantity = 2,  Status = 1, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
                new OrderDetailEntities { Id = 2, OrderId = 2, ProductId = 3, Price = 45000000, Quantity = 2,  Status = 1, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
                new OrderDetailEntities { Id = 3, OrderId = 3, ProductId = 4, Price = 45000000, Quantity = 2, Status = 1, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
                new OrderDetailEntities { Id = 4, OrderId = 3, ProductId = 2, Price = 45000000, Quantity = 2,  Status = 1, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
                new OrderDetailEntities { Id = 5, OrderId = 4, ProductId = 5, Price = 45000000, Quantity = 2,  Status = 1, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
                new OrderDetailEntities { Id = 6, OrderId = 5, ProductId = 4, Price = 45000000, Quantity = 2,  Status = 1, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
                new OrderDetailEntities { Id = 7, OrderId = 6, ProductId = 12, Price = 45000000, Quantity = 2,  Status = 1, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime });
            modelbuilder.Entity<PostEntities>().HasData(
                new PostEntities { Id = 1, PostTitle = "Khuyến mãi Tết Tân Sửu", Detail = "Mừng xuân, mừng đảng", TopicId = 1, Image = "images/post/hinh.jpg", Status = 1, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
                new PostEntities { Id = 2, PostTitle = "Lễ Giang Sinh", Detail = "Mừng giáng sinh", TopicId = 1, Image = "images/post/hinh.jpg", Status = 1, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
                new PostEntities { Id = 3, PostTitle = "Giảm giá 50%", Detail = "Mừng khai trương", TopicId = 1, Image = "images/post/hinh.jpg", Status = 1, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
                new PostEntities { Id = 4, PostTitle = "Black Friday", Detail = "Siêu giảm giá !", TopicId = 1, Image = "images/post/hinh.jpg", Status = 1, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
                new PostEntities { Id = 5, PostTitle = "Khuyễn mãi nhân ngày 8-3", Detail = "Ngày quốc tế phụ nữ", TopicId = 1, Image = "images/post/hinh.jpg", Status = 1, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime });
            modelbuilder.Entity<ProductEntities>().HasData(
                new ProductEntities { Id = 1, ProductName = "Áo thể thao nam Adidas", CategoryId = 2, Price = 480000, Quantity = 150,  ProductDescription = "Áo thời trang mùa đông", SupplierId = 1, Image = "images/product/men/aokhoacadidas.jpg", Status = 1, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
                new ProductEntities { Id = 2, ProductName = "Áo thể thao nữ Adidas", CategoryId = 1, Price = 310000, Quantity = 150,  ProductDescription = "Áo thời trang mùa đông", SupplierId = 4, Image = "images/product/men/aokhoacadidas.jpg", Status = 1, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
                new ProductEntities { Id = 3, ProductName = "Áo thể thao trẻ em Adidas", CategoryId = 3, Price = 190000, Quantity = 150, ProductDescription = "Áo thời trang mùa đông", SupplierId = 1, Image = "images/product/men/aokhoacadidas.jpg", Status = 1, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
                new ProductEntities { Id = 4, ProductName = "Quần thể thao nam Adidas", CategoryId = 2, Price = 490000, Quantity = 150,  ProductDescription = "Áo thời trang mùa đông", SupplierId = 2, Image = "images/product/men/aokhoacadidas.jpg", Status = 1, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
                new ProductEntities { Id = 5, ProductName = "Quần thể thao nữ Adidas", CategoryId = 1, Price = 390000, Quantity = 150,  ProductDescription = "Áo thời trang mùa đông", SupplierId = 1, Image = "images/product/men/aokhoacadidas.jpg", Status = 1, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
                new ProductEntities { Id = 6, ProductName = "Quần thể thao trẻ em Adidas", CategoryId = 3, Price = 190000, Quantity = 150,  ProductDescription = "Áo thời trang mùa đông", SupplierId = 1, Image = "images/product/men/aokhoacadidas.jpg", Status = 1, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
                new ProductEntities { Id = 7, ProductName = "Giày thể thao - Nam ", CategoryId = 2, Price = 940000, Quantity = 150,  ProductDescription = "Áo thời trang mùa đông", SupplierId = 3, Image = "images/product/men/aokhoacadidas.jpg", Status = 1, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
                new ProductEntities { Id = 8, ProductName = "Guốc Juno", CategoryId = 1, Price = 510000, Quantity = 150,  ProductDescription = "Áo thời trang mùa đông", SupplierId = 2, Image = "images/product/men/aokhoacadidas.jpg", Status = 1, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
                new ProductEntities { Id = 9, ProductName = "Dép Bitis", CategoryId = 3, Price = 220000, Quantity = 150,  ProductDescription = "Áo thời trang mùa đông", SupplierId = 4, Image = "images/product/men/aokhoacadidas.jpg", Status = 1, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
                new ProductEntities { Id = 10, ProductName = "Áo khoác nam", CategoryId = 2, Price = 790000, Quantity = 150,  ProductDescription = "Áo thời trang mùa đông", SupplierId = 3, Image = "images/product/men/aokhoacadidas.jpg", Status = 1, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
                new ProductEntities { Id = 11, ProductName = "Tất nữ", CategoryId = 2, Price = 19000, Quantity = 150, ProductDescription = "Áo thời trang mùa đông", SupplierId = 1, Image = "images/product/men/aokhoacadidas.jpg", Status = 1, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
                new ProductEntities { Id = 12, ProductName = "Áo khoác trẻ em Nike", CategoryId = 3, Price = 690000, Quantity = 150,  ProductDescription = "Áo thời trang mùa đông", SupplierId = 1, Image = "images/product/men/aokhoacadidas.jpg", Status = 1, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
                new ProductEntities { Id = 13, ProductName = "Quần tay công sở", CategoryId = 2, Price = 850000, Quantity = 150,  ProductDescription = "Áo thời trang mùa đông", SupplierId = 3, Image = "images/product/men/aokhoacadidas.jpg", Status = 1, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
                new ProductEntities { Id = 14, ProductName = "Váy Elise", CategoryId = 1, Price = 1390000, Quantity = 150,  ProductDescription = "Áo thời trang mùa đông", SupplierId = 2, Image = "images/product/men/aokhoacadidas.jpg", Status = 1, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
                new ProductEntities { Id = 16, ProductName = "Giày Bitis Hunter X 2021", CategoryId = 2, Price = 899000, Quantity = 150, ProductDescription = "Áo thời trang mùa đông", SupplierId = 1, Image = "images/product/men/aokhoacadidas.jpg", Status = 1, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime });
            modelbuilder.Entity<SlideEntities>().HasData(
                new SlideEntities { Id = 1, SlideName = "Khuyễn mãi Noel", Status = 1, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
                new SlideEntities { Id = 2, SlideName = "Khuyễn mãi Ngày quốc tế Phụ nữ 8-3", Status = 1, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
                new SlideEntities { Id = 3, SlideName = "Khuyễn mãi Tết Tân Sửu", Status = 1, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
                new SlideEntities { Id = 4, SlideName = "Black Friday", Status = 1, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
                new SlideEntities { Id = 5, SlideName = "Ngày nhà giáo Việt Nam", Status = 1, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime });
            modelbuilder.Entity<SupplierEntities>().HasData(
                new SupplierEntities { Id = 1, SupplierName = "Bitis", Status = 1, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
                new SupplierEntities { Id = 2, SupplierName = "Adidas", Status = 1, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
                new SupplierEntities { Id = 3, SupplierName = "Juno", Status = 1, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
                new SupplierEntities { Id = 4, SupplierName = "Elise", Status = 1, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime });
            modelbuilder.Entity<TopicEntities>().HasData(
                new TopicEntities { Id = 1, TopicName = "Thời trang", Status = 1, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
                new TopicEntities { Id = 2, TopicName = "Thời trang mùa đông", Status = 1, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
                new TopicEntities { Id = 3, TopicName = "Thời trang mùa hè", Status = 1, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime },
                new TopicEntities { Id = 4, TopicName = "Thời trang Noel", Status = 1, CreateBy = 1, CreateDate = dateTime, UpdateBy = 1, UpdateDate = dateTime });
            modelbuilder.Entity<UserEntities>().HasData(
                new UserEntities
                {
                    Id = 1,
                    FirtName = "Cường",
                    LastName = "Nguyễn",
                    Phone = "0377077630",
                    Address = "64 Cách Mạng Tháng 8 Phường 5 Quận 11 TP Hồ Chí Minh",
                    Sex = "Nam",
                    Email = "nqcuong720@gmail.com",
                    BirthDay = "2000-07-13",
                    Access = 0,
                    UserName = "nqcuong720",
                    Password = "nqcuong720720",
                    Status = 1,
                    CreateBy = 1,
                    CreateDate = dateTime,
                    UpdateBy = 1,
                    UpdateDate = dateTime,
                },
                new UserEntities
                {
                    Id = 2,
                    FirtName = "Hải",
                    LastName = "Nguyễn",
                    Phone = "0377077630",
                    Address = "128A An Dương Vương Phường 5 Quận 11 TP Hồ Chí Minh",
                    Sex = "Nam",
                    Email = "nqhai@gmail.com",
                    BirthDay = "2000-07-13",
                    Access = 1,
                    UserName = "nqhai720",
                    Password = "nqhai720720",
                    Status = 1,
                    CreateBy = 1,
                    CreateDate = dateTime,
                    UpdateBy = 1,
                    UpdateDate = dateTime,
                },
                new UserEntities
                {
                    Id = 3,
                    FirtName = "Duy",
                    LastName = "Nguyễn",
                    Phone = "0971561612",
                    Address = "280A Lạc Long Quân Phường 5 Quận 11 TP Hồ Chí Minh",
                    Sex = "Nam",
                    Email = "nqduy@gmail.com",
                    BirthDay = "2000-07-13",
                    Access = 1,
                    UserName = "nqduy",
                    Password = "nqduy",
                    Status = 1,
                    CreateBy = 1,
                    CreateDate = dateTime,
                    UpdateBy = 1,
                    UpdateDate = dateTime,
                },
                new UserEntities
                {
                    Id = 4,
                    FirtName = "Khánh",
                    LastName = "Nguyễn",
                    Phone = "097123561",
                    Address = "351A Lạc Long Quân Phường 5 Quận 11 TP Hồ Chí Minh",
                    Sex = "Nam",
                    Email = "nqkhanh@gmail.com",
                    BirthDay = "2000-07-13",
                    Access = 2,
                    UserName = "nqkhanh",
                    Password = "nqkhanh",
                    Status = 1,
                    CreateBy = 1,
                    CreateDate = dateTime,
                    UpdateBy = 1,
                    UpdateDate = dateTime,
                });
            modelbuilder.Entity<RoleEntities>().HasData(
                new RoleEntities { Id = 1, Access = 0, AccessName = "ADMIN", Decription = "Admin" },
                new RoleEntities { Id = 2, Access = 1, AccessName = "Customer", Decription = "Customer" },
                new RoleEntities { Id = 3, Access = 2, AccessName = "Sale", Decription = "Sale" },
                new RoleEntities { Id = 4, Access = 3, AccessName = "Manager", Decription = "Manager" });
        }
    }
}
