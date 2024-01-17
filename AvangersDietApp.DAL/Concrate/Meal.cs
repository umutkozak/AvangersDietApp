using AvangersDietApp.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvangersDietApp.DAL.Concrate
{
    public class Meal: BaseEntity
    {
        public int UserId { get; set; }
        public int MealId { get; set; }
        public int FoodId { get; set; }
        public string Name { get; set; }
        public DateTime MealTime { get; set; }

        public List<Ingredient> MealList { get; set; } = new();

        public List<UserMealFood> UserMealFoods { get; set; } = new();
    

    }
}
