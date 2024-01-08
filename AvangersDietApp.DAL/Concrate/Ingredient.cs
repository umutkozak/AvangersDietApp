using AvangersDietApp.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvangersDietApp.DAL.Concrate
{
    public class Ingredient: BaseEntity
    {
        public Food Food { get; set; }
        public double Amount { get; set; }
        public Ingredient(Food food,double amount)
        {
            Food = food;
            Amount = amount;
        }
        public Ingredient()
        {

        }
    }
}
