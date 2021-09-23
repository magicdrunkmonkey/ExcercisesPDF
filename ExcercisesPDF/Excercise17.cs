using System;
using System.Collections.Generic;
using System.Text;

namespace ExcercisesPDF
{
    class Excercise17
    {
        public static void RunExcercise17()
        {
            // Declare variables
            string wordTest="", wordTemp = "";

            Console.WriteLine("\n\nPalindrom checking");
            Console.WriteLine("__________________\n");
            try
            {
                Console.Write("Enter a word to check: ");
                wordTest = Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Can not accept that input as text!");
            }
            

            for (int i = wordTest.Length - 1; i >= 0; i--) //Pick out one letter at a time and
            {
                wordTemp += wordTest[i].ToString();        //placing it in reverse order one letter at a time to a temporary variable.
            }
            if (wordTemp == wordTest)                      //Checking if wordTest is the same as the reversed wordTemp.  
            {
                Console.WriteLine("\n\nThe word is a palindrome \n\n The word was {0} and reverse is the word {1}", wordTest, wordTemp);
            }
            else
            {
                Console.WriteLine("\n\nThe word is not a palindrome \n\n The word was {0} and reverse is the word {1}", wordTest, wordTemp);
            }
        }
    }
}
