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
    public class MealManager : IRepository<Meal>
    {
        AvangersContext avangersContext = new AvangersContext();

        public void Add(Meal entity)
        {
            avangersContext.Add(entity);
            avangersContext.SaveChanges();
        }

        public void Delete(Meal entity)
        {
            avangersContext.Remove(entity);
            avangersContext.SaveChanges();
        }

        public Meal Get(Expression<Func<Meal, bool>> filter)
        {
            return avangersContext.Set<Meal>().SingleOrDefault(filter);
            throw new NotImplementedException();
        }

        public List<Meal> GetAll(Expression<Func<Meal, bool>> filter = null)
        {
            return filter == null ? avangersContext.Set<Meal>().ToList() : avangersContext.Set<Meal>().Where(filter).ToList();
        }

        public void Update(Meal entity)
        {
            avangersContext.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            avangersContext.SaveChanges();
        }
    }
}
