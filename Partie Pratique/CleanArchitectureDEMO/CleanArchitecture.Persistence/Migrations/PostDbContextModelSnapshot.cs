﻿// <auto-generated />
using System;
using CleanArchitecture.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CleanArchitecture.Persistence.Migrations
{
    [DbContext(typeof(PostDbContext))]
    partial class PostDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("CleanArchitecture.Domain.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dde"),
                            Name = "Technology"
                        });
                });

            modelBuilder.Entity("CleanArchitecture.Domain.Post", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6313179f-7837-473a-a4d5-a5571b43e6a6"),
                            CategoryId = new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dde"),
                            Content = "Clean architecute was created by Robert C. Martin known as Uncle Bob. It’s now mostly used software architecute especially in microservice architecture. In this article, I will discuss about clean architecute a bit and then implement the concept using clean architecture and CQRS pattern using asp.net core, entity framework core and dapper. The main concept of clean architecture is that the core logic of the application is changed rarely so it will be independent and considered it as core.",
                            ImageUrl = "https://mahedee.net/assets/images/posts/2021/clean.png",
                            Title = "Clean Architecture with CQRS and Mediator Patterns"
                        });
                });

            modelBuilder.Entity("CleanArchitecture.Domain.Post", b =>
                {
                    b.HasOne("CleanArchitecture.Domain.Category", "Category")
                        .WithMany("Blogs")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("CleanArchitecture.Domain.Category", b =>
                {
                    b.Navigation("Blogs");
                });
#pragma warning restore 612, 618
        }
    }
}
