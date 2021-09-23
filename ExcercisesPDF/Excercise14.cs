using System;
using System.Collections.Generic;
using System.Text;

namespace ExcercisesPDF
{
    class Excercise14
    {
        public static void RunExcercise14()
        {
            // Declare variables
            bool keepLooping = true;
            double sum = 0;
            double input = 0;
            int inputCount = 0;

            Console.WriteLine("Summerize all input numbers. Type \"-1\" to display sum and the average of the numbers.");

            while (keepLooping)
            {
                Console.Write("Input a number: ");
                try
                {
                    input = double.Parse(Console.ReadLine());
                    if (input != -1)
                    {
                        sum = sum + input;
                        inputCount++;
                        //Console.WriteLine(sum);
                        //Console.WriteLine(inputCount);
                    }
                    else
                    {
                        Console.WriteLine("\nSum: {0}", sum);
                        Console.WriteLine("Average: {0}", sum / inputCount); //Caculating average
                        keepLooping = false;
                    }
                    
                }
                catch
                {
                    Console.WriteLine("Not a number!");                    
                }
            }            
        }
    }
}
