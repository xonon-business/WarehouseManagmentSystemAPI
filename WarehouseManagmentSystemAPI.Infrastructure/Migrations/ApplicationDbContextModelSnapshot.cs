// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WarehouseManagmentSystemAPI.Infrastructure;

#nullable disable

namespace WarehouseManagmentSystemAPI.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WarehouseManagmentSystemAPI.Infrastructure.Entities.CategoryEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("WarehouseManagmentSystemAPI.Infrastructure.Entities.CustomerEntity", b =>
                {
                    b.Property<Guid>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Credit_Card")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.HasIndex("Name");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("WarehouseManagmentSystemAPI.Infrastructure.Entities.OrderEntityRoot.OrdersToCustomersEntity", b =>
                {
                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("OrderId", "CustomerId");

                    b.HasIndex("CustomerId");

                    b.ToTable("ordersToCustomers");
                });

            modelBuilder.Entity("WarehouseManagmentSystemAPI.Infrastructure.Entities.OrderEntityRoot.OrdersToUsersEntity", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "OrderId");

                    b.HasIndex("OrderId");

                    b.ToTable("ordersToUsers");
                });

            modelBuilder.Entity("WarehouseManagmentSystemAPI.Infrastructure.Entities.OrderEntityRoot.OrderToItemsEntity", b =>
                {
                    b.Property<Guid>("Order_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Price_Per_Unit")
                        .HasColumnType("float");

                    b.Property<int>("Quantity_Sold")
                        .HasColumnType("int");

                    b.Property<double>("Total_Item_Sold")
                        .HasColumnType("float");

                    b.HasKey("Order_Id", "ProductID");

                    b.HasIndex("ProductID");

                    b.ToTable("orderToItems");
                });

            modelBuilder.Entity("WarehouseManagmentSystemAPI.Infrastructure.Entities.ProductEntity", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryIdFK")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double?>("ProductCostPrice")
                        .HasColumnType("float");

                    b.Property<string>("ProductDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("ProductImage")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ProductName")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int?>("ProductQTY")
                        .HasColumnType("int");

                    b.Property<double?>("ProductSalePrice")
                        .HasColumnType("float");

                    b.Property<int?>("ReOrderPoint")
                        .HasColumnType("int");

                    b.Property<string>("SKU")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("StockIdFk")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id");

                    b.HasIndex("CategoryIdFK");

                    b.HasIndex("ProductName")
                        .IsUnique()
                        .HasFilter("[ProductName] IS NOT NULL");

                    b.HasIndex("StockIdFk");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("WarehouseManagmentSystemAPI.Infrastructure.Entities.StockEntity", b =>
                {
                    b.Property<Guid>("StockId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("StockName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("StockId");

                    b.HasIndex("StockName")
                        .IsUnique();

                    b.ToTable("Stocks");
                });

            modelBuilder.Entity("WarehouseManagmentSystemAPI.Infrastructure.Entities.UserEntityRoot.RoleEntity", b =>
                {
                    b.Property<Guid>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RoleType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("WarehouseManagmentSystemAPI.Infrastructure.Entities.UserEntityRoot.UserEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WarehouseManagmentSystemAPI.Infrastructure.OrderEntityRoot.OrderEntity", b =>
                {
                    b.Property<Guid>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("OrderDueDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("WarehouseManagmentSystemAPI.Infrastructure.Entities.OrderEntityRoot.OrdersToCustomersEntity", b =>
                {
                    b.HasOne("WarehouseManagmentSystemAPI.Infrastructure.Entities.CustomerEntity", "Customers")
                        .WithMany("OrdersToCustomers")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WarehouseManagmentSystemAPI.Infrastructure.OrderEntityRoot.OrderEntity", "Orders")
                        .WithMany("ordersToCustomers")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customers");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("WarehouseManagmentSystemAPI.Infrastructure.Entities.OrderEntityRoot.OrdersToUsersEntity", b =>
                {
                    b.HasOne("WarehouseManagmentSystemAPI.Infrastructure.OrderEntityRoot.OrderEntity", "Order")
                        .WithMany("ordersToUsers")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WarehouseManagmentSystemAPI.Infrastructure.Entities.UserEntityRoot.UserEntity", "User")
                        .WithMany("ordersToUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WarehouseManagmentSystemAPI.Infrastructure.Entities.OrderEntityRoot.OrderToItemsEntity", b =>
                {
                    b.HasOne("WarehouseManagmentSystemAPI.Infrastructure.OrderEntityRoot.OrderEntity", "Orders")
                        .WithMany("OrdersItems")
                        .HasForeignKey("Order_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WarehouseManagmentSystemAPI.Infrastructure.Entities.ProductEntity", "Products")
                        .WithMany("OrdersItems")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Orders");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("WarehouseManagmentSystemAPI.Infrastructure.Entities.ProductEntity", b =>
                {
                    b.HasOne("WarehouseManagmentSystemAPI.Infrastructure.Entities.CategoryEntity", "Category")
                        .WithMany("ProductEntities")
                        .HasForeignKey("CategoryIdFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WarehouseManagmentSystemAPI.Infrastructure.Entities.StockEntity", "Stock")
                        .WithMany("ProductEntity")
                        .HasForeignKey("StockIdFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Stock");
                });

            modelBuilder.Entity("WarehouseManagmentSystemAPI.Infrastructure.Entities.UserEntityRoot.UserEntity", b =>
                {
                    b.HasOne("WarehouseManagmentSystemAPI.Infrastructure.Entities.UserEntityRoot.RoleEntity", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("WarehouseManagmentSystemAPI.Infrastructure.Entities.CategoryEntity", b =>
                {
                    b.Navigation("ProductEntities");
                });

            modelBuilder.Entity("WarehouseManagmentSystemAPI.Infrastructure.Entities.CustomerEntity", b =>
                {
                    b.Navigation("OrdersToCustomers");
                });

            modelBuilder.Entity("WarehouseManagmentSystemAPI.Infrastructure.Entities.ProductEntity", b =>
                {
                    b.Navigation("OrdersItems");
                });

            modelBuilder.Entity("WarehouseManagmentSystemAPI.Infrastructure.Entities.StockEntity", b =>
                {
                    b.Navigation("ProductEntity");
                });

            modelBuilder.Entity("WarehouseManagmentSystemAPI.Infrastructure.Entities.UserEntityRoot.RoleEntity", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("WarehouseManagmentSystemAPI.Infrastructure.Entities.UserEntityRoot.UserEntity", b =>
                {
                    b.Navigation("ordersToUsers");
                });

            modelBuilder.Entity("WarehouseManagmentSystemAPI.Infrastructure.OrderEntityRoot.OrderEntity", b =>
                {
                    b.Navigation("OrdersItems");

                    b.Navigation("ordersToCustomers");

                    b.Navigation("ordersToUsers");
                });
#pragma warning restore 612, 618
        }
    }
}
