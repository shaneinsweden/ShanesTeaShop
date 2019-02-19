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
    [Migration("20190219214359_Initial")]
    partial class Initial
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
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("CaffieneFree");

                    b.Property<int>("CategoryId");

                    b.Property<string>("CategoryName");

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("TeaShop.Models.Tea", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryId");

                    b.Property<Guid?>("CategoryId1");

                    b.Property<string>("ImageThumbnailUrl");

                    b.Property<string>("ImageUrl");

                    b.Property<bool>("InStock");

                    b.Property<bool>("InTeaBags");

                    b.Property<bool>("IsTeaOfTheWeek");

                    b.Property<string>("LongDescription");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<string>("ShortDescription");

                    b.Property<int>("TeaId");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId1");

                    b.ToTable("Teas");
                });

            modelBuilder.Entity("TeaShop.Models.Tea", b =>
                {
                    b.HasOne("TeaShop.Models.Category", "Category")
                        .WithMany("Teas")
                        .HasForeignKey("CategoryId1");
                });
#pragma warning restore 612, 618
        }
    }
}
