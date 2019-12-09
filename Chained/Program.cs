using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chained
{
    class Program
    {
        static void Main(string[] args)
        {
            var newCARS = new TheCars();
            int numOfCARS = (newCARS.NumOfCars);
            string bigName = newCARS.Brand;

            
            Console.WriteLine(Convert.ToString(numOfCARS) +" "+ bigName);
            Console.ReadLine();
            

            
            
            
           
        }
    }
}
