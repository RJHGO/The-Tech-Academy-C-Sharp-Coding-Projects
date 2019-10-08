using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in your weekly allowance to see it x 50.");
            string weeklyAllowance = Console.ReadLine();
            double weekPay = Convert.ToDouble(weeklyAllowance);
            double total = weekPay * 50;
            Console.WriteLine("Your weekly allowance x 50 = " + total);
            Console.WriteLine();

            Console.WriteLine("Type in your allowance to see it with an additional 25.");
            Console.ReadLine();
            double newTotal = weekPay + 25;
            Console.WriteLine();
            Console.WriteLine("Your allowance + 25 = " + newTotal);
            Console.WriteLine();

            Console.WriteLine("Type in your allowance to see it divided by 12.5.");
            Console.ReadLine();
            double DivTotal = weekPay / 12.5;
            Console.WriteLine("Your allowance divided by 12.5 = " + DivTotal);
            Console.WriteLine();

            Console.WriteLine("Type your allowance to see if its greater than the secret number.");
            Console.ReadLine();
            bool trueOr = weekPay > 50;
            Console.WriteLine("Is your allowance greater?: " + trueOr);
            Console.WriteLine();

            Console.WriteLine("Type in your allowance to show the remainder after divided by 7.");
            Console.ReadLine();
            double newDivide = weekPay % 7;
            Console.WriteLine("This is your allowance remainder after divided by 7 = " + newDivide);
            Console.ReadLine();

        }
    }
}
