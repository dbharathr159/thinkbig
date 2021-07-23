﻿// <auto-generated />
using System;
using DemoFoodApI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DemoFoodApI.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DemoFoodApI.Entities.Admin", b =>
                {
                    b.Property<int?>("Userid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LastName")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<long?>("Mobile")
                        .HasColumnType("Bigint");

                    b.Property<string>("Password")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Userid");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("DemoFoodApI.Entities.Customer", b =>
                {
                    b.Property<int?>("Customerid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LastName")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<long?>("Moblie")
                        .HasColumnType("Bigint");

                    b.Property<string>("Password")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Status")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Customerid");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("DemoFoodApI.Entities.Menu", b =>
                {
                    b.Property<int?>("Menuid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FoodCategory")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("MenuName")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<decimal>("Price")
                        .HasColumnType("Decimal(38,17)");

                    b.Property<string>("Quantity")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Menuid");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("DemoFoodApI.Entities.Order", b =>
                {
                    b.Property<int>("Orderid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Customerid")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("Date");

                    b.Property<string>("OrderStatus")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("Decimal(38,17)");

                    b.HasKey("Orderid");

                    b.HasIndex("Customerid");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("DemoFoodApI.Entities.OrderItem", b =>
                {
                    b.Property<decimal>("Amount")
                        .HasColumnType("Decimal(38,17)");

                    b.Property<int?>("Menuid")
                        .HasColumnType("int");

                    b.Property<int?>("NoofServing")
                        .HasColumnType("int");

                    b.Property<int?>("Orderid")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasColumnType("Decimal(38,17)");

                    b.HasIndex("Menuid");

                    b.HasIndex("Orderid");

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("DemoFoodApI.Entities.Payment", b =>
                {
                    b.Property<int?>("Paymentid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Orderid")
                        .HasColumnType("int");

                    b.Property<int?>("Oredrid")
                        .HasColumnType("int");

                    b.Property<string>("PaidBy")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Status")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("Decimal(38,17)");

                    b.HasKey("Paymentid");

                    b.HasIndex("Oredrid");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("DemoFoodApI.Entities.Order", b =>
                {
                    b.HasOne("DemoFoodApI.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("Customerid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("DemoFoodApI.Entities.OrderItem", b =>
                {
                    b.HasOne("DemoFoodApI.Entities.Menu", "Menu")
                        .WithMany()
                        .HasForeignKey("Menuid");

                    b.HasOne("DemoFoodApI.Entities.Order", "Order")
                        .WithMany()
                        .HasForeignKey("Orderid");

                    b.Navigation("Menu");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("DemoFoodApI.Entities.Payment", b =>
                {
                    b.HasOne("DemoFoodApI.Entities.Order", "Order")
                        .WithMany()
                        .HasForeignKey("Oredrid");

                    b.Navigation("Order");
                });
#pragma warning restore 612, 618
        }
    }
}
