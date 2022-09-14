using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsExercise
{
    internal class OperatorsExerciseMethod
    {

     public static int Modulus (int num1, int num2) 


            { return num1 % num2; }

        // 7 / 5 =1r2 
        public static int Add (int num1, int num2)


        { return num1 + num2; }

        // 7 + 5 =12

        public static int subtract (int num1, int num2)


        { return num1 - num2; }

        // 7 - 5 = 2

        public static int Division (int num1, int num2)


        { return num1 / num2; }

        // 8 / 4 = 2 
        
        public static double AreaOfCircle(double radius)
        {
            return Math.PI * (radius * radius);

        }


    }
}
