using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Class_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            int uNum1, uNum2, results, results1;

            Console.WriteLine("Please enter two numbers one at a time, at least one number is required.");
            Console.WriteLine("Enter first number: ");
            string Entered1 = Console.ReadLine();
            uNum1 = int.Parse(Entered1);
            results = class1.Optional(uNum1);
            Console.WriteLine(results);
            
            Console.WriteLine("Enter second number_optional...: ");

            if(int.TryParse(Console.ReadLine(), out uNum2))
            {
                results1 = class1.Optional(uNum2);
                Console.WriteLine(results1);
                Console.ReadLine();
            }
           
        }
    }
}
