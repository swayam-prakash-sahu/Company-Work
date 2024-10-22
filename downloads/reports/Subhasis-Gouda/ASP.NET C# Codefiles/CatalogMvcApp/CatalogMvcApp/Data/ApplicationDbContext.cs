using Microsoft.EntityFrameworkCore;
using Mvcapp2.Models;
namespace Mvcapp2.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData
                (
                  new Category { CategoryId = 1, Name = "Business", Displayorder = 1 },
                  new Category { CategoryId = 2, Name = "Creation", Displayorder = 2 },
                  new Category { CategoryId = 3, Name = "Gaming", Displayorder = 3 },
                  new Category { CategoryId = 4, Name = "Student", Displayorder = 4 }
                );
        }
    }
}
