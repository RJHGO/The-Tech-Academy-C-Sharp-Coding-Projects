using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divide_by_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Void1 void1 = new Void1();

            Console.WriteLine("Choose a number to be divided by 2.");
            int newNum = int.Parse(Console.ReadLine());
            int result;
                void1.Divides1(newNum, out result);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
