using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise
{
    class DoMath
    {
        public static int MathOp1(int UserNum)
        {
            int Result1;
            Result1 = UserNum + 10;
            return Result1;
        }
        public static double MathOp1(double UserNum1)
        {
            double Result2;
            Result2 = UserNum1 / 2;
            return Result2;
        }
        public static uint MathOp1( uint UserNum2)
        {
            string Result3 = "5";
            uint parsedResult3;
            uint.TryParse(Result3, out parsedResult3);
            uint Display = parsedResult3 * UserNum2;
            return Display;
        }

    }
}
