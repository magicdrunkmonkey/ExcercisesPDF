using System;
using System.Collections.Generic;
using System.Text;

namespace ExcercisesPDF
{
    class Excercise3
    {
        public static void RunExcercise3()
        {
            // Declare variables
            string firstName, lastName;

            Console.Write("What is your first name: ");
            firstName = Console.ReadLine();
            Console.Write("What is your last name: ");
            lastName = Console.ReadLine();

            Console.WriteLine("\nYour full name is {0} {1}", firstName, lastName);
        }
    }
}
