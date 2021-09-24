using System;
using System.Collections.Generic;
using System.Text;

namespace ExcercisesPDF
{
    class Excercise19
    {
        public static void RunExcercise19()
        {
            // Declare variables
            bool keepLooping =true;
            
            // Create random number
            Random rnd = new Random();
            int randomPrice = rnd.Next(1, 1001);
            int pay = 0;
            int change = 0;

            int coin1000 = 0;
            int coin500 = 0;
            int coin100 = 0;
            int coin50 = 0;
            int coin20 = 0;
            int coin10 = 0;
            int coin5 = 0;
            int coin1 = 0;

            Console.WriteLine("Money to pay: {0} kr", randomPrice);

            while (keepLooping)
            {
                try
                {
                    Console.Write("Enter the sum to pay: ");
                    pay = int.Parse(Console.ReadLine());
                    if (pay < randomPrice)
                    {
                        Console.WriteLine("\nThe pay is to low!");
                    }
                    else
                    {
                        keepLooping = false;
                    }
                }
                catch
                {
                    Console.WriteLine("\nWill not accept pennies!");
                }

                change = pay - randomPrice;
                Console.WriteLine("\nCalculating change: {0}", change);

                Console.WriteLine("Change distribution:");

                keepLooping = true;
                while (keepLooping)
                {
                    if (change >= 1000)
                    {
                        coin1000 = change / 1000;
                        change = change - (coin1000 * 1000);
                        Console.WriteLine(coin1000);
                    }
                    else if (change >= 500)
                    {
                        coin500 = change / 500;
                        change = change - (coin500 * 500);
                    }
                    else if (change >= 100)
                    {
                        coin100 = change / 100;
                        change = change - (coin100 * 100);
                    }
                    else if (change >= 50)
                    {
                        coin50 = change / 50;
                        change = change - (coin50 * 50);
                    }
                    else if (change >= 20)
                    {
                        coin100 = change / 20;
                        change = change - (coin20 * 20);
                    }
                    else if (change >= 10)
                    {
                        coin10 = change / 10;
                        change = change - (coin10 * 10);
                    }
                    else if (change >= 5)
                    {
                        coin5 = change / 5;
                        change = change - (coin5 * 5);
                    }
                    else if (change >= 1)
                    {
                        coin1 = change / 1;
                        change = change - (coin1 * 1);
                    }
                    else
                    {
                        keepLooping = false;
                    }
                    
                }

                Console.WriteLine("1000 coins = {0}", coin1000);
                Console.WriteLine("500 coins = {0}", coin500);
                Console.WriteLine("100 coins = {0}", coin100);
                Console.WriteLine("50 coins = {0}", coin50);
                Console.WriteLine("20 coins = {0}", coin20);
                Console.WriteLine("10 coins = {0}", coin10);
                Console.WriteLine("5 coins = {0}", coin5);
                Console.WriteLine("1 coins = {0}", coin1);
            }
        }
    }
}
