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
    public class EventConfigurations : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.ToTable("Events");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.StartDate).IsRequired().HasMaxLength(100).HasDefaultValueSql("GetDate()");
            builder.Property(e => e.EndDate).IsRequired().HasMaxLength(100).HasDefaultValueSql("GetDate()");
            builder.Property(e => e.Description).IsRequired(false).HasMaxLength(500);
            builder.Property(e=>e.MaxAttendees).IsRequired().HasDefaultValue(1);  
            builder.Property(e=>e.Title).IsRequired().HasColumnName("Event Title").HasMaxLength(100); 


        }
    }
}
