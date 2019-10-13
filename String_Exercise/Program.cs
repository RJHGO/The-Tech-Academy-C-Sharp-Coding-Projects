using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = "Hello, My name ";
            string second = "is John Doe, ";
            string third = "it is nice to meet you";
            Console.WriteLine(first + second + third);
            Console.WriteLine();
            string newFirst = "This is my first line in a paragraph using string builder,";
            string newSecond = "I am slow at typing but getting faster and more accurate ";
            string newThird = "with practice. I am currently in the middle of my C# course, ";
            string newFourth = "and I am learning how to manipulate strings.";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(newFirst);
            sb.AppendLine(newSecond);
            sb.AppendLine(newThird);
            sb.AppendLine(newFourth);
            Console.WriteLine(sb);
            Console.WriteLine();
            string NewString = sb.ToString();
            Console.WriteLine(NewString.ToUpper());
            Console.ReadLine();
           
        }
    }
}
