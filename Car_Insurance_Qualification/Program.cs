using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Insurance_Qualification
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age");
            string ageIs = Console.ReadLine();
            int yrsOld = Convert.ToInt32(ageIs);
            bool IsAge = yrsOld > 15;
            Console.WriteLine(IsAge);
            Console.WriteLine();

                Console.WriteLine("Do you have any DUI's? Please enter true or false.");
                string anyDui = Console.ReadLine();
                bool answer = Convert.ToBoolean(anyDui);
                Console.WriteLine();

                Console.WriteLine("How many speeding tickets do you have?");
                string sTickets = Console.ReadLine();
                int NumTicks = Convert.ToInt32(sTickets);
                Console.WriteLine();
                Console.WriteLine("Qualified?");
                bool IsQualified = (yrsOld > 15 && answer == false && NumTicks < 3);
                Console.WriteLine(IsQualified);
                Console.ReadLine();



             
        }
    }
}
