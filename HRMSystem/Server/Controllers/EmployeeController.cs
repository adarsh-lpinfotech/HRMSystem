using HRMSystem.Server.Interfaces;
using HRMSystem.Server.Services;
using HRMSystem.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HRMSystem.Server.Controllers
{
    [Route("employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeManager _employeeManager;

        public EmployeeController(EmployeeManager employeeManager)
        {
            _employeeManager = employeeManager;
        }

        [HttpGet]
        public async Task<List<Employee>> Get()
        {
            return await Task.FromResult(_employeeManager.GetEmployeeDetails());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Employee employee = _employeeManager.GetEmployeeData(id);
            if (employee != null)
            {
                return Ok(employee);
            }
            return NotFound();
        }
        [HttpPost]
        public void Post(Employee employee)
        {
            _employeeManager.AddEmployee(employee);
        }
    }

}
