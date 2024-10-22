using Microsoft.EntityFrameworkCore;

namespace ASPDotNetCoreMVC.Models
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<User> Users { get; set; }

    }
}
