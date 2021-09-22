using System;
using System.Collections.Generic;
using System.Text;

namespace ExcercisesPDF
{
    class Excercise10
    {
        
        public static void RunExcercise10()
        {
            // Declare variables
            var keepAlive = true;
            int colorMode = 1;

            //The menu
            while (keepAlive)
            {
                try
                {
                    
                    Console.WriteLine("Choose an option");
                    Console.WriteLine("________________\n");
                    Console.WriteLine("1) Divide two numbers");
                    Console.WriteLine("2) Run ecercise 4");
                    Console.WriteLine("3) Switch color");
                    Console.WriteLine("\n0) Quit");
                    var choice = int.Parse(Console.ReadLine());
                    Console.Clear();

                    switch (choice)
                    {
                        case 1:
                            DivideTwoNumbers();
                            break;
                        case 2:
                            Excercise04.RunExcercise4();
                            break;
                        case 3:
                            
                            Console.WriteLine("colorMode before: "+colorMode);
                            colorMode = SwitchForground(colorMode);
                            Console.WriteLine("colorMode after: "+colorMode);
                            break;
                        case 0:
                            keepAlive = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Not a valid option");
                            Console.ResetColor();
                            break;

                    }

                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Not a valid option");
                    Console.ResetColor();
                }
            }
        }
        static int SwitchForground(int mode)
        {
            if ( mode == 1)
            {
                mode = 0;

                // Set the Foreground color to blue
                Console.ForegroundColor = ConsoleColor.Blue;
                return mode;
            }
            else
            {
                mode = 1;

                // Reset forground color
                Console.ResetColor();
                return mode;
            }
        }
        static void DivideTwoNumbers()
        {
            double num1, num2, result;

            // Ask the user to type the first number.
            Console.WriteLine("Type the first number, and then press Enter");
            num1 = Convert.ToDouble(Console.ReadLine());

            // Ask the user to type the second number.
            Console.WriteLine("Type the second number, and then press Enter");
            num2 = Convert.ToDouble(Console.ReadLine());

            if (num2 == 0)
            {
                Console.WriteLine("\nThe denominator can not be zero");
            }
            else
            {
                result = num1 / num2;
                Console.WriteLine("{0} / {1} = {2}", num1, num2, result);
            }


        }
    }
}
