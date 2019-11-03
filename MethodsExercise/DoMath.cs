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
        public static decimal MathOp1(decimal UserNum1)
        {
            decimal Result2;
            Result2 = UserNum1 / 2;
            return Result2;
        }
        public static string MathOp1(string UserNum2)
        {
            int tBy = 5;
            UserNum2 = Console.ReadLine();
            int UserCon = int.Parse(UserNum2);
            int Eql = UserCon * tBy;
            return Eql.ToString();
            
            
        }

    }

}
