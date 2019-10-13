using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_and_DoWhile_statements
{
    class Program
    {
        static void Main(string[] args)
        {
//            Console.WriteLine("How many laps around a track are equal to 4 miles?");/////////////////////////////////////________while loop.
//            int laps = Convert.ToInt32(Console.ReadLine());
//            bool IsCorrect = laps == 16;

//            while (!IsCorrect)
//            {
//                switch (laps)
//                {
//                    case 4:
//                        Console.WriteLine("you guessed 4. Try again.");
//                        Console.WriteLine("How many laps around a track are equal to 4 miles?");
//                        laps = Convert.ToInt32(Console.ReadLine());
//                        break;
//                    case 8:
//                        Console.WriteLine("You guessed 8. Try again.");
//                        Console.WriteLine("How many laps around a track are equal to 4 miles?");
//                        laps = Convert.ToInt32(Console.ReadLine());
//                        break;
//                    case 12:
//                        Console.WriteLine("You guessed 12. Try again.");
//                        Console.WriteLine("How many laps around a track are equal to 4 miles?");
//                        laps = Convert.ToInt32(Console.ReadLine());
//                        break;
//                    case 16:
//                        Console.WriteLine("You guessed 16. That is Correct!");
//                        IsCorrect = true;
//                        break;
//                    default:
//                        Console.WriteLine("You are wrong");
//                        Console.WriteLine("How many laps around a track are equal to 4 miles?");
//                        laps = Convert.ToInt32(Console.ReadLine());
//                        break;

//                }
//            }
//            Console.ReadLine();

//        }
//    }
//}

Console.WriteLine("How many laps around a track are equal to 4 miles?");/////////////////////////////////////////________Do_while_loop.
            int laps = Convert.ToInt32(Console.ReadLine());
bool IsCorrect = laps == 16;
            do
            {

                {
                    switch (laps)
                    {
                        case 4:
                            Console.WriteLine("you guessed 4. Try again.");
                            Console.WriteLine("How many laps around a track are equal to 4 miles?");
                            laps = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 8:
                            Console.WriteLine("You guessed 8. Try again.");
                            Console.WriteLine("How many laps around a track are equal to 4 miles?");
                            laps = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 12:
                            Console.WriteLine("You guessed 12. Try again.");
                            Console.WriteLine("How many laps around a track are equal to 4 miles?");
                            laps = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 16:
                            Console.WriteLine("You guessed 16. That is Correct!");
                            IsCorrect = true;
                            break;
                        default:
                            Console.WriteLine("You are wrong");
                            Console.WriteLine("How many laps around a track are equal to 4 miles?");
                            laps = Convert.ToInt32(Console.ReadLine());
                            break;

                    }
                }

            }
            while (!IsCorrect);
            Console.ReadLine();

        }
    }
}
