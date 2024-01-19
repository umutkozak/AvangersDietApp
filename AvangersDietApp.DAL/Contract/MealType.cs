using System.ComponentModel;

namespace AvangersDietApp.DAL.Contract
{
    public enum MealType
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
