using System;
using System.Linq;
using BrightwayCodeTest.Models;
using Microsoft.EntityFrameworkCore;

namespace BrightwayCodeTest.Data
{
    public static class DbInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TripContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<TripContext>>()))
            {
                // Look for any trips.
                if (context.Trips.Any())
                {
                    return;   // DB has been seeded
                }

                context.Trips.AddRange(
                    new Trip
                    {
                        UserName = "Tevin Meredith",
                        UserEmail = "Fake@Gmail.com",
                        Destination = "Canada",
                        Currency = 100,
                        ConvertedCurrency = 126.40M,
                        Duration = 5
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
