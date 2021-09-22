using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcercisesPDF
{
    class ExcerciseTwo
    {
        public static void RunExcerciseTwo()
        {
            // Declare variables
            DateTime todaysDate = DateTime.Now;
            DateTime tomorrowsDate = todaysDate.AddDays(1);
            DateTime yesterdaysDate = todaysDate.AddDays(-1);

            Console.WriteLine("Todays date is {0}", todaysDate);
            Console.WriteLine("Tomorrows date is {0}", tomorrowsDate);
            Console.WriteLine("Yesterdays date was {0}", yesterdaysDate);
        }
    }
}
