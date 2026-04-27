using G_NET_33_EFCore02.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_33_EFCore02.Context
{
    public class EventHupContext:DbContext
    {
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<OrganizerProfile> OrganizerProfiles { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Badge> Badges { get; set; }
        public DbSet<Address> Addresses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localhost\\SQLEXPRESS01; database=EventHup;trusted_Connection=true;trustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrganizerProfile>(entity =>
            {
                entity.ToTable("OrganizerProfiles");
                entity.HasKey(p => p.Id);   
                entity.Property(p=>p.WebsiteUrl).IsRequired(false).HasMaxLength(2000);
                entity.Property(p=>p.OrganizerId).IsRequired().HasMaxLength(100);  
                entity.Property(p=>p.Logo).IsRequired(false);  
                entity.Property(p=>p.Bio).IsRequired(false).HasColumnType("TEXT");  

            });

            modelBuilder.Entity<Address>(address=>
            {
                address.ToTable("Addresses");
                address.HasKey(p => p.Id);
                address.Property(p=>p.Country).IsRequired().HasMaxLength(100);  
                address.Property(p=>p.City).IsRequired().HasMaxLength(100);  
                address.Property(p=>p.Street).IsRequired().HasMaxLength(100);  
                address.Property(p=>p.PostalCode).IsRequired().HasMaxLength(20);  
                
            });
            modelBuilder.Entity<Registration>(register =>
            {
                register.ToTable("Registrations");
                register.HasKey(p => new {p.EventId,p.AttendeeId});
                register.Property(p=>p.RegisteredAt).IsRequired();
                register.Property(p=>p.NoteToOrganizer).IsRequired(false);

            });
        }

    }
}
