using Microsoft.EntityFrameworkCore;
using BrightwayCodeTest.Models;

namespace BrightwayCodeTest.Data
{
    public class TripContext : DbContext
    {
        public TripContext(DbContextOptions<TripContext> options) : base(options)
        {
        }

        //public DbSet<User> Users { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<CountryList> CountryList { get; set; }
    }
}
