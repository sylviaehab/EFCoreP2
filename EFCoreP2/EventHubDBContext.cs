using EFCoreP2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreP2
{
    public class EventHubDBContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<OrganizerProfile> OrganizerProfiles { get; set; }
        public DbSet<Badge> Badges { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-1840995\\SQLEXPRESS03;Database=EFCoreP2;Trusted_Connection=True;trustservercertificate=true");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EventHubDBContext).Assembly);
            modelBuilder.Entity<OrganizerProfile>()
                .HasOne(p=>p.Organizer).
                WithOne(o=>o.OrganizerProfile)
                .HasForeignKey<OrganizerProfile>(p => p.OrganizerID)
                .IsRequired().
                OnDelete(DeleteBehavior.NoAction);
            
            modelBuilder.Entity<Badge>().
                HasOne(b=>b.Attendee)
                .WithOne(a => a.Badge)
                .HasForeignKey<Badge>(b=>b.AttendeeId)
                .IsRequired();
        }
    }
    }

