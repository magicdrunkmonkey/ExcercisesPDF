using System;
using System.Collections.Generic;
using System.Text;

namespace ExcercisesPDF
{
    class Excercise152
    {
        public static void RunExcercise15()
        {
            // Declare variables
            int number;
            int perfectNumberCount = 1;

            try
            {
                Console.Write("Enter a devisable number: ");
                number = int.Parse(Console.ReadLine());

                for (int i = number - 1; i > 0; i--)
                {
                    if (perfectNumberCount <= 3)
                    {
                        if (number % i == 0)
                        {
                            Console.WriteLine(i);
                            perfectNumberCount++;
                        }
                        else
                        {
                            //Console.WriteLine("Testing");
                        }
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
