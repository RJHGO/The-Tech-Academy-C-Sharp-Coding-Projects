using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Person = new Employee();
            Person.Names = new List<string>() { "Sample", "Student" };
            Person.SayName();
            Console.ReadLine();
        }
    }
}
