using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspInlamning1.Data
{
    public class EventDbContext : DbContext
    {
        //public DbSet<>
        public EventDbContext(DbContextOptions<EventDbContext> options)
            : base (options)
        {

        }

        public DbSet<Models.Attendee> Attendees { get; set; }
        public DbSet<Models.Organizer> Organizers { get; set; }
        public DbSet<Models.Event> Events { get; set; }
    }
}
