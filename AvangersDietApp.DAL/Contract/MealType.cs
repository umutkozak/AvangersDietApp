using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvangersDietApp.DAL.Contract
{
    public enum MealType // Öğün
    {
        [Description("Kahvaltı")]
        BreakFast,
        [Description("Öğle Yemeği")]
        Lunch,
        [Description("Akşam Yemeği")]
        Dinner,
        [Description("Ara Öğün")]
        Snack
    }
}
