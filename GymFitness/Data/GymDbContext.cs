using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GymFitness.Models
{
    public class GymDbContext : IdentityDbContext<User>
    {
        public GymDbContext(DbContextOptions<GymDbContext> options)
            : base(options)
        {
        }

        public DbSet<Workout> Workouts { get; set; }
    }
}
