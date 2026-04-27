using G_NET_33_EFCore02.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_33_EFCore02.Configurations
{
    public class BadgeConfiguration : IEntityTypeConfiguration<Badge>
    {
        public void Configure(EntityTypeBuilder<Badge> builder)
        {
            builder.ToTable("Badges"); 
            builder.HasKey(p=>p.Id);
            builder.Property(p=>p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.BadgeNumber).IsRequired().HasMaxLength(50);
            builder.Property(p=>p.Tier).IsRequired().HasMaxLength(50);  

        }
    }
}
