using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ExcercisesPDF
{
    class Excercise21
    {
        public static void RunExcercise21()
        {
            // Declare variables
            string stringNumbers;            

            Console.Write("Enter a series of comma separated numbers: ");
            stringNumbers = Console.ReadLine();

            string[] stringArray = stringNumbers.Split(",");

            double[] doubleArray = stringArray.Select(double.Parse).ToArray();

            Console.WriteLine("Min value: {0}", doubleArray.Min());
            Console.WriteLine("Max value: {0}", doubleArray.Max());
            Console.WriteLine("Average value: {0}", doubleArray.Average());

            Console.WriteLine("\nArray containing\n");
            foreach (string item in stringArray)
            {
                Console.WriteLine(item);
            }
         }
    }
}
