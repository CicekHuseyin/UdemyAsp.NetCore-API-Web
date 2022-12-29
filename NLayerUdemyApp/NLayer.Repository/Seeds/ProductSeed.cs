using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NLayer.Repository.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
            new Product { Id = 1, CategoryId = 1, Name = "Kalem 1", Price = 100, Stock = 20, CreateDate = DateTime.Now },
            new Product { Id = 2, CategoryId = 1, Name = "Kalem 2", Price = 200, Stock = 34, CreateDate = DateTime.Now },
            new Product { Id = 3, CategoryId = 1, Name = "Kalem 3", Price = 400, Stock = 58, CreateDate = DateTime.Now },
            new Product { Id = 4, CategoryId = 2, Name = "Defter 1", Price = 15, Stock = 50, CreateDate = DateTime.Now },
            new Product { Id = 5, CategoryId = 2, Name = "Defter 2", Price = 28, Stock = 60, CreateDate = DateTime.Now },
            new Product { Id = 6, CategoryId = 3, Name = "Kitap 1", Price = 10, Stock = 29, CreateDate = DateTime.Now },
            new Product { Id = 7, CategoryId = 3, Name = "Kitap 2", Price = 18, Stock = 36, CreateDate = DateTime.Now }
            );
        }
    }
}
