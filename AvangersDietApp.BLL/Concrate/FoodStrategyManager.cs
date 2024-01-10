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
    public class FoodStrategyManager : IRepository<FoodStrategy>
    {
        AvangersContext avangersContext = new AvangersContext();

        public void Add(FoodStrategy entity)
        {
            avangersContext.Add(entity);
            avangersContext.SaveChanges();
        }


        public void Delete(FoodStrategy entity)
        {
            avangersContext.Remove(entity);
            avangersContext.SaveChanges();
        }

        public FoodStrategy Get(Expression<Func<FoodStrategy, bool>> filter)
        {
            return avangersContext.Set<FoodStrategy>().SingleOrDefault(filter);
            throw new NotImplementedException();
        }

        public List<FoodStrategy> GetAll(Expression<Func<FoodStrategy, bool>> filter = null)
        {
            return filter==null ? avangersContext.Set<FoodStrategy>().ToList() : avangersContext.Set<FoodStrategy>().Where(filter).ToList();
        }

        public void Update(FoodStrategy entity)
        {
            avangersContext.Entry(entity).State =Microsoft.EntityFrameworkCore.EntityState.Modified;
            avangersContext.SaveChanges();
        }
    }
}
