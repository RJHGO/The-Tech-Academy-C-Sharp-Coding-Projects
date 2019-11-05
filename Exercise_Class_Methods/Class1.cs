using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Class_Methods
{
    class Class1
    {
        public int Optional(int uNum1, int uNum2 = 0)
        {
            int x = 10;
            if(uNum1 > 0 )
            {
                return uNum1 * x;
            }
            else
            {
                return uNum2 * x;
            }
            
        }     
    }
}
