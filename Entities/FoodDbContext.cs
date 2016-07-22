using Microsoft.EntityFrameworkCore;

namespace OdeToFood.Entities
{
    public class FoodDbContext : DbContext
    {
        public FoodDbContext (DbContextOptions<FoodDbContext> options) : base(options) { }

        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
