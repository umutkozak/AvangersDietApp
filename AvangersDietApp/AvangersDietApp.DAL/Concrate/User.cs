using AvangersDietApp.DAL.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvangersDietApp.DAL.Concrate
{
    public class User: Abstract.BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Weight { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }

        public List<UserMealFood> UserMealFoods { get; set; } = new();

    }
}
