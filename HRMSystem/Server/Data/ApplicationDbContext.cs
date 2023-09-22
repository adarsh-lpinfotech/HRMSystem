using HRMSystem.Shared.Models;
using Microsoft.AspNetCore.DataProtection.XmlEncryption;
using Microsoft.EntityFrameworkCore;

namespace HRMSystem.Server.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext()
        {
        }

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
            //modelBuilder.Entity<Employee>().HasData(
            //    new Employee
            //    {
            //        ID = 1,
            //        FirstName = "FirstName1",
            //        LastName = "LastName1",
            //        Gender = "Male",
            //        DepartmentId  = 1234,
            //        Created = new DateTime(2023, 8, 27, 8, 30, 39, 999),
            //        IsDeleted = false
            //    },
            //    new Employee
            //    {
            //        ID = 2,
            //        FirstName = "FirstName2",
            //        LastName = "LastName2",
            //        Gender = "Male",
            //        DepartmentId = 1235,
            //        Created = new DateTime(2022, 8, 27, 8, 30, 39, 999),
            //        IsDeleted = false
            //    }
            //);
            //modelBuilder.Entity<Department>().HasData(
            //    new Department
            //    {
            //        Id = 1234,
            //        Name = "Department1"
            //    },
            //    new Department
            //    {
            //        Id = 1235,
            //        Name = "Department2"
            //    }
            //    );
        }
    }
}
        