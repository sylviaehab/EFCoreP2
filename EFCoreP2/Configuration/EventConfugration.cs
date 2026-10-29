using EFCoreP2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreP2.Configuration
{
    public class EventConfugration:IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> modelBuilder)
        {
            modelBuilder
            .HasOne(e => e.Organizer)
            .WithMany(o => o.Event)
            .HasForeignKey(e => e.OrganizerId)
            .IsRequired();
        }
      
    }
}
