using FitKitAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FitKitAPI.Data
{
    public class FitKitDbContext : DbContext
    {
        public FitKitDbContext(DbContextOptions<FitKitDbContext> options) : base(options) { }

        public DbSet<UserCredential> UserCredential { get; set; }

        public DbSet<UserDetails> UserDetails { get; set; }

        public DbSet<Exercise> Exercise { get; set; }

        public DbSet<Workout> Workout { get; set; }


    }
}
