using Core.Models;
using Core.Repositories.Interfaces;
using Data.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.Implementations
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseModel, new()
    {
        private readonly AppDbContext _db;
        public DbSet<TEntity> Table { get => _db.Set<TEntity>(); }

        public GenericRepository(AppDbContext dbContext)
        {
            _db = dbContext;
        }


        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>>? expression = null, string[]? includedTables = null)
        {
            var query = GetQuery(includedTables);

            return expression is not null ? await query.Where(expression).ToListAsync() : await query.ToListAsync();


        }


        /*       public Task Query(Expression<Func<TEntity, bool>>? expression = null, string[]? includingTables = null)
               {
                   throw new NotImplementedException();
               }*/

        private IQueryable<TEntity> GetQuery(string[]? includingTables = null)
        {
            var query = Table.AsQueryable();

            if(includingTables is not null)
            {
                foreach(string tableName in includingTables)
                {
                    query = query.Include(tableName);
                }
            }

            return query;
        }

        public async Task Create(TEntity entity)
        {
            await Table.AddAsync(entity);
        }
    }
}
