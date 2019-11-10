using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    public abstract class Person
    {
        public List<string> Names { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public abstract void ListNames();
        public virtual void SayName()
        {
            foreach (string name in Names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
