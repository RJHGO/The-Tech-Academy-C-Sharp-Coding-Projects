using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            DoMath domath = new DoMath();

            Console.WriteLine("Your chosen number + 10");
            int UserNum = int.Parse(Console.ReadLine());
            int Solve1 = domath.MathOp1(UserNum);
            Console.WriteLine(Solve1);
           
            Console.WriteLine("Your chosen decimal number divided by 2");
            decimal UserNum1 = decimal.Parse(Console.ReadLine());
            decimal Solve2 = domath.MathOp1(UserNum1);
            Console.WriteLine(Solve2);
            

            Console.WriteLine("Your chosen number * 5");
            string UserNum2 = Console.ReadLine();
            int Solve3 = domath.MathOp1(UserNum2);
            Console.WriteLine(Solve3);
            Console.ReadLine();

        }
    }
}
