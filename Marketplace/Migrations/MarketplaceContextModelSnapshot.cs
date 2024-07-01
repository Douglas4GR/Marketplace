﻿// <auto-generated />
using System;
using Marketplace.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Marketplace.Migrations
{
    [DbContext(typeof(MarketplaceContext))]
    partial class MarketplaceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Marketplace.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("OrderItemId")
                        .HasColumnType("int");

                    b.Property<string>("BuyerEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuyerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("BuyerPhoneNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Currency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IossNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ItemPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("PaymentsDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("QuantityPurchased")
                        .HasColumnType("int");

                    b.Property<string>("RecipientName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipAddress1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipAddress2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipAddress3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipServiceLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sku")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderId", "OrderItemId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Marketplace.Models.Product", b =>
                {
                    b.Property<string>("Sku")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StockQuantity")
                        .HasColumnType("int");

                    b.HasKey("Sku");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
