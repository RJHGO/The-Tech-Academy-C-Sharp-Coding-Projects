using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Title
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine();
            //Course Description
            Console.WriteLine("What Course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine();
            //Page Number
            Console.WriteLine("What Page Number?");
            string pageNum = Console.ReadLine();
            Console.WriteLine();
            //Need Help?
            Console.WriteLine("Do you need help with anything? Please answer " + " True " + " or " + " False");
            string needHelp = Console.ReadLine();
            Console.WriteLine();
            //Experiences
            Console.WriteLine("Were there any positive experiences you'd Like to share? Please give specifics.");
            string expShare = Console.ReadLine();
            Console.WriteLine();
            //Feedback
            Console.WriteLine("Is there any feedback you'd like to share? Please be specific.");
            string feedBack = Console.ReadLine();
            Console.WriteLine();
            //study hours
            Console.WriteLine("How Many Hours did you study today?");
            string numberHours = Console.ReadLine();
            int numHours = Convert.ToInt32(numberHours);
            Console.WriteLine();
            //End 
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();


        }
    }
}
