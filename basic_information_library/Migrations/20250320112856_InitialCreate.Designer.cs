﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace basic_information_library.Migrations
{
    [DbContext(typeof(DatabaseCtx))]
    [Migration("20250320112856_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("basic_information_library.models.BasicInformation", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("barangay")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("birthday")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("country")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("houseNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("middleInitial")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("province")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("street")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("suffix")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("PersonalDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
