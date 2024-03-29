﻿// <auto-generated />
using System;
using LuckysCarsForSale.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LuckysCarsForSale.Migrations
{
    [DbContext(typeof(LuckysCarsForSaleDbContext))]
    [Migration("20240311182726_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LuckysCarsForSale.Models.Buyer", b =>
                {
                    b.Property<int>("BuyerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BuyerId"));

                    b.Property<string>("BuyerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuyerZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BuyerId");

                    b.ToTable("Buyers");
                });

            modelBuilder.Entity("LuckysCarsForSale.Models.Car", b =>
                {
                    b.Property<int>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarId"));

                    b.Property<int>("CarYear")
                        .HasColumnType("int");

                    b.Property<string>("CarZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Submodel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CarId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("LuckysCarsForSale.Models.Quote", b =>
                {
                    b.Property<int>("QuoteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuoteId"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("BuyerId")
                        .HasColumnType("int");

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<bool>("IsCurrent")
                        .HasColumnType("bit");

                    b.HasKey("QuoteId");

                    b.HasIndex("BuyerId");

                    b.HasIndex("CarId");

                    b.ToTable("Quotes");
                });

            modelBuilder.Entity("LuckysCarsForSale.Models.Status", b =>
                {
                    b.Property<int>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StatusId"));

                    b.Property<string>("StatusName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StatusId");

                    b.ToTable("Statuses");
                });

            modelBuilder.Entity("LuckysCarsForSale.Models.StatusHistory", b =>
                {
                    b.Property<int>("StatusHistoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StatusHistoryId"));

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StatusDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("StatusHistoryId");

                    b.HasIndex("CarId");

                    b.HasIndex("StatusId");

                    b.ToTable("StatusHistory");
                });

            modelBuilder.Entity("LuckysCarsForSale.Models.Quote", b =>
                {
                    b.HasOne("LuckysCarsForSale.Models.Buyer", "Buyer")
                        .WithMany("Quotes")
                        .HasForeignKey("BuyerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LuckysCarsForSale.Models.Car", "Car")
                        .WithMany("Quotes")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Buyer");

                    b.Navigation("Car");
                });

            modelBuilder.Entity("LuckysCarsForSale.Models.StatusHistory", b =>
                {
                    b.HasOne("LuckysCarsForSale.Models.Car", "Car")
                        .WithMany("StatusHistory")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LuckysCarsForSale.Models.Status", "Status")
                        .WithMany("StatusHistory")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("LuckysCarsForSale.Models.Buyer", b =>
                {
                    b.Navigation("Quotes");
                });

            modelBuilder.Entity("LuckysCarsForSale.Models.Car", b =>
                {
                    b.Navigation("Quotes");

                    b.Navigation("StatusHistory");
                });

            modelBuilder.Entity("LuckysCarsForSale.Models.Status", b =>
                {
                    b.Navigation("StatusHistory");
                });
#pragma warning restore 612, 618
        }
    }
}
