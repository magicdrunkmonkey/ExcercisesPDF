using System;
using System.Collections.Generic;
using System.Text;

namespace ExcercisesPDF
{
    class Excercise13
    {
        public static void RunExcercise13()
        {
            // Declare variables
            bool keepLooping = true;
            int guessCount = 0;

            // Create random number
            Random rnd = new Random();                       
            int randomNumber = rnd.Next(1, 501);                      

            while (keepLooping)
            {
                try
                {
                    Console.Write("\nGuess an integer number between 1 and 500: ");
                    int guessNumber = Convert.ToInt32(Console.ReadLine());

                    guessCount++;
                    Console.WriteLine("Guessings: {0}", guessCount);

                    if (guessNumber > randomNumber)
                    {
                        Console.WriteLine("\nYour guess was too big!");
                    }
                    else if (guessNumber < randomNumber)
                    {
                        Console.WriteLine("\nYour guess was too small!");
                    }
                    else
                    {
                        Console.WriteLine("\nCorrect guess!");
                        keepLooping = false;
                    }
                }
                catch
                {
                    Console.WriteLine("That is not an integer number.");
                }
            }
        }
    }
}
