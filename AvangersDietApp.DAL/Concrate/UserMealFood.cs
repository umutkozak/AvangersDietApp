using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvangersDietApp.DAL.Concrate
{
    public class UserMealFood
    {
        public int UserId { get; set; }

        public int MealId { get; set; }

        public int FoodId { get; set; }

        public bool IsActive { get; set; }



        public User? User { get; set; }

        public Meal? Meal { get; set; }

        public Food? Food { get; set; }

     
    }
}
