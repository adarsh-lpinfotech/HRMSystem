using HRMSystem.Shared.Models;

namespace HRMSystem.Server.Interfaces
{
    public interface IEmployee
    {
        public List<Employee> GetEmployeeDetails();
        public Employee GetEmployeeData(int id);
    }
}


