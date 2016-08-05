using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace OdeToFood.Entities
{
    public class FoodDbContext : IdentityDbContext<User>
    {
        public FoodDbContext (DbContextOptions<FoodDbContext> options) : base(options) { }

        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
