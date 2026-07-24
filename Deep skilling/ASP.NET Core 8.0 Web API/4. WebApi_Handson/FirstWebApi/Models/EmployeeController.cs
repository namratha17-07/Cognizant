using Microsoft.AspNetCore.Mvc;
using FirstWebApi.Models;

namespace FirstWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    // [CustomAuthFilter]   // Commented for CRUD testing
    public class EmployeeController : ControllerBase
    {
        // Hardcoded Employee List
        private static List<Employee> employees = new List<Employee>
        {
            new Employee
            {
                Id = 1,
                Name = "Dhanush",
                Salary = 50000,
                Permanent = true,
                DateOfBirth = new DateTime(2004,1,15),
                Department = new Department
                {
                    Id = 101,
                    Name = "IT"
                },
                Skills = new List<Skill>
                {
                    new Skill
                    {
                        Id = 1,
                        Name = "C#"
                    },
                    new Skill
                    {
                        Id = 2,
                        Name = ".NET"
                    }
                }
            },
            new Employee
            {
                Id = 2,
                Name = "Rahul",
                Salary = 45000,
                Permanent = false,
                DateOfBirth = new DateTime(2003,8,20),
                Department = new Department
                {
                    Id = 102,
                    Name = "HR"
                },
                Skills = new List<Skill>
                {
                    new Skill
                    {
                        Id = 3,
                        Name = "SQL"
                    }
                }
            }
        };

        // GET
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<Employee>> GetEmployees()
        {
            return Ok(employees);
        }

        // POST
        [HttpPost]
        public ActionResult<Employee> AddEmployee([FromBody] Employee employee)
        {
            employees.Add(employee);
            return Ok(employee);
        }

        // PUT
        [HttpPut]
        public ActionResult<Employee> UpdateEmployee([FromBody] Employee employee)
        {
            if (employee.Id <= 0)
            {
                return BadRequest("Invalid employee id");
            }

            var existingEmployee = employees.FirstOrDefault(e => e.Id == employee.Id);

            if (existingEmployee == null)
            {
                return BadRequest("Invalid employee id");
            }

            existingEmployee.Name = employee.Name;
            existingEmployee.Salary = employee.Salary;
            existingEmployee.Permanent = employee.Permanent;
            existingEmployee.Department = employee.Department;
            existingEmployee.Skills = employee.Skills;
            existingEmployee.DateOfBirth = employee.DateOfBirth;

            return Ok(existingEmployee);
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteEmployee(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid employee id");
            }

            var employee = employees.FirstOrDefault(e => e.Id == id);

            if (employee == null)
            {
                return BadRequest("Invalid employee id");
            }

            employees.Remove(employee);

            return Ok("Employee deleted successfully");
        }
    }
}