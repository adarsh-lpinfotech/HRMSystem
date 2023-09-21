using HRMSystem.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace HRMSystem.Server.Data
{
    public class ApplicationDbContext: DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define the relationship between Employee and Department
            //modelBuilder.Entity<Employee>()
            //    .HasOne(e => e.Department)
            //    .WithMany(e => e.Employee)
            //    .HasForeignKey(e => e.DepartmentId)
            //    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
        