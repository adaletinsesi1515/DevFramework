using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevFramework.DataAccess.Concrete.EntityFramework.Mappings
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
      
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable(@"Products", @"dto");
            builder.HasKey(x => x.ProductID);
            builder.Property(x => x.ProductID).HasColumnName("ProductID");
            builder.Property(x => x.CategoryID).HasColumnName("CategoryID");
            builder.Property(x => x.ProductName).HasColumnName("ProductName");



        }
    }
}
