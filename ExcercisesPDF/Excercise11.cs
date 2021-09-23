using System;
using System.Collections.Generic;
using System.Text;

namespace ExcercisesPDF
{
    class Excercise11
    {
        public static void RunExcercise11()
        {
            // Declare variables
            int num=0;

            try
            {
                Console.Write("Enter an integer number greater than zero: ");
                num = int.Parse(Console.ReadLine());
                if(num <= 0)
                {
                    Console.WriteLine("The number is not greater than zero!");
                }
                else
                {
                    CountingUp(num);
                    Console.WriteLine("------------------------");
                    CountingDown(num);
                }
            }
            catch
            {
                Console.WriteLine("\nThat is not an integer number!");
            }
        }

        private static void CountingDown(int count)
        {
            for (int i = count; i >= 0; i--)
            {
                ColorCheck(i);
            }
            //throw new NotImplementedException();
        }

        private static void CountingUp(int count)
        {
            for(int i = 0; i <= count; i++)
            {
                ColorCheck(i);
            }
            //throw new NotImplementedException();
        }

        private static void ColorCheck(int i)
        {
            if(i%2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(i);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(i);
            }
            //throw new NotImplementedException();
        }
    }
}
