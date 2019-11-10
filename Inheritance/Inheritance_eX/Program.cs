using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_eX
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee Person = new Employee();
            Person.FirstName = "Sample";
            Person.LastName = "Student";
            Person.SayName();
            Console.ReadLine();

           
        }
    }
}
