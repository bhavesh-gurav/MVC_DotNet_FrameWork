using DotNetCoreCarProject.WebApp._4.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCoreCarProject.WebApp._4.DataAccess.EntityConfiguration
{
    public class CarConfiguration : IEntityTypeConfiguration<CarEntity>
    {
        public void Configure(EntityTypeBuilder<CarEntity> builder)
        {
            builder.ToTable("Car");
            builder.HasKey(PrimaryKey => PrimaryKey.Id);
        }
    }
}
