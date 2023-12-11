using Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL
{
    public class AppDbContext : DbContext
    {
        DbSet<Employeer> Employeers { get; set; }
        DbSet<EmployeerPosition> EmployeerPositions { get; set; }
        DbSet<SocialMedia> SocialMediaAccounts { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeSocialMedia>()
            .HasKey(es => new { es.EmployeerId, es.SocialMediaId });
        }
    }



}
