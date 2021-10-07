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
            int input1, input2, result;


            while (keepLooping)
            {
                try
                {
                    Console.Write("Enter a valid integer value: ");
                    input1 = int.Parse(Console.ReadLine());

                    Console.Write("Enter a valid integer value: ");
                    input2 = int.Parse(Console.ReadLine());

                    result = input1 / input2;
                    Console.WriteLine("{0} / {1} = {2}", input1, input2, result);

                    keepLooping = false;
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("ArgumentNullException");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("DivideByZeroException");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("ArgumentException");
                }
                catch
                {
                    Console.WriteLine("Not a valid number!");
                }
            }
        }
    }
}
