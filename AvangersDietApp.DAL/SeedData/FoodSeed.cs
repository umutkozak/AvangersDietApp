using AvangersDietApp.DAL.Concrate;
using AvangersDietApp.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvangersDietApp.DAL.SeedData
{
    public class FoodSeed : IEntityTypeConfiguration<Food>
    {        
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.HasData(
                
                new Food() { Id = 38, Name = "Kaşar peynir", Proteins = 22.5, Carbohydrates = 0, Fats = 4.4, Calories = 289, CategoryId = 5 },
                new Food() { Id = 2, Name = "Yoğur", Proteins = 3.5, Carbohydrates = 4.7, Fats = 3.3, Calories = 61, CategoryId = 5 },
                new Food() { Id = 3, Name = "Yumurta", Proteins = 12.1, Carbohydrates = 0, Fats = 11.2, Calories = 158, CategoryId = 6 },
                new Food() { Id = 4, Name = "Siyah Zeytin", Proteins = 0.15, Carbohydrates = 0, Fats = 4.4, Calories = 207, CategoryId = 6 },
                new Food() { Id = 5, Name = "Domates", Proteins = 1, Carbohydrates = 4, Fats = 0.3, Calories = 25, CategoryId = 3 },
                new Food() { Id = 6, Name = "Salatalık", Proteins = 1, Carbohydrates = 1, Fats = 0, Calories = 8, CategoryId = 3 },
                new Food() { Id = 7, Name = "Kabak", Proteins = 1, Carbohydrates = 0.6, Fats = 0.1, Calories = 26, CategoryId = 3 },
                new Food() { Id = 8, Name = "Ispanak", Proteins = 2.3, Carbohydrates = 3.2, Fats = 0.3, Calories = 25, CategoryId = 3 },
                new Food() { Id = 9, Name = "Karnabahar", Proteins = 2.4, Carbohydrates = 4.9, Fats = 0.2, Calories = 25, CategoryId = 3 },
                new Food() { Id = 10, Name = "Lahana", Proteins = 1.4, Carbohydrates = 5.3, Fats = 0.2, Calories = 24, CategoryId = 3 },
                new Food() { Id = 11, Name = "Mercimek", Proteins = 23.7, Carbohydrates = 57.4, Fats = 1.3, Calories = 351, CategoryId = 5 },
                new Food() { Id = 12, Name = "Nohut", Proteins = 19.2, Carbohydrates = 56.7, Fats = 6.2, Calories = 376, CategoryId = 3 },
                new Food() { Id = 13, Name = "Enginar", Proteins = 2.9, Carbohydrates = 11.9, Fats = 0.4, Calories = 63, CategoryId = 3 },
                new Food() { Id = 14, Name = "Pırasa", Proteins = 1.8, Carbohydrates = 13, Fats = 0.2, Calories = 52, CategoryId = 3 },
                new Food() { Id = 15, Name = "Bamya", Proteins = 6, Carbohydrates = 4, Fats = 0.1, Calories = 42, CategoryId = 3 },
                new Food() { Id = 16, Name = "Tavuk-but", Proteins = 21, Carbohydrates = 0, Fats = 3, Calories = 122, CategoryId = 1 },
                new Food() { Id = 17, Name = "Tavuk-göğüs", Proteins = 23, Carbohydrates = 0, Fats = 1, Calories = 104, CategoryId = 1 },
                new Food() { Id = 18, Name = "Hindi", Proteins = 20.4, Carbohydrates = 0, Fats = 8, Calories = 160, CategoryId = 1 },
                new Food() { Id = 19, Name = "Dana kıyma yağlı", Proteins = 20, Carbohydrates = 0, Fats = 3.6, Calories = 170, CategoryId = 1 },
                new Food() { Id = 20, Name = "Dana Eti", Proteins = 19.7, Carbohydrates = 0, Fats = 8, Calories = 156, CategoryId = 1 },
                new Food() { Id = 21, Name = "Salam", Proteins = 23.4, Carbohydrates = 0, Fats = 38.1, Calories = 450, CategoryId = 1 },
                new Food() { Id = 22, Name = "Sucuk", Proteins = 21.4, Carbohydrates = 0, Fats = 21.4, Calories = 452, CategoryId = 1 },
                new Food() { Id = 23, Name = "Makarna", Proteins = 12.5, Carbohydrates = 75.2, Fats = 1.2, Calories = 370, CategoryId = 7 },
                new Food() { Id = 24, Name = "Pirinç", Proteins = 21.4, Carbohydrates = 0, Fats = 21.4, Calories = 452, CategoryId = 7 },
                new Food() { Id = 25, Name = "Bulgur", Proteins = 10.3, Carbohydrates = 78.1, Fats = 1.2, Calories = 357, CategoryId = 7 },
                new Food() { Id = 26, Name = "Buğday Ekmeği", Proteins = 7.2, Carbohydrates = 53.1, Fats = 1.1, Calories = 247, CategoryId = 7 },
                new Food() { Id = 27, Name = "Bal", Proteins = 0.3, Carbohydrates = 78.4, Fats = 0, Calories = 315, CategoryId = 8 },
                new Food() { Id = 28, Name = "Çikolata", Proteins = 9.3, Carbohydrates = 51.3, Fats = 36, Calories = 550, CategoryId = 8 },
                new Food() { Id = 29, Name = "Marmelat ve Reçel", Proteins = 0.6, Carbohydrates = 70, Fats = 0.5, Calories = 275, CategoryId = 8 },
                new Food() { Id = 30, Name = "Muhallebi", Proteins = 5.1, Carbohydrates = 29.8, Fats = 3.8, Calories = 173, CategoryId = 8 },
                new Food() { Id = 31, Name = "Sütlaç", Proteins = 3.4, Carbohydrates = 38, Fats = 2.7, Calories = 140, CategoryId = 8 },
                new Food() { Id = 32, Name = "Badem", Proteins = 18.6, Carbohydrates = 19.8, Fats = 54.2, Calories = 600, CategoryId = 9 },
                new Food() { Id = 33, Name = "Ceviz", Proteins = 15, Carbohydrates = 15.8, Fats = 64, Calories = 650, CategoryId = 9 },
                new Food() { Id = 34, Name = "Fındık", Proteins = 12.6, Carbohydrates = 16.8, Fats = 62.4, Calories = 634, CategoryId = 9 },
                new Food() { Id = 35, Name = "Şam Fıstığı", Proteins = 19.5, Carbohydrates = 19, Fats = 54, Calories = 600, CategoryId = 9 },
                new Food() { Id = 36, Name = "Beyaz peynir", Proteins = 22.5, Carbohydrates = 0, Fats = 4.4, Calories = 289, CategoryId = 5 },
                new Food() { Id = 37, Name = "Elma", Proteins = 0.2, Carbohydrates = 15, Fats = 0.6, Calories = 58, CategoryId = 2 }
                //new Food() { Id = 19, Name = "Armut", Proteins = 0.7, Carbohydrates = 15.3, Fats = 0.4, Calories = 61, CategoryId = 2 },
                //new Food() { Id = 19, Name = "Çilek", Proteins = 0.7, Carbohydrates = 8.4, Fats = 0.5, Calories = 37, CategoryId = 2 },
                //new Food() { Id = 19, Name = "İncir", Proteins = 1.2, Carbohydrates = 20.4, Fats = 0.4, Calories = 80, CategoryId = 2 },
                //new Food() { Id = 19, Name = "Kayısı", Proteins = 1.0, Carbohydrates = 12.9, Fats = 0.2, Calories = 51, CategoryId = 2 },
                //new Food() { Id = 19, Name = "Kiraz", Proteins = 1.3, Carbohydrates = 17.4, Fats = 0.3, Calories = 70, CategoryId = 2 },
                //new Food() { Id = 19, Name = "Portakal", Proteins = 1.0, Carbohydrates = 12.3, Fats = 0.2, Calories = 50, CategoryId = 2 },
                //new Food() { Id = 19, Name = "Şeftali", Proteins = 0.6, Carbohydrates = 9.7, Fats = 0.2, Calories = 85, CategoryId = 2 },
                //new Food() { Id = 19, Name = "Muz", Proteins = 1.1, Carbohydrates = 11.6, Fats = 0.2, Calories = 50, CategoryId = 2 },
                //new Food() { Id = 19, Name = "Palamut", Proteins = 24.0, Carbohydrates = 0, Fats = 7.3, Calories = 168, CategoryId = 1 },
                //new Food() { Id = 19, Name = "Alabalık", Proteins = 18.3, Carbohydrates = 0, Fats = 10.0, Calories = 168, CategoryId = 1 },
                //new Food() { Id = 19, Name = "Levrek", Proteins = 19.2, Carbohydrates = 0, Fats = 01.2, Calories = 93, CategoryId = 1 },
                //new Food() { Id = 19, Name = "Uskumru", Proteins = 21.9, Carbohydrates = 0, Fats = 7.3, Calories = 159, CategoryId = 1 },
                //new Food() { Id = 19, Name = "Palamut", Proteins = 24.0, Carbohydrates = 0, Fats = 7.3, Calories = 168, CategoryId = 1 }
                );
        }
    }
}
