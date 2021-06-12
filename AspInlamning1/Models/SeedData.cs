using AspInlamning1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspInlamning1.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new EventDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<EventDbContext>>()))
            {
                // Look for any attendees.
                if (context.Attendees.Any())
                {
                    return;   // DB has been seeded
                }
                // Look for any events.
                if (context.Events.Any())
                {
                    return;   // DB has been seeded
                }

                context.Attendees.AddRange(
                    new Models.Attendee
                    {
                        Name = "test",
                        Email = "test",
                        PhoneNumber = "1234567890"
                    });

                context.Events.AddRange(
                    new Models.Event
                    {
                        Title = "Pokémon hunting",
                        Description = "A once in a lifetime opportunity to catch some pokermans!",
                        Place = "Safari Zone",
                        Address = "Team Rocket Hideout 666",
                        Date = DateTime.Now.AddDays(120),
                        SpotsAvailable = 10,
                    },
                    new Models.Event
                    {
                        Title = "Rock Concert",
                        Description = "First concert since covid lockdown!!",
                        Place = "Rock harbor",
                        Address = "Street of Satan 999",
                        Date = DateTime.Now.AddDays(90),
                        SpotsAvailable = 3,
                    }

                );

                context.SaveChanges();
            }
        }
    }
}
