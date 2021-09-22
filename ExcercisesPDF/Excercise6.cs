using System;
using System.Collections.Generic;
using System.Text;

namespace ExcercisesPDF
{
    class Excercise6
    {
        public static void RunExcercise6()
        {
            int num1, num2;
            double result;
            try
            {

                Console.Write("Type the first integer number: ");
                num1 = int.Parse(Console.ReadLine());
                Console.Write("Type the second integer number: ");
                num2 = int.Parse(Console.ReadLine());

                //Biggest number
                if (num1 > num2)
                {
                    Console.WriteLine("Biggest number is {0}", num1);
                }
                else
                {
                    Console.WriteLine("Biggest number is {0}", num2);
                }

                //Smallest number
                if (num1 > num2)
                {
                    Console.WriteLine("Smallest number is {0}", num2);
                }
                else
                {
                    Console.WriteLine("Smallest number is {0}", num1);
                }

                //Difference between numbers
                if (num1 > num2)
                {
                    result = num1 - num2;
                    Console.WriteLine("The diffrence between number is {0}", result);
                }
                else
                {
                    result = num2 - num1;
                    Console.WriteLine("The diffrence between the numbers is {0}", result);
                }

                //Sum of the numbers
                Console.WriteLine("The sum of the numbers is {0}", (num1+num2));

                //Product of the numbers
                Console.WriteLine("The product of the numbers is {0}", (num1 * num2));

                //Ratio of the numbers
                Console.WriteLine("The ratio of the numbers is {0}", ((double)num1 / num2));


            }
            catch
            {
                Console.WriteLine("That was not an integer number!");
            }
        }
    }
}
