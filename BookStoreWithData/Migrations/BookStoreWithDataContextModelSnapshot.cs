﻿// <auto-generated />
using System;
using BookStoreWithData.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookStoreWithData.Migrations
{
    [DbContext(typeof(BookStoreWithDataContext))]
    partial class BookStoreWithDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("BookStoreWithData.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Book");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Genre = "Genre1",
                            Price = 20m,
                            PublishDate = new DateTime(2012, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Book1"
                        },
                        new
                        {
                            Id = 2,
                            Genre = "Genre2",
                            Price = 30m,
                            PublishDate = new DateTime(2008, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Book2"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
