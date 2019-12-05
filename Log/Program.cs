using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Log
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give a number");
            int UserNum = Convert.ToInt32(Console.ReadLine());
            File.WriteAllText(@"C:\Users\lefta\Desktop\Rons\log.txt", Convert.ToString(UserNum));
            string UserNum1 = File.ReadAllText(@"C:\Users\lefta\Desktop\Rons\log.txt");
            Console.WriteLine(UserNum1);
            Console.ReadLine();
            
        }
    }
}
