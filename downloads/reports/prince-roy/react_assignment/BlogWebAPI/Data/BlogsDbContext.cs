using BlogWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogWebAPI.Data
{
    public class BlogsDbContext : DbContext
    {
        public BlogsDbContext(DbContextOptions<BlogsDbContext> options) : base(options) { }
        public DbSet<Blog> Blogs { get; set; }
    }
}


