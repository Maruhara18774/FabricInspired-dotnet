using Fabric.Data.Entities;
using Fabric.Data.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(x => x.ID);

            builder.HasOne(x => x.Pattern).WithMany(x => x.Products).HasForeignKey(x => x.PatternID);
            builder.HasOne(x => x.Category).WithMany(x => x.Products).HasForeignKey(x => x.CategoryID);

            builder.Property(x => x.Name).HasMaxLength(150);
            builder.Property(x => x.Weight).HasDefaultValue(WeightEnum.Midweight);
            builder.Property(x => x.Stretch).HasDefaultValue(StretchEnum.NonStretch);
        }
    }
}
