using AvangersDietApp.DAL.Abstract;
using AvangersDietApp.DAL.Contract;
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

        public MealType MealType { get; set; }
        public int MealId { get; set; }
        public int FoodId { get; set; }
        public DateTime MealTime { get; set; }
        public string MealName { get; }

        public double Calorie { get; set; }

        public List<UserMealFood> UserMealFoods { get; set; } = new();


    }
}
