using AvangersDietApp.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AvangersDietApp.BLL.Abstract
{
    public interface IRepository<BaseEntity> 
    {
        List<BaseEntity> GetAll(Expression<Func<BaseEntity, bool>> filter = null);

        BaseEntity Get(Expression<Func<BaseEntity, bool>> filter);
        void Add(BaseEntity entity);
        void Update(BaseEntity entity);
        void Delete(BaseEntity entity);


    }
}
