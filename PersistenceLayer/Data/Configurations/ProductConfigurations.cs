using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistenceLayer.Data.Configurations
{
    internal class ProductConfigurations : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasOne(P => P.ProductBrand)
                 .WithMany()
                 .HasForeignKey(P => P.BrandId);


            builder.HasOne(P => P.ProductType)
             .WithMany()
             .HasForeignKey(P => P.TypeId);


            builder.Property(p => p.Name).HasColumnType("nvarchar(200)");
            builder.Property(p => p.Description).HasColumnType("nvarchar(500)");




            builder.Property(p => p.Price).HasColumnType("decimal(10,2)");
        }
    }
}
