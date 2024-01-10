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
    public class UserManager : IRepository<User>
    {
        AvangersContext avangersContext = new AvangersContext();

        public void Add(User entity)
        {
            avangersContext.Add(entity);
            avangersContext.SaveChanges();
        }

        public void Delete(User entity)
        {
            avangersContext.Remove(entity);
            avangersContext.SaveChanges();
        }

        public User Get(Expression<Func<User, bool>> filter)
        {
            return avangersContext.Set<User>().SingleOrDefault(filter);
            throw new NotImplementedException();
        }

        public List<User> GetAll(Expression<Func<User, bool>> filter = null)
        {
            return filter==null ? avangersContext.Set<User>().ToList() : avangersContext.Set<User>().Where(filter).ToList();
        }

        public void Update(User entity)
        {
            avangersContext.Entry(entity).State =Microsoft.EntityFrameworkCore.EntityState.Modified;
            avangersContext.SaveChanges();
        }
    }
}
