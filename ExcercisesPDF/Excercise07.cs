using System;
using System.Collections.Generic;
using System.Text;

namespace ExcercisesPDF
{
    class Excercise07
    {
        public static void RunExcercise7()
        {
            // Declare variables
            double radius,result;
            try
            {
                //User input radius
                Console.Write("Input a radius for a circle: ");
                radius = double.Parse(Console.ReadLine());

                //Calculate circle area
                //Console.WriteLine(Math.Pow(radius,2));
                result = Math.PI * Math.Pow(radius, 2);
                Console.WriteLine("Circle area is {0} with radius {1}.", result, radius);

                //Calculate circle volume
                result = (4 * Math.PI * Math.Pow(radius, 3)) / 3;
                Console.WriteLine("Volume of the circle is {0}.", result);

            }
            catch
            {
                Console.WriteLine("Not a valid number!");
            }
        }
    }
}
