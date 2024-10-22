using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EmpView.EntityModel
{
    public partial class EntityDataModel : DbContext
    {
        public EntityDataModel()
            : base("name=EntityDataContext")
        {
        }

        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .Property(e => e.DeptName)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .HasMany(e => e.Employees)
                .WithOptional(e => e.Department)
                .HasForeignKey(e => e.DeptNo);

            modelBuilder.Entity<Department>()
                .HasMany(e => e.Employees1)
                .WithOptional(e => e.Department1)
                .HasForeignKey(e => e.DeptNo);

            modelBuilder.Entity<Employee>()
                .Property(e => e.EmpName)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Job)
                .IsUnicode(false);
        }
    }
}
