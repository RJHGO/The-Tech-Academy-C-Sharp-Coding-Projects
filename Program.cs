using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person = new Employee();
            person.FirstName = "Sample";
            person.LastName = "Student";
            person.SayName();
            Console.ReadLine();
        }
    }
}
