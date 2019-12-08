using System;

namespace dates_n_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Give a Number.");
            int UserNum = Convert.ToInt32(Console.ReadLine());
            DateTime thisTime = DateTime.Now;
            DateTime plusHrs = thisTime.AddHours(UserNum);
            Console.WriteLine(plusHrs);
            Console.ReadLine();
        }
    }
}
