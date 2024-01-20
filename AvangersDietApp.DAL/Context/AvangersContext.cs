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
using System.Collections;
using System.Reflection;

namespace AvangersDietApp.DAL.Context
{
    public class AvangersContext: DbContext
    {
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Food> Food { get; set; }
        public DbSet<FoodStrategy> FoodStrategy { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserMealFood> UserMealFoods { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=AvangersDietDB;uid=sa;pwd=123;trustservercertificate=true;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserMealFood>().HasKey(uf => new { uf.UserId, uf.MealId, uf.FoodId });

            modelBuilder.Entity<UserMealFood>()
                .HasOne(uf => uf.User)
                .WithMany(u => u.UserMealFoods)
                .HasForeignKey(uf => uf.UserId);

            modelBuilder.Entity<UserMealFood>()
                .HasOne(uf => uf.Meal)
                .WithMany(m => m.UserMealFoods)
                .HasForeignKey(uf => uf.MealId);

            modelBuilder.Entity<UserMealFood>()
                .HasOne(uf => uf.Food)
                .WithMany(f => f.UserMealFoods)
                .HasForeignKey(uf => uf.FoodId);

            //modelBuilder.ApplyConfiguration(new CategorySeed());
            modelBuilder.ApplyConfiguration(new FoodSeed());
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
              new Category() { Id = 1, CategoryName = "Et" },
              new Category() { Id = 2, CategoryName = "Meyve" },
              new Category() { Id = 3, CategoryName = "Sebze ve Bakliyat" },
              new Category() { Id = 4, CategoryName = "Atıştırmalık" },
              new Category() { Id = 5, CategoryName = "Süt Ürünleri" },
              new Category() { Id = 6, CategoryName = "Diğer Ürünler" },
              new Category() { Id = 7, CategoryName = "Unlu Ürünler" },
              new Category() { Id = 8, CategoryName = "Tatlılar" },
              new Category() { Id = 9, CategoryName = "Çerez ve Kuru Yemiş" });

        }
    }
}
