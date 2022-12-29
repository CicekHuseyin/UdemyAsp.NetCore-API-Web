using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        #region Notlarım
        /*
         Bu metod da yazmış olduğum kodlar veritabanın daki verilerin özelliklerini değiştirtir.
         */
        #endregion

        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id); //Id primerkey
            builder.Property(x => x.Id).UseIdentityColumn(); //Id 1 er 1 er otomatik artan
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50); //Veri girilmesi zorunlu

            builder.ToTable("Categories"); // Tablo adını değiştirebilirsin.
        }
    }
}
