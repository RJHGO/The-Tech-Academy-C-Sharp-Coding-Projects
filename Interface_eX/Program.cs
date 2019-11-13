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

            IQuittable iquittable = new Employee();
            //person.FirstName = "Sample";
            //person.LastName = "Student";
            iquittable.Quit();
            //Person.SayName();
            Console.ReadLine();
           
        }
    }
}
