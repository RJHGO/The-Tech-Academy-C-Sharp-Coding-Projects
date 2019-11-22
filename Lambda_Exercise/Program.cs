using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Exercise
{
    class Program
    {
        class Employee
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int EmployeeId { get; set; }
          
        }
        static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>()
            {
            new Employee { FirstName = "Joe", LastName = "Newman", EmployeeId = 23 },
            new Employee { FirstName = "Mark", LastName = "Smith", EmployeeId = 765 },
            new Employee { FirstName = "Joe", LastName = "Watson", EmployeeId = 342 },
            new Employee { FirstName = "Pam", LastName = "Willis", EmployeeId = 912 },
            new Employee { FirstName = "Jerry", LastName = "Cantrell", EmployeeId = 190 },
            new Employee { FirstName = "Berry", LastName = "White", EmployeeId = 103 },
            new Employee { FirstName = "Alan", LastName = "Holdsworth", EmployeeId = 115 },
            new Employee { FirstName = "Nuno", LastName = "Bettencourt", EmployeeId = 144 },
            new Employee { FirstName = "Steve", LastName = "Stevens", EmployeeId = 11 },
            new Employee { FirstName = "Jerry", LastName = "Springer", EmployeeId = 33 },
        };
            foreach (Employee Employee in employees)
            {
                if (Employee.FirstName == "Joe")
                {
                    Console.WriteLine(Employee.FirstName, Employee.LastName, Employee.EmployeeId);
                   
                }

            }
            Console.ReadLine();

            //Employee employee = employees.Find(x => x.EmployeeId > 5) ;
            //Console.WriteLine("FirstName = {0}, LastName = {1}, EmployeeId = {2}", employee.FirstName, employee.LastName, employee.EmployeeId);
            //Console.ReadLine();


        }       
    }
}


   
    
    

