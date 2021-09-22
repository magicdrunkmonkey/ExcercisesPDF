using System;
using System.Collections.Generic;
using System.Text;

namespace ExcercisesPDF
{
    class Excercise09
    {
        public static void RunExcercise9()
        {
            // Declare variables
            string name = "";
            int birthYear=0, age;
            

            //Information from the user
            try
            {
                Console.Write("What is your name: ");
                name = Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("That is not an acceptable name!");
            }

            try
            {
                Console.Write("Hello {0}, what is your birth year: ", name);
                birthYear = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("That is not number!");
            }

            //Calculate age
            age = DateTime.Now.Year - birthYear;
            //Console.WriteLine(age);

            //Order at a legal age greater than 18

            if (age > 18)
            {
                Console.Write("Do you want to order a beer? (Y/N)");
                string keyTemp = Console.ReadKey(true).KeyChar.ToString();
                if (keyTemp == "y" || keyTemp == "Y")
                {
                    Console.WriteLine("\nHere is your beer!");
                }
                else
                {
                    OrderCoke();                    
                }

            }
            else
            {
                OrderCoke();
            }
                        
        }
        public static void OrderCoke()
        {
            Console.Write("\nDo you want to order a coke? (Y/N)");
            string keyTemp = Console.ReadKey(true).KeyChar.ToString();
            if (keyTemp == "y" || keyTemp == "Y")
            {
                Console.WriteLine("\nHere is your coke!");
            }
            else
            {
                Console.WriteLine("\nNo other option is available!");
            }
        }
    }
}
