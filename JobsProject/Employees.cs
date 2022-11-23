using Microsoft.AspNetCore.Server.IIS.Core;

namespace JobsProject
{
    public class Employees
    {
        public int id { get; set; }
        public string firstName{ get; set; }
        public string lastName { get; set; }
        public int age{ get; set; }
        public double salary { get; set; }

        public Employees(string firstname, string lastname, int age, double salary)
        {
            this.firstName = firstname;
            this.lastName = lastname;
            this.age = age;
            this.salary = salary;
        }

        public Employees() { }
    }

   
}
