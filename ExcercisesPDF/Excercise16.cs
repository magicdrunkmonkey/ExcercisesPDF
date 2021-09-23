using System;
using System.Collections.Generic;
using System.Text;

namespace ExcercisesPDF
{
    class Excercise16
    {
        public static void RunExcercise16()
        {
            // Declare variables
            double n1=0, n2=1, n3, i;
            double number;
            int count = 0;


            try
            {

                Console.WriteLine("Fibonacci serie");
                Console.WriteLine("---------------\n");
                Console.Write("Type a number: ");
                number = double.Parse(Console.ReadLine());

                Console.Write(n1 + " " + n2 + " "); //printing 0 and 1    
                for (i = 2; i < number; ++i)        //loop starts from 2 because 0 and 1 are already printed    
                {
                    n3 = n1 + n2;
                    Console.Write(n3 + " ");
                    n1 = n2;
                    n2 = n3;
                }
                Console.WriteLine();

            }
            catch
            {
                Console.WriteLine("Not a number!");
            }
        }
    }
}
