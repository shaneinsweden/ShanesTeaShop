﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TeaShop.Models;

namespace TeaShop.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190226095941_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TeaShop.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("CaffieneFree");

                    b.Property<string>("CategoryName");

                    b.Property<string>("Description");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("TeaShop.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("AddressLine2");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("OrderPlaced");

                    b.Property<decimal>("OrderTotal");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("State");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("TeaShop.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount");

                    b.Property<int>("OrderId");

                    b.Property<decimal>("Price");

                    b.Property<int>("TeaId");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("OrderId");

                    b.HasIndex("TeaId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("TeaShop.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount");

                    b.Property<string>("ShoppingCartId");

                    b.Property<int?>("TeaId");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("TeaId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("TeaShop.Models.Tea", b =>
                {
                    b.Property<int>("TeaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<string>("ImageThumbnailUrl");

                    b.Property<string>("ImageUrl");

                    b.Property<bool>("InStock");

                    b.Property<bool>("InTeaBags");

                    b.Property<bool>("IsTeaOfTheWeek");

                    b.Property<string>("LongDescription");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<string>("ShortDescription");

                    b.HasKey("TeaId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Teas");
                });

            modelBuilder.Entity("TeaShop.Models.OrderDetail", b =>
                {
                    b.HasOne("TeaShop.Models.Order", "Order")
                        .WithMany("OrderLines")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TeaShop.Models.Tea", "Tea")
                        .WithMany()
                        .HasForeignKey("TeaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TeaShop.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("TeaShop.Models.Tea", "Tea")
                        .WithMany()
                        .HasForeignKey("TeaId");
                });

            modelBuilder.Entity("TeaShop.Models.Tea", b =>
                {
                    b.HasOne("TeaShop.Models.Category", "Category")
                        .WithMany("Teas")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
