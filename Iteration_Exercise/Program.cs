using System;
using System.Collections.Generic;


namespace Iteration_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            //int i;
            //string[] people = new string[4] ;
            //for(i = 0; i < people.Length; i++)
            //{
            //    Console.WriteLine("\nEnter a name to the list:\t");
            //    people[i] = Convert.ToString(Console.ReadLine());
            //}
            //Console.WriteLine("\n\n");
            //for (i = 0; i < people.Length; i++)
            //{
            //    Console.WriteLine("You added {0} ", people[i]);
            //}
            //Console.ReadLine(); 


            ////////////////////////////////////////////////////infinite loop.
            //for (int x = 0; x < 10; x--)
            //{
            //    Console.WriteLine("{0}", x);
            //
            //    //break;  stops the infinite loop.
            //}
            //Console.ReadLine();


            /////////////////////////////////////////////////////////////////////loop counts to 10 when it hits the < comparison. 
            //for (int i=1; i<11; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //    Console.ReadLine();


            /////////////////////////////////////////////////////////////////////////loop until <= 7.
            //int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //for (int i = 0; i <= 7; i++)

            //Console.WriteLine(i);
            //Console.ReadLine();


            /////////////////////////////////////////////////////////////////////////////7. and 8.

            //List<string> animals = new List<string> { "cat", "dog", "bird", "snake", "rat" };

            //for (int i = 0; i <4; i++)
            //{
            //    Console.WriteLine("What species of common house pet do you prefer the most?" + "\ncat\ndog\nbird\nsnake\nrat\n");
            //    int A = animals.IndexOf(Console.ReadLine());
            //    Console.WriteLine(A);
            //    Console.ReadLine();


            //    if (A == -1) 
            //        {
            //        Console.WriteLine("Pick an animal from the list.");
            //            Console.ReadLine();
            //        break;
            //    }

            //}

            /////////////////////////////////////////////////////////////////______9.___10.

            //List<string> animals = new List<string> { "cat", "dog", "bird", "bird", "bird", "snake", "rat" };
            //Console.WriteLine("What species of common house pet do you prefer the most?" + "\ncat\ndog\nbird\nsnake\nrat\n");
            //string A = Console.ReadLine();
            //Console.WriteLine(A);
            //Console.ReadLine();
            //for (int i = 0; i < 6; i++)
            //{
            //    if (animals[i] == A)
            //    {
            //        Console.WriteLine(i);

            //    } else 
            //    {

            //        Console.WriteLine("Not on the list!");
            //    }


            //}

            ////////////////////////////////////////////////////////////////////////////_______________11.

            List<string> Brands = new List<string> { "Ford", "Chevy", "Dodge", "Toyota", "Nissan", "Honda", "Volvo", "Chevy", };
            List<string> unique = new List<string> { };/////
            
             
            

                foreach (String Brand in Brands)
                {
                if(unique.Contains(Brand))
                {
                    Console.WriteLine(Brand + " This brand has appeared already");
                }
                else
                {
                    Console.WriteLine(Brand);
                    unique.Add(Brand);
                }

                }
                Console.ReadLine();  
                }

            }  
            
        }
    

