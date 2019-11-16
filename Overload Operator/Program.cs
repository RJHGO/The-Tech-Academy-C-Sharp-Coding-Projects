using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload_Operator
{
    public class Program
    {
        static void Main(string[] args)
        {
            

            Employee a  = new Employee(2015);
            Employee b = new Employee(2019);
            

            Console.WriteLine(a == b);
            Console.ReadLine();



           
        }
      }
    }

