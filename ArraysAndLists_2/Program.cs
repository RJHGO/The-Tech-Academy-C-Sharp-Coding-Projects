using System;
using System.Collections.Generic;


namespace ArraysAndLists_2
{
    class Program
    {
        static void Main()
        {
            string[] strArray = new string[4];
            strArray[0] = "Very likely";
            strArray[1] = "Somewhat likely";
            strArray[2] = "have not considered it";
            strArray[3] = "Not likely";
            Console.WriteLine("How likely are you to take college courses after high school, Please enter a number from below " +
                "\n\n0_Very likely\n1_Somewhat likely\n2_Have not considered it\n3_Not likely\n");
            int  UserIn = int.Parse(Console.ReadLine());
            Console.WriteLine("You chose:" + strArray[UserIn]);
            Console.WriteLine();

            int[] NumArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Please select how many jobs you have had in the last year?" + "\n 0 = 1\n 1 = 2\n 2 = 3\n 3 = 4\n 4 = 5\n 5 = 6\n 6 = 7\n 7 = 8 \n 8 = 9\n 9 = 10\n");
            int NumYear = int.Parse(Console.ReadLine());

            if (NumYear > 9)
            {
                Console.WriteLine("Thank you, but you are not the droid we are looking for");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You have had " + NumArray[NumYear] + " jobs in the last year.");
                Console.WriteLine();
            }
           
                List<string> NewList = new List<string>();
                NewList.Add("You will find happyness");
                NewList.Add("Success is just around the corner");
                NewList.Add("Today will hold great suprises");
                NewList.Add("Someone you miss will soon return");
                NewList.Add("Great things are around the corner");
                Console.WriteLine("Choose a number to hear your fortune." + "\n 1 \n 2 \n 3 \n 4 \n 5 \n");
            int Ufort = int.Parse(Console.ReadLine());
            Console.WriteLine("And your fortune reads: " + NewList[Ufort]);
            Console.ReadLine();


               
        }
    }
}
