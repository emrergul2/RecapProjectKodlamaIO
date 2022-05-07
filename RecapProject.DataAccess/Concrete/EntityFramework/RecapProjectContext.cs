using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using RecapProject.Entities.Concrete;

namespace RecapProject.DataAccess.Concrete.EntityFramework
{
    public class RecapProjectContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-2322UUL\SQLSERVER;Database=RecapProject;User Id=sa;Password=12345");
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-2322UUL\SQLSERVER;Initial Catalog=RecapProject;User ID=sa;Password=12345");
        }
        //"Data Source=DESKTOP-2322UUL\SQLSERVER;Initial Catalog=RecapProject;User ID=sa;Password=12345";
        public DbSet<Car> Cars { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Brand> Brands { get; set; }
    }
}