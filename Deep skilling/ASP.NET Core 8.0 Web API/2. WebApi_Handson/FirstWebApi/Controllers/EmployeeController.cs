using Microsoft.AspNetCore.Mvc;

namespace FirstWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        static List<string> employees = new()
        {
            "Dhanush",
            "Rahul",
            "Priya",
            "Anil"
        };

        [HttpGet]
        public IActionResult GetEmployees()
        {
            return Ok(employees);
        }

        [HttpPost]
        public IActionResult AddEmployee(string name)
        {
            employees.Add(name);

            return Ok(employees);
        }
    }
}