using HRMSystem.Server.Data;
using HRMSystem.Server.Interfaces;
using HRMSystem.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace HRMSystem.Server.Services
{
    public class EmployeeManager:IEmployee
    {
        readonly ApplicationDbContext _context = new();

        public EmployeeManager(ApplicationDbContext context)
        {
            _context = context;
        }

        public Employee GetEmployeeData(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetEmployeeDetails() 
        {
            try
            {
                return _context.Employees.ToList();
            }
            catch
            {
                throw;
            }
        }

        public void AddEmployee(Employee employee)
        {
            try
            {
                _context.Employees.Add(employee);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }


    }
}
