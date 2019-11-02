using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int FirstNum = 0, SecNum = 0;
            Console.WriteLine(" Enter your first number to multiply");
            FirstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter you second number to multiply");
            SecNum = int.Parse(Console.ReadLine());

            VoidMethodInts voidmethodsint = new VoidMethodInts();
            VoidMethodInts.Nums(FirstNum, SecNum);
 
            Console.ReadLine();
        }
    }
}
