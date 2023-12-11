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
    public class SocialMediaRepository : GenericRepository<SocialMedia>, ISocialMediaRepository
    {
        public SocialMediaRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
