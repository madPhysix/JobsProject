using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobsProject.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class EmployeesController : Controller
    {

        private readonly ApplicationContext _context;
        public EmployeesController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]

        public List<Employees> ShowEmployees()
        {
           
            
                return _context.Employee.ToList();
            
        }

       

        [HttpPost]

        public void AddEmployees(string fname, string lname, int age, double salary) {

             // создаем объект User
             Employees tom = new Employees(fname, lname, age, salary);
    
             
             
                _context.Employee.Add(tom);
                _context.SaveChanges();
             
            }
        }
    }
