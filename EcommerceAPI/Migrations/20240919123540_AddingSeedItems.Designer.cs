﻿// <auto-generated />
using System;
using EcommerceAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EcommerceAPI.Migrations
{
    [DbContext(typeof(EcommerceDbContext))]
    [Migration("20240919123540_AddingSeedItems")]
    partial class AddingSeedItems
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EcommerceAPI.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = 1,
                            CreatedDate = new DateTime(2024, 9, 19, 8, 35, 40, 606, DateTimeKind.Local).AddTicks(3518),
                            Description = "A portable computer with a closing lid.",
                            Name = "Laptop",
                            Price = 999m
                        },
                        new
                        {
                            Id = 2,
                            Category = 2,
                            CreatedDate = new DateTime(2024, 9, 17, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "A t-shirt with the logo of a popular band.",
                            Name = "Band T-Shirt",
                            Price = 20m
                        },
                        new
                        {
                            Id = 3,
                            Category = 4,
                            CreatedDate = new DateTime(2024, 9, 16, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "A kitchen tool used to emulsify food.",
                            Name = "Blender",
                            Price = 35m
                        },
                        new
                        {
                            Id = 4,
                            Category = 5,
                            CreatedDate = new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "A tube of lipstick in a bright red color.",
                            Name = "Lipstick",
                            Price = 15m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
