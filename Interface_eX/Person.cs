using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_eX
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        //public void SayName()
        //{
           
        //    Console.WriteLine("Name: " + FirstName  + " " +  LastName);
        //}
        public void Quit()
        {
            Console.WriteLine(FirstName);
        }
        
        //This is close, but you aren't setting the first and last name values to the properties of the object, 
        //you are just creating a list and printing off all of the elements of that.  
        //Remove the List property and just use the .Firstname and .Lastname.
        //Then resubmit.
        //-Jordan
    }
}
