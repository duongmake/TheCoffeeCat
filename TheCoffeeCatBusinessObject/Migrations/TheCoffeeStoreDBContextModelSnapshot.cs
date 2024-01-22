﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TheCoffeeCatBusinessObject;

#nullable disable

namespace TheCoffeeCatBusinessObject.Migrations
{
    [DbContext(typeof(TheCoffeeStoreDBContext))]
    partial class TheCoffeeStoreDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TheCoffeeCatBusinessObject.BusinessObject.Account", b =>
                {
                    b.Property<Guid>("AccountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("StaffID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("AccountID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("RoleID");

                    b.HasIndex("StaffID");

                    b.ToTable("Account", (string)null);
                });

            modelBuilder.Entity("TheCoffeeCatBusinessObject.BusinessObject.Cat", b =>
                {
                    b.Property<Guid>("CatID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("CatName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CoffeeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CoffeeShopCoffeeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CatID");

                    b.HasIndex("CoffeeShopCoffeeID");

                    b.ToTable("Cat", (string)null);
                });

            modelBuilder.Entity("TheCoffeeCatBusinessObject.BusinessObject.CatProduct", b =>
                {
                    b.Property<Guid>("CatProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CatProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CatProductType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("CatProductID");

                    b.ToTable("CatProduct", (string)null);
                });

            modelBuilder.Entity("TheCoffeeCatBusinessObject.BusinessObject.CoffeeShop", b =>
                {
                    b.Property<Guid>("CoffeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CloseTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("CoffeeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OpenTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("CoffeeID");

                    b.ToTable("CoffeeShop", (string)null);
                });

            modelBuilder.Entity("TheCoffeeCatBusinessObject.BusinessObject.Comment", b =>
                {
                    b.Property<Guid>("CommentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CoffeeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CoffeeShopCoffeeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CommentText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CustomerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("CommentID");

                    b.HasIndex("CoffeeShopCoffeeID");

                    b.HasIndex("CustomerID");

                    b.ToTable("Comment", (string)null);
                });

            modelBuilder.Entity("TheCoffeeCatBusinessObject.BusinessObject.CustomerPackage", b =>
                {
                    b.Property<Guid>("CPID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateStart")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("SubscriptionID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CPID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("SubscriptionID");

                    b.ToTable("CustomerPackage", (string)null);
                });

            modelBuilder.Entity("TheCoffeeCatBusinessObject.BusinessObject.OrderDetail", b =>
                {
                    b.Property<Guid>("OrderDeatailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Amount")
                        .HasColumnType("real");

                    b.Property<Guid>("MenuID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OrderID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderDeatailID");

                    b.HasIndex("MenuID");

                    b.HasIndex("OrderID");

                    b.ToTable("OrderDetail", (string)null);
                });

            modelBuilder.Entity("TheCoffeeCatBusinessObject.BusinessObject.Role", b =>
                {
                    b.Property<Guid>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleID");

                    b.ToTable("Role", (string)null);
                });

            modelBuilder.Entity("TheCoffeeCatBusinessObject.Customer", b =>
                {
                    b.Property<Guid>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("SubscriptionID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CustomerID");

                    b.HasIndex("SubscriptionID");

                    b.ToTable("Customer", (string)null);
                });

            modelBuilder.Entity("TheCoffeeCatBusinessObject.Drink", b =>
                {
                    b.Property<Guid>("DrinkID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DrinkName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("float");

                    b.HasKey("DrinkID");

                    b.ToTable("Drink", (string)null);
                });

            modelBuilder.Entity("TheCoffeeCatBusinessObject.Menu", b =>
                {
                    b.Property<Guid>("MenuID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CatProductID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CoffeeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CoffeeShopCoffeeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DrinkID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("MenuID");

                    b.HasIndex("CatProductID");

                    b.HasIndex("CoffeeShopCoffeeID");

                    b.HasIndex("DrinkID");

                    b.ToTable("Menu", (string)null);
                });

            modelBuilder.Entity("TheCoffeeCatBusinessObject.Order", b =>
                {
                    b.Property<Guid>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CustomerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<Guid>("TableID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TotalDiscount")
                        .HasColumnType("int");

                    b.Property<int>("TotalItem")
                        .HasColumnType("int");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.HasKey("OrderID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("TableID");

                    b.ToTable("Order", (string)null);
                });

            modelBuilder.Entity("TheCoffeeCatBusinessObject.Staff", b =>
                {
                    b.Property<Guid>("StaffID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CoffeeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CoffeeShopCoffeeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StaffID");

                    b.HasIndex("CoffeeShopCoffeeID");

                    b.ToTable("Staff", (string)null);
                });

            modelBuilder.Entity("TheCoffeeCatBusinessObject.Subscription", b =>
                {
                    b.Property<Guid>("SubscriptionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("DiscountPercent")
                        .HasColumnType("real");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("SubscriptionID");

                    b.ToTable("Subscription", (string)null);
                });

            modelBuilder.Entity("TheCoffeeCatBusinessObject.Table", b =>
                {
                    b.Property<Guid>("TableID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CoffeeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CoffeeShopCoffeeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TableID");

                    b.HasIndex("CoffeeShopCoffeeID");

                    b.ToTable("Table", (string)null);
                });

            modelBuilder.Entity("TheCoffeeCatBusinessObject.BusinessObject.Account", b =>
                {
                    b.HasOne("TheCoffeeCatBusinessObject.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TheCoffeeCatBusinessObject.BusinessObject.Role", "Role")
                        .WithMany("Accounts")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("TheCoffeeCatBusinessObject.Staff", "Staff")
                        .WithMany()
                        .HasForeignKey("StaffID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Role");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("TheCoffeeCatBusinessObject.BusinessObject.Cat", b =>
                {
                    b.HasOne("TheCoffeeCatBusinessObject.BusinessObject.CoffeeShop", "CoffeeShop")
                        .WithMany("Cats")
                        .HasForeignKey("CoffeeShopCoffeeID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("CoffeeShop");
                });

            modelBuilder.Entity("TheCoffeeCatBusinessObject.BusinessObject.Comment", b =>
                {
                    b.HasOne("TheCoffeeCatBusinessObject.BusinessObject.CoffeeShop", "CoffeeShop")
                        .WithMany("Comments")
                        .HasForeignKey("CoffeeShopCoffeeID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("TheCoffeeCatBusinessObject.Customer", "Customer")
                        .WithMany("Comments")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("CoffeeShop");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("TheCoffeeCatBusinessObject.BusinessObject.CustomerPackage", b =>
                {
                    b.HasOne("TheCoffeeCatBusinessObject.Customer", "Customer")
                        .WithMany("CustomerPackages")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("TheCoffeeCatBusinessObject.Subscription", "Subscription")
                        .WithMany("CustomerPackages")
                        .HasForeignKey("SubscriptionID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Subscription");
                });

            modelBuilder.Entity("TheCoffeeCatBusinessObject.BusinessObject.OrderDetail", b =>
                {
                    b.HasOne("TheCoffeeCatBusinessObject.Menu", "Menu")
                        .WithMany("OrderDetails")
                        .HasForeignKey("MenuID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("TheCoffeeCatBusinessObject.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Menu");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("TheCoffeeCatBusinessObject.Customer", b =>
                {
                    b.HasOne("TheCoffeeCatBusinessObject.Subscription", "Subscriptions")
                        .WithMany()
                        .HasForeignKey("SubscriptionID");

                    b.Navigation("Subscriptions");
                });

            modelBuilder.Entity("TheCoffeeCatBusinessObject.Menu", b =>
                {
                    b.HasOne("TheCoffeeCatBusinessObject.BusinessObject.CatProduct", "CatProduct")
                        .WithMany("Menus")
                        .HasForeignKey("CatProductID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("TheCoffeeCatBusinessObject.BusinessObject.CoffeeShop", "CoffeeShop")
                        .WithMany("Menus")
                        .HasForeignKey("CoffeeShopCoffeeID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("TheCoffeeCatBusinessObject.Drink", "Drink")
                        .WithMany("Menus")
                        .HasForeignKey("DrinkID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("CatProduct");

                    b.Navigation("CoffeeShop");

                    b.Navigation("Drink");
                });

            modelBuilder.Entity("TheCoffeeCatBusinessObject.Order", b =>
                {
                    b.HasOne("TheCoffeeCatBusinessObject.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("TheCoffeeCatBusinessObject.Table", "Table")
                        .WithMany("Orders")
                        .HasForeignKey("TableID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Table");
                });

            modelBuilder.Entity("TheCoffeeCatBusinessObject.Staff", b =>
                {
                    b.HasOne("TheCoffeeCatBusinessObject.BusinessObject.CoffeeShop", "CoffeeShop")
                        .WithMany("Staffs")
                        .HasForeignKey("CoffeeShopCoffeeID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("CoffeeShop");
                });

            modelBuilder.Entity("TheCoffeeCatBusinessObject.Table", b =>
                {
                    b.HasOne("TheCoffeeCatBusinessObject.BusinessObject.CoffeeShop", "CoffeeShop")
                        .WithMany("Tables")
                        .HasForeignKey("CoffeeShopCoffeeID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("CoffeeShop");
                });

            modelBuilder.Entity("TheCoffeeCatBusinessObject.BusinessObject.CatProduct", b =>
                {
                    b.Navigation("Menus");
                });

            modelBuilder.Entity("TheCoffeeCatBusinessObject.BusinessObject.CoffeeShop", b =>
                {
                    b.Navigation("Cats");

                    b.Navigation("Comments");

                    b.Navigation("Menus");

                    b.Navigation("Staffs");

                    b.Navigation("Tables");
                });

            modelBuilder.Entity("TheCoffeeCatBusinessObject.BusinessObject.Role", b =>
                {
                    b.Navigation("Accounts");
                });

            modelBuilder.Entity("TheCoffeeCatBusinessObject.Customer", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("CustomerPackages");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("TheCoffeeCatBusinessObject.Drink", b =>
                {
                    b.Navigation("Menus");
                });

            modelBuilder.Entity("TheCoffeeCatBusinessObject.Menu", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("TheCoffeeCatBusinessObject.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("TheCoffeeCatBusinessObject.Subscription", b =>
                {
                    b.Navigation("CustomerPackages");
                });

            modelBuilder.Entity("TheCoffeeCatBusinessObject.Table", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
