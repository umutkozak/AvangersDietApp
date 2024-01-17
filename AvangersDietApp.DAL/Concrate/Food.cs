using AvangersDietApp.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvangersDietApp.DAL.Concrate
{
    public class Food: BaseEntity
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public string? Description { get; set; }
        public double Carbohydrates { get; set; }
        public double Proteins { get; set; }
        public double Fats { get; set; }
        public double Calories { get; set; }
        public byte[]? Image { get; set; }

        public Category Category { get; set; } = null!;

        public List<UserMealFood> UserMealFoods { get; set; } = new();



        public override string ToString()
        {
            return Name;
        }
    }
}
