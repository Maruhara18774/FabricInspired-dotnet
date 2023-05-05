using Fabric.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric.Data.Configurations
{
    public class MoonboardConfiguration : IEntityTypeConfiguration<Moonboard>
    {
        public void Configure(EntityTypeBuilder<Moonboard> builder)
        {
            builder.ToTable("Moonboards");

            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.User).WithMany(x => x.Moonboards).HasForeignKey(x => x.UserID);
            builder.HasOne(x => x.Product).WithMany(x => x.Moonboards).HasForeignKey(x => x.ProductID);
        }
    }
}
