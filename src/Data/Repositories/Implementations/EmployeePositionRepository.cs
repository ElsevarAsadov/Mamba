using Core.Models;
using Core.Repositories.Interfaces;
using Data.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.Implementations
{
    public class EmployeePositionRepository : GenericRepository<EmployeerPosition>, IEmployeePositionRepository
    {
        public EmployeePositionRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
