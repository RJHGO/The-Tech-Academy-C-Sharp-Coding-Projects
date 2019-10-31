using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int UserNum, final1, final2, final3;
            Console.WriteLine("What Number would you like to do math operations on?");
            UserNum = int.Parse(Console.ReadLine());
            final1 = Operations.AddIt(UserNum);
            Console.WriteLine("Your number + 5: " + final1);
            final2 = Operations.TimesIt(UserNum);
            Console.WriteLine("Your number x 5: " + final2);
            final3 = Operations.DivideIt(UserNum);
            Console.WriteLine("Your number divided by 5: " + final3);
            Console.ReadLine();
       
        }
    }
}
