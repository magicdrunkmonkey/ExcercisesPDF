using System;
using System.Collections.Generic;
using System.Text;

namespace ExcercisesPDF
{
    class Excercise8
    {
        public static void RunExcercise8()
        {
            // Declare variables
            double num, result;

            //Userinput
            Console.Write("Enter a decimal number: ");
            num = double.Parse(Console.ReadLine());

            //Square root
            result = Math.Sqrt(num);
            Console.WriteLine("Square root of {0} is {1}", num, result);

            //Power of 2
            result = Math.Pow(num, 2);
            Console.WriteLine("Power of {0} raised to 2 is {1}", num, result);

            //Power of 10
            result = Math.Pow(num, 10);
            Console.WriteLine("Power of {0} raised to 10 is {1}", num, result);

        }
    }
}
