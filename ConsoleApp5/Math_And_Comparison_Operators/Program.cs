using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_And_Comparison_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //person 1
            Console.WriteLine("Anonymous income comparison program");
            Console.WriteLine("Person 1");
            Console.WriteLine();
            Console.WriteLine("Hourly Rate?");
            string hRate1 = Console.ReadLine();
            double hourRate1 = Convert.ToDouble(hRate1);
            Console.WriteLine("Hours worked per week");
            string hPerWeek1 = Console.ReadLine();
            double hoursPerW1 = Convert.ToDouble(hPerWeek1);
            //person 2
            Console.WriteLine();
            Console.WriteLine("Person 2");
            Console.WriteLine();
            Console.WriteLine("Hourly Rate?");
            string hRate2 = Console.ReadLine();
            double hourRate2 = Convert.ToDouble(hRate2);
            Console.WriteLine("Hours worked per week");
            string hPerWeek2 = Console.ReadLine();
            double hoursPerW2 = Convert.ToDouble(hPerWeek2);
            Console.WriteLine();
            Console.WriteLine("Weekly salary of person 1:");
            double salaryOne = hourRate1 * hoursPerW1;
            Console.WriteLine(salaryOne);
            Console.WriteLine();
            Console.WriteLine("Weekly salary of person 2:");
            double salaryTwo = hourRate2 * hoursPerW2;
            Console.WriteLine(salaryTwo);
            Console.WriteLine();
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool BigShot1 = salaryOne > salaryTwo;
            Console.WriteLine();
            Console.WriteLine(BigShot1);
            Console.ReadLine();



        }
    }
}
