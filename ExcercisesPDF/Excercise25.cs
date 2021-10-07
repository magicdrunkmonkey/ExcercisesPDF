using System;
using System.Collections.Generic;
using System.Text;

namespace ExcercisesPDF
{
    class Excercise25
    {
        public static void RunExcercise25()
        {
            // Declare variables
            bool keepLooping = true;
            int input;


            while (keepLooping)
            {
                try
                {
                    Console.Write("Enter a valid integer value: ");
                    input = int.Parse(Console.ReadLine());
                    keepLooping = false;
                }
                catch
                {
                    Console.WriteLine("Not a valid number!");
                }
            }
        }
    }
}
