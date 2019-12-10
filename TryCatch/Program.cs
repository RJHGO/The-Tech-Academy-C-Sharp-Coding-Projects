using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter your age number, no decimals.");
                int UserAge = Convert.ToInt32(Console.ReadLine());
                DateTime date = DateTime.Now;
                var date1 = date.AddYears(-UserAge);
                var born = date1.Date.Year;
                Console.WriteLine(born);
                Console.ReadLine();
                
            }
            catch(NotFiniteNumberException)
            {
                Console.WriteLine("Enter a number greater than 0 for your age.");
                Console.ReadLine();
                return;
            }

            catch (InvalidOperationException)
            {
                Console.WriteLine("You did not give a valid number for age.");
                Console.ReadLine();
                return;
            }

            catch (Exception)
            {
                Console.WriteLine("You did not give a valid number for age.");
                Console.ReadLine();
                return;
            }
           
                     
                
            

        }
    }
}
