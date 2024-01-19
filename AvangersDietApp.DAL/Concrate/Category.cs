using AvangersDietApp.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvangersDietApp.DAL.Concrate
{
    public class Category:BaseEntity
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public List<Food> Foods { get; set; }

        public override string ToString()
        {
            return CategoryName;
        }

    }
}
