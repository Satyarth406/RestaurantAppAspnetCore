using EFcoreImplementation.Models;
using Microsoft.EntityFrameworkCore;

namespace EFcoreImplementation.Context
{
    public class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options):
            base(options)
        {

        }
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
