using Microsoft.AspNetCore.Mvc;
using FirstWebApi.Models;
using FirstWebApi.Filters;
namespace FirstWebApi.Controllers
{
    [ApiController]
    
    [Route("[controller]")]
    [CustomAuthFilter]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<List<Employee>> GetStandard()
        {
            // Throw an exception to test the CustomExceptionFilter
            throw new Exception("This is a sample exception.");

            // Uncomment this after testing
            // return Ok(GetStandardEmployeeList());
        }
        [HttpPost]
        public IActionResult AddEmployee([FromBody] Employee employee)
        {
            return Ok(employee);
        }

        private List<Employee> GetStandardEmployeeList()
        {
            return new List<Employee>
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
                        new Skill{ Id=1, Name="C#" },
                        new Skill{ Id=2, Name=".NET" }
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
                        new Skill{ Id=3, Name="SQL" }
                    }
                }
            };
        }
    }
}