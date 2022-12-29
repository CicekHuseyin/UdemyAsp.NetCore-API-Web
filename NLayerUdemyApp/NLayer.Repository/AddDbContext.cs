using Microsoft.EntityFrameworkCore;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository
{
    public class AddDbContext : DbContext
    {
        #region Notlarım
        /*
         DbContextOption ı kullanmamızın sebebi veritabanı yolunu startup dan verebilmek için kullandık.
         */
        #endregion
        public AddDbContext(DbContextOptions<AddDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductFeature> Products { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }

        // Model Yüklenirken
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Bu kod yapmış olduğumuz tüm configuration işlemlerini modele aktarır.
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //ProductFeature ın değerlerini seed class ı yerine burada da girebiliriz.
            modelBuilder.Entity<ProductFeature>().HasData(new ProductFeature()
            {
                Id = 1,
                Color = "Kırmızı",
                Height = 100,
                Width = 200,
                ProductId = 1
            },
            new ProductFeature()
            {
                Id = 2,
                Color = "Yeşil",
                Height = 300,
                Width = 500,
                ProductId = 2
            }
            );



        }


    }
}
