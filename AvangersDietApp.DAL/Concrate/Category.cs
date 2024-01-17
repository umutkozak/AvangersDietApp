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
        public string Name { get; set; }

        public List<Food> Foods { get; set; }
    }
}
