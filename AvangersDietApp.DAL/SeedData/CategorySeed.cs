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
            builder.HasData(
                new Category() { Id = 1, Name = "Et" },
                new Category() { Id = 2, Name = "Meyve"},
                new Category() { Id = 3, Name = "Sebze" },
                new Category() { Id = 4, Name = "Atıştırmalık" },
                new Category() { Id = 5, Name = "Süt Ürünleri" }

                );
        }
    }
}
