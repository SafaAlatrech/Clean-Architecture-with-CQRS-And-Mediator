using CleanArchitecture.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace CleanArchitecture.Persistence
{
    public class PostDbContext : DbContext
    {
        public PostDbContext(DbContextOptions<PostDbContext> options)
          : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var categoryGuid = Guid.Parse("{B0788D2F-8003-43C1-92A4-EDC76A7C5DDE}");
            var postGuid = Guid.Parse("{6313179F-7837-473A-A4D5-A5571B43E6A6}");
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = categoryGuid,
                Name = "Technology"
            });

            modelBuilder.Entity<Post>().HasData(new Post
            {
                Id = postGuid,
                Title = "Clean Architecture with CQRS and Mediator Patterns",
                Content = "Clean architecute was created by Robert C. Martin known as Uncle Bob. It’s now mostly used software architecute especially in microservice architecture. In this article, I will discuss about clean architecute a bit and then implement the concept using clean architecture and CQRS pattern using asp.net core, entity framework core and dapper. The main concept of clean architecture is that the core logic of the application is changed rarely so it will be independent and considered it as core.",
                ImageUrl = "https://mahedee.net/assets/images/posts/2021/clean.png",
                CategoryId = categoryGuid
            });

        }



    }
}
