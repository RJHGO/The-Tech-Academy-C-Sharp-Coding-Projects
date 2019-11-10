using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_eX
{
    class Employee : Person, IQuittable
    {

        public void Quit(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
