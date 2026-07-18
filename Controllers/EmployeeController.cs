using Microsoft.AspNetCore.Mvc;

namespace EmployerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetEmployees()
        {
            var employees = new[]
            {
                new { Id = 1, Name = "Rahul", Department = "IT", Salary = 50000 },
                new { Id = 2, Name = "Priya", Department = "HR", Salary = 45000 },
                new { Id = 3, Name = "Amit", Department = "Finance", Salary = 60000 }
            };

            return Ok(employees);
        }

        [HttpGet("{id}")]
        public IActionResult GetEmployee(int id)
        {
            var employee = new
            {
                Id = id,
                Name = "Rahul",
                Department = "IT",
                Salary = 50000
            };

            return Ok(employee);
        }

        [HttpPost]
        public IActionResult AddEmployee([FromBody] Employee employee)
        {
            return Ok(new
            {
                Message = "Employee added successfully",
                Data = employee
            });
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Department { get; set; } = "";
        public decimal Salary { get; set; }
    }
}