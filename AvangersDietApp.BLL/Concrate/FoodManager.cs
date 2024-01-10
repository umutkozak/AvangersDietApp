using AvangersDietApp.BLL.Abstract;
using AvangersDietApp.DAL.Concrate;
using AvangersDietApp.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AvangersDietApp.BLL.Concrate
{
    public class FoodManager : IRepository<Food>
    {
        AvangersContext avangersContext = new AvangersContext();

        public void Add(Food entity)
        {
            avangersContext.Add(entity);
            avangersContext.SaveChanges();
        }

        public void Delete(Food entity)
        {
            avangersContext.Remove(entity);
            avangersContext.SaveChanges();
        }

        public Food Get(Expression<Func<Food, bool>> filter)
        {
            return avangersContext.Set<Food>().SingleOrDefault(filter);
            throw new NotImplementedException();
        }

        public List<Food> GetAll(Expression<Func<Food, bool>> filter = null)
        {
            return filter==null ? avangersContext.Set<Food>().ToList() : avangersContext.Set<Food>().Where(filter).ToList();
        }

        public void Update(Food entity)
        {
            avangersContext.Entry(entity).State =Microsoft.EntityFrameworkCore.EntityState.Modified;
            avangersContext.SaveChanges();
        }
    }
}
