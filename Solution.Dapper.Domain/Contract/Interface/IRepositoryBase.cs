using Solution.Dapper.Domain.Models.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Dapper.Domain.Contract.Interface
{
    public interface IRepositoryBase<TEntity> where TEntity : EntityBase
    {
        Task<IEnumerable<TEntity>> GetAll();
        TEntity GetById(int id);
        void Insert(ref TEntity entity);
        bool Update(TEntity entity);
        bool Delete(Int32 id);
        IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> predicate);
    }
}
