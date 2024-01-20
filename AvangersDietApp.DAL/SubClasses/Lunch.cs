using AvangersDietApp.DAL.Concrate;
using AvangersDietApp.DAL.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvangersDietApp.DAL.SubClasses
{
    public class Lunch:Meal
    {
        public virtual string MealName => "Öğle Yemeği";

        public MealType  MealType    { get; set; }
    }
}
