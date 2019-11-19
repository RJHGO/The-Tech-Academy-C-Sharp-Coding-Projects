using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
            
        static void Main(string[] args)
        {
            Employee<int> employee = new Employee<int>();
            employee.Things = new List<int>(){2, 4, 6, 8, 10};

            foreach (int Thing in employee.Things)
            {                
                    Console.WriteLine(Thing);
                                   
            }

            Employee<string> employee1 = new Employee<string>();
            employee1.Things = new List<string>() { "Henry", "Linda", "Kelly", "Mark", "Tom" };

            foreach (string Thing in employee1.Things)
            {
                Console.WriteLine(Thing);
                
            }
            Console.ReadLine();
        }
    }
}
