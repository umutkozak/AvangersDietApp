using AvangersDietApp.DAL.Concrate;
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
    public class CategorySeed:IEntityTypeConfiguration<Category>
    {
        
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            //builder.HasData(
            //    new Category() { Id = 1, CategoryName = "Et" },
            //    new Category() { Id = 2, CategoryName = "Meyve"},
            //    new Category() { Id = 3, CategoryName = "Sebze ve Bakliyat" },
            //    new Category() { Id = 4, CategoryName = "Atıştırmalık" },
            //    new Category() { Id = 5, CategoryName = "Süt Ürünleri" },
            //    new Category() { Id = 6, CategoryName = "Diğer Ürünler" },
            //    new Category() { Id = 7, CategoryName = "Unlu Ürünler" },
            //    new Category() { Id = 8, CategoryName = "Tatlılar" },
            //    new Category() { Id = 9, CategoryName = "Çerez ve Kuru Yemiş" }


            //    );
        }
    }
}
