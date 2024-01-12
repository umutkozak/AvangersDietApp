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
                new Food() {Id=1,Name="Beyaz peynir",Proteins=22.5,Carbohydrates=0,Fats=4.4,Calories=289,CategoryId=5}
                );
        }
    }
}
