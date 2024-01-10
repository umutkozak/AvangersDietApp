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
    public class IngredientManager : IRepository<Ingredient>
    {
        AvangersContext avangersContext = new AvangersContext();

        public void Add(Ingredient entity)
        {
            avangersContext.Add(entity);
            avangersContext.SaveChanges();
        }

        public void Delete(Ingredient entity)
        {
            avangersContext.Remove(entity);
            avangersContext.SaveChanges();
        }

        public Ingredient Get(Expression<Func<Ingredient, bool>> filter)
        {
            return avangersContext.Set<Ingredient>().SingleOrDefault(filter);
            throw new NotImplementedException();
        }

        public List<Ingredient> GetAll(Expression<Func<Ingredient, bool>> filter = null)
        {
            return filter==null ? avangersContext.Set<Ingredient>().ToList() : avangersContext.Set<Ingredient>().Where(filter).ToList();
        }

        public void Update(Ingredient entity)
        {
            avangersContext.Entry(entity).State =Microsoft.EntityFrameworkCore.EntityState.Modified;
            avangersContext.SaveChanges();
        }
    }
}
