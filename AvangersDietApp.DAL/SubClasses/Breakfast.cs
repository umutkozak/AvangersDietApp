using AvangersDietApp.DAL.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvangersDietApp.DAL.SubClasses
{
    public class Breakfast:Meal
    {
        public virtual string MealName => "Kahvaltı";
    }
}
