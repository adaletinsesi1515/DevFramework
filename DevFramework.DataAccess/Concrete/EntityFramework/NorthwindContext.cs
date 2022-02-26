using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.DataAccess.Concrete.EntityFramework.Mappings;
using DevFramework.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DevFramework.DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext : DbContext
    {
       
        public DbSet<Product> Products { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            return;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductMap());
        }
    }
}
