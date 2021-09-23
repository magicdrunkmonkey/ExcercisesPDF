using System;
using System.Collections.Generic;
using System.Text;

namespace ExcercisesPDF
{
    class Excercise15
    {
        public static void RunExcercise15()
        {
            // Declare variables
            int number;            

            try
            {
                Console.Write("Enter a devisable number: ");
                number = int.Parse(Console.ReadLine());
                
                for (int i=number-1; i > 0 ; i--)
                {
                    if (number % i == 0)
                    {
                        Console.WriteLine(i);
                    }
                    else
                    {
                        //Console.WriteLine("Testing");
                    }
                }
            }
            catch
            {
                Console.WriteLine("\nThat is not a number!");
            }            
        }
    }
}
