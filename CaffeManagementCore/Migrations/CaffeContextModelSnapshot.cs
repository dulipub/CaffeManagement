﻿// <auto-generated />
using System;
using CaffeManagementCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CaffeManagementCore.Migrations
{
    [DbContext(typeof(CaffeContext))]
    partial class CaffeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("CaffeManagementCore.Models.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("AddressId");

                    b.Property<int>("ContactNumber");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<bool>("isDeleted");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("CaffeManagementCore.Models.Helpers.AddictionalCharge", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Charge");

                    b.Property<string>("Name");

                    b.Property<Guid?>("StoreId");

                    b.Property<bool>("isDeleted");

                    b.Property<bool>("isPercentage");

                    b.HasKey("Id");

                    b.HasIndex("StoreId");

                    b.ToTable("AddictionalCharges");
                });

            modelBuilder.Entity("CaffeManagementCore.Models.Helpers.Location", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<string>("Landmarks");

                    b.Property<double?>("Latitude");

                    b.Property<double?>("Longitude");

                    b.Property<string>("State");

                    b.Property<bool>("isDeleted");

                    b.HasKey("Id");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("CaffeManagementCore.Models.Inventory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<Guid?>("StoreId");

                    b.Property<bool>("isDeleted");

                    b.HasKey("Id");

                    b.HasIndex("StoreId");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("CaffeManagementCore.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("Completed");

                    b.Property<DateTime>("Created");

                    b.Property<Guid?>("CustomerId");

                    b.Property<Guid?>("DeliveryAddressId");

                    b.Property<double>("DeliveryCharge");

                    b.Property<double>("DiscountPercentage");

                    b.Property<double>("FinalPrice");

                    b.Property<double>("ServiceCharge");

                    b.Property<Guid?>("StoreId");

                    b.Property<double>("Tax");

                    b.Property<bool>("isDeleted");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("DeliveryAddressId");

                    b.HasIndex("StoreId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("CaffeManagementCore.Models.OrderItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("InventoryId");

                    b.Property<Guid?>("OrderId");

                    b.Property<Guid?>("ProductId");

                    b.Property<int>("Quantity");

                    b.Property<bool>("isDeleted");

                    b.Property<double>("price");

                    b.HasKey("Id");

                    b.HasIndex("InventoryId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("CaffeManagementCore.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("Type");

                    b.Property<float>("UnitBasePrice");

                    b.Property<bool>("isDeleted");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("CaffeManagementCore.Models.Store", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("AddressId");

                    b.Property<string>("Name");

                    b.Property<bool>("isDeleted");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Stores");
                });

            modelBuilder.Entity("CaffeManagementCore.Models.Customer", b =>
                {
                    b.HasOne("CaffeManagementCore.Models.Helpers.Location", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");
                });

            modelBuilder.Entity("CaffeManagementCore.Models.Helpers.AddictionalCharge", b =>
                {
                    b.HasOne("CaffeManagementCore.Models.Store")
                        .WithMany("AddictionalCharges")
                        .HasForeignKey("StoreId");
                });

            modelBuilder.Entity("CaffeManagementCore.Models.Inventory", b =>
                {
                    b.HasOne("CaffeManagementCore.Models.Store", "Store")
                        .WithMany("Inventories")
                        .HasForeignKey("StoreId");
                });

            modelBuilder.Entity("CaffeManagementCore.Models.Order", b =>
                {
                    b.HasOne("CaffeManagementCore.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.HasOne("CaffeManagementCore.Models.Helpers.Location", "DeliveryAddress")
                        .WithMany()
                        .HasForeignKey("DeliveryAddressId");

                    b.HasOne("CaffeManagementCore.Models.Store", "Store")
                        .WithMany()
                        .HasForeignKey("StoreId");
                });

            modelBuilder.Entity("CaffeManagementCore.Models.OrderItem", b =>
                {
                    b.HasOne("CaffeManagementCore.Models.Inventory")
                        .WithMany("StoredItems")
                        .HasForeignKey("InventoryId");

                    b.HasOne("CaffeManagementCore.Models.Order")
                        .WithMany("Items")
                        .HasForeignKey("OrderId");

                    b.HasOne("CaffeManagementCore.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("CaffeManagementCore.Models.Store", b =>
                {
                    b.HasOne("CaffeManagementCore.Models.Helpers.Location", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");
                });
#pragma warning restore 612, 618
        }
    }
}
