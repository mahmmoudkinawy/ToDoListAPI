using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Models;

namespace ToDoList.Data
{
    public class ToDoDbContext : DbContext
    {
        public ToDoDbContext(DbContextOptions<ToDoDbContext> options) : base(options)
        {

        }

        public DbSet<ToDoItem> ToDoItems { get; set; }

        //Seed data added
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ToDoItem>().HasData(
                new ToDoItem()
                {
                    Id = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                    Completed = true,
                    Text = "Playing football",
                    UserId = Guid.Parse("821113c2-e93f-42b3-b392-0e09f5ac89b0")
                },
                new ToDoItem()
                {
                    Id = Guid.Parse("da2fd609-d754-4feb-8acd-c4f9ff13ba96"),
                    Completed = true,
                    Text = "Watching TV",
                    UserId = Guid.Parse("13f1612b-11e5-4af3-aaa2-fef6f992f36d")
                },
                new ToDoItem()
                {
                    Id = Guid.Parse("2902b665-1190-4c70-9915-b9c2d7680450"),
                    Completed = false,
                    Text = "Swimming",
                    UserId = Guid.Parse("559f6897-fdc0-4270-abc4-6d9e578fbcba")
                },
                new ToDoItem()
                {
                    Id = Guid.Parse("102b566b-ba1f-404c-b2df-e2cde39ade09"),
                    Completed = false,
                    Text = "Traveling abroad",
                    UserId = Guid.Parse("82cc16b8-b18f-4287-855d-a4e50f181e67")
                });
        }
    }
}
