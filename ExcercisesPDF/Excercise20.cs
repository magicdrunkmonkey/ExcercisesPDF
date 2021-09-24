using System;
using System.Collections.Generic;
using System.Text;

namespace ExcercisesPDF
{
    class Excercise20
    {
        public static void RunExcercise20()
        {
            // Declare variables
            Random rnd = new Random();
            int arraySize = rnd.Next(5, 11);

            int randomNumber;

            //Create two equal and random sized arrays.
            int[] array1 = new int[arraySize];
            int[] array2 = new int[arraySize];

            //Populate array1 with random numbers
            for(int i=0; i < arraySize; i++)
            {
                randomNumber = rnd.Next(1, 11);
                array1[i] = randomNumber;
            }

            //ODD NUMBERS
            int j = 0;
            for (int i = 0; i < arraySize; i++)
            { 
                if (array1[i] % 2 != 0)
                {
                    //Console.WriteLine("array1 before: "+array1[i]);
                    //Console.WriteLine("array2 before: "+array2[j]);
                    array2[j] = array1[i];
                    j++;
                    //Console.WriteLine("array2 after: "+array2[j]);
                }
            }

            
            //EVEN NUMBERS
            j = arraySize-1;
            for (int i = arraySize-1; i >= 0; i--)
            {
                if (array1[i] % 2 == 0)
                {
                    array2[j] = array1[i];
                    j--;                    
                }
            }     

            Console.WriteLine("\narray1\n");
            foreach (int items in array1)
            {
                Console.WriteLine(items);
            }

            Console.WriteLine("\narray2\n");
            foreach (int items in array2)
            {
                Console.WriteLine(items);
            }
        }
    }
}
