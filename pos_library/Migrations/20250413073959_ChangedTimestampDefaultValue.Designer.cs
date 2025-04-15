﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using pos_library;

#nullable disable

namespace pos_library.Migrations
{
    [DbContext(typeof(DatabaseCtx))]
    [Migration("20250413073959_ChangedTimestampDefaultValue")]
    partial class ChangedTimestampDefaultValue
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("pos_library.models.Customer", b =>
                {
                    b.Property<int>("customer_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("timestamp");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("first_name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("last_name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("phone_number")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("varchar(13)");

                    b.HasKey("customer_id");

                    b.HasIndex("email")
                        .IsUnique();

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("pos_library.models.Employee", b =>
                {
                    b.Property<int>("employee_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("created_at")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("first_name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("hire_date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("last_name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("position")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.HasKey("employee_id");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("pos_library.models.Inventory", b =>
                {
                    b.Property<int>("inventory_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("last_updated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<int>("product_id")
                        .HasColumnType("int");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.HasKey("inventory_id");

                    b.HasIndex("product_id");

                    b.ToTable("Inventory");
                });

            modelBuilder.Entity("pos_library.models.Product", b =>
                {
                    b.Property<int>("product_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("category")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<DateTime>("created_at")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(6,2)");

                    b.Property<string>("product_name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<int>("stock_quality")
                        .HasColumnType("int");

                    b.HasKey("product_id");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("pos_library.models.Sale", b =>
                {
                    b.Property<int>("sale_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("customer_id")
                        .HasColumnType("int");

                    b.Property<int>("employee_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("sale_date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<decimal>("total_amount")
                        .HasColumnType("decimal(6,2)");

                    b.HasKey("sale_id");

                    b.HasIndex("customer_id");

                    b.HasIndex("employee_id");

                    b.ToTable("Sale");
                });

            modelBuilder.Entity("pos_library.models.SaleDetail", b =>
                {
                    b.Property<int>("sale_detail_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("product_id")
                        .HasColumnType("int");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.Property<int>("sale_id")
                        .HasColumnType("int");

                    b.Property<decimal>("unit_price")
                        .HasColumnType("decimal(6,2)");

                    b.HasKey("sale_detail_id");

                    b.HasIndex("product_id");

                    b.HasIndex("sale_id");

                    b.ToTable("SaleDetail");
                });

            modelBuilder.Entity("pos_library.models.Inventory", b =>
                {
                    b.HasOne("pos_library.models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("product_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("pos_library.models.Sale", b =>
                {
                    b.HasOne("pos_library.models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("customer_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("pos_library.models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("employee_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("pos_library.models.SaleDetail", b =>
                {
                    b.HasOne("pos_library.models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("product_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("pos_library.models.Sale", "Sale")
                        .WithMany()
                        .HasForeignKey("sale_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Sale");
                });
#pragma warning restore 612, 618
        }
    }
}
