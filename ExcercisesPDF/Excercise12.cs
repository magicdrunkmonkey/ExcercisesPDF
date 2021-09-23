using System;
using System.Collections.Generic;
using System.Text;

namespace ExcercisesPDF
{
    class Excercise12
    {
        public static void RunExcercise12()
        {
            // Declare variable                        
            int value = 10;

            //Multiplication Table
            Console.Write("\n\n   |");
            for (int x = 1; x <= value; ++x)
            {
                Console.Write("{0, 5}", x);
            }
            Console.WriteLine("   ");
            Console.WriteLine("________________________________________________________");
                            
            for (int row = 1; row <= value; ++row)
            {
                Console.Write("{0, 2} |", row);
                for (int column = 1; column <= value; ++column)
                {

                    Console.Write("{0, 5}", row * column);

                }
                Console.WriteLine();
            }            
        }
    }
}
