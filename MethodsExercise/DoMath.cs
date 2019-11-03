using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise
{
    class DoMath
    {
        public int MathOp1(int UserNum)
        {
            int Result1;
            Result1 = UserNum + 10;
            return Result1;
        }
        public int MathOp1(decimal UserNum1)
        {
            decimal Result2;
            Result2 = UserNum1 / 2;
            int Results = Convert.ToInt32(Result2);
            return Results;
        }
        public int MathOp1(string UserNum2)
        {
            int mainNum = 5;
            int UserIn = int.Parse(UserNum2);
            int equals = UserIn * mainNum;
            return equals;
            
            
        }

    }

}
