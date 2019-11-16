using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload_Operator
{
   class Employee
    {

        int z;
        
        public Employee(int EmployeeId)
        {
            z = EmployeeId;
        }  
        public static bool operator == (Employee x, Employee y)
        {
            return x.z == y.z;
        }
        public static bool operator != (Employee x, Employee y)
        {
            return x.z != y.z;
        }
    }
}
