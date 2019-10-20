using System;
using System.Collections.Generic;


namespace Exception_Handling_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> Numbers = new List<int> { 98, 107, 45, 86, 72, 54 };
                Console.WriteLine("Provide a number to divide each number in the list by." + "\n98\n107\n45\n86\n72\n54");
                foreach (int Number in Numbers)
                {                    
                        double newNumber = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(Number/newNumber + " .....Go again.");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
