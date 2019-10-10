using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express.");
            Console.WriteLine();
            Console.WriteLine("What is the weight of your package?");
            string weightIs = Console.ReadLine();
            double weightNum = Convert.ToDouble(weightIs);
            if (weightNum > 50)
            {
                Console.WriteLine("Package too heavy to be shipped by Package Express. Have a good day.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Package is accepted.");
                Console.WriteLine();
                Console.WriteLine("Package height?");
                string heightIs = Console.ReadLine();
                double isHeight = Convert.ToDouble(heightIs);
                Console.WriteLine();
                Console.WriteLine("Package length?");
                string lengthIs = Console.ReadLine();
                double isLength = Convert.ToDouble(lengthIs);
                Console.WriteLine();
                if (isHeight + isLength > 50)
                {
                    Console.WriteLine("Package is too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your estimated total for shipping this package is: " + (isHeight + isLength) * (weightNum / 100) + " Thank you.");
                        Console.ReadLine();
                }


            }
        }
    }
}
