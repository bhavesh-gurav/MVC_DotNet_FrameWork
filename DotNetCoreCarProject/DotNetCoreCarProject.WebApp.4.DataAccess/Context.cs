using DotNetCoreCarProject.Common.Models;
using DotNetCoreCarProject.WebApp._4.DataAccess.Entities;
using DotNetCoreCarProject.WebApp._4.DataAccess.EntityConfiguration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCoreCarProject.WebApp._4.DataAccess
{
    public class Context : DbContext
    {
        public DbSet<CarEntity>? CarDbSet { get; set; }

        public Context(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CarConfiguration());
        }
    }
}
