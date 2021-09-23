using System;
using System.Collections.Generic;
using System.Text;

namespace ExcercisesPDF
{
    class Excercise18
    {
        public static void RunExcercise18()
        {
            // Declare variables
            int[] array1 = new int[10];
            double[] array2 = new double[10];

            //Create random integer numbers
            Random rnd = new Random();

            for(int i=0; i< array1.Length; i++)
            {
                array1[i] = rnd.Next(1, 11);
            }

            for(int i=0; i< array2.Length; i++)
            {
                array2[i] = 1 / (double)array1[i];                
            }

            Console.WriteLine("\nPrinting array1");
            foreach (int items in array1)
            {
                Console.WriteLine(items);
            }

            Console.WriteLine("\nPrinting array2");
            foreach (double item in array2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
