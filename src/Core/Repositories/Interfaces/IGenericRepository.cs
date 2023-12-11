using Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories.Interfaces
{
    public interface IGenericRepository<TEntity>  where TEntity : BaseModel, new() 
    {
        public DbSet<TEntity> Table { get;}

        public Task Create(TEntity entity);

        public Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>>? expression = null, string[]? includedTables = null);
        //public Task Query(Expression<Func<TEntity,bool>>? expression = null, string[]? includingTables = null);
        
    }
}
