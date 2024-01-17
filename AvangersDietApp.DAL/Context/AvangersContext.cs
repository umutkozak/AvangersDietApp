using AvangersDietApp.DAL.Concrate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvangersDietApp.DAL.SeedData;

namespace AvangersDietApp.DAL.Context
{
    public class AvangersContext: DbContext
    {
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Food> Food { get; set; }   
        public DbSet<FoodStrategy> FoodStrategy { get; set; }
        public DbSet<Ingredient> Ingredients { get; set;}
        public DbSet<Meal> Meals { get; set; }  
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=AvangersDietDB;uid=sa;pwd=123;trustservercertificate=true;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategorySeed());
            modelBuilder.ApplyConfiguration(new FoodSeed());
            base.OnModelCreating(modelBuilder);
        }

    }
}
