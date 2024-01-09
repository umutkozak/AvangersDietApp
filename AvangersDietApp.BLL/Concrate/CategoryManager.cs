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
    public class CategoryManager : IRepository<Category>
    {
        AvangersContext avangersContext=new AvangersContext();
        public void Add(Category entity)
        {
            avangersContext.Add(entity);
            avangersContext.SaveChanges();
        }

        public void Delete(Category entity)
        {
            avangersContext.Remove(entity);
            avangersContext.SaveChanges();
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            return avangersContext.Set<Category>().SingleOrDefault(filter);
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            return filter==null?avangersContext.Set<Category>().ToList():avangersContext.Set<Category>().Where(filter).ToList();
        }

        public void Update(Category entity)
        {
            avangersContext.Entry(entity).State =Microsoft.EntityFrameworkCore.EntityState.Modified;
            avangersContext.SaveChanges();
        }
    }
}
