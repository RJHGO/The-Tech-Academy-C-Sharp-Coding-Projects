using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Person
    {
        public List<string> Names { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public void SayName()
        {
            foreach (string name in Names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
