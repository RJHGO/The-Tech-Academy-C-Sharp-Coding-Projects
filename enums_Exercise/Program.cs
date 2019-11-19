using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enums_Exercise
{
    class Program
    {
        public enum DaysOfTheWeek
        {
            Sunday = 1,
            Monday = 2,
            Tuesday = 3,
            Wednesday = 4,
            Thursday = 5,
            Friday = 6,
            Saturday = 7
        }
        static void Main(string[] args)
        {

            try {
                Console.WriteLine("Enter the current day of the week.");
                //string Mon = Console.ReadLine();
                DaysOfTheWeek daysOfTheWeek = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), Console.ReadLine());
                
            }
            catch(SystemException)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            finally
            {
                Console.ReadLine();
            }
          
        }
    }
}
