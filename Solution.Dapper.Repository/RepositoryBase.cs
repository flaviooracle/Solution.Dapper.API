using Dommel;
using Solution.Dapper.Domain.Contract.Interface;
using Solution.Dapper.Domain.Models.BaseModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Dapper.Repository
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : EntityBase
    {

        protected readonly string ConnectionString;
        protected readonly int CommandTimeout;

        protected RepositoryBase()
        {
            CommandTimeout = 0;
            ConnectionString = "Password=123;Persist Security Info=True;User ID=sa;Initial Catalog=ConspiracaoDB;Data Source=DESKTOP-EUD6FT9\\SQLEXPRESS";
        }

        public virtual async Task<IEnumerable<TEntity>> GetAll()
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                return db.GetAll<TEntity>();
            }
        }

        public virtual TEntity GetById(int id)
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                return db.Get<TEntity>(id);
            }
        }

        public virtual void Insert(ref TEntity entity)
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                var id = db.Insert(entity);

                entity = GetById((int)id);
            }
        }

        public virtual bool Update(TEntity entity)
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                return db.Update(entity);
            }
        }

        public virtual bool Delete(Int32 id)
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                var entity = GetById(id);

                if (entity == null) throw new Exception("Registro não encontrado");

                return db.Delete(entity);
            }
        }

        public virtual IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> predicate)
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                return db.Select(predicate);
            }
        }
    }
}
