using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chained
{
    class TheCars
    {
        public int NumOfCars;
        public string Brand;

        public TheCars() : this(10, "Ford")
        {
        }

        public TheCars(int NumOfCars, string Brand)
        {
            this.NumOfCars = NumOfCars;
            this.Brand = Brand;
        }

    }
}
