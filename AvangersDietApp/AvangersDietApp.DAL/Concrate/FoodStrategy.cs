using AvangersDietApp.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvangersDietApp.DAL.Concrate
{
    public class FoodStrategy: BaseEntity
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public List<Food> Foodlist { get; set; }

        public FoodStrategy(User user)
        {
            //Todo:userıd ve new list foodlist
        }
        public FoodStrategy()
        {

        }

    }
}
