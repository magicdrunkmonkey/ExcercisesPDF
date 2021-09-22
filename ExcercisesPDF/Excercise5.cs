using System;
using System.Collections.Generic;
using System.Text;

namespace ExcercisesPDF
{
    class Excercise5
    {
        public static void RunExcercise5()
        {
            String str = "Arrays are very common in programming, they look something like: [1,2,3,4,5]";
            string strTemp;
            str = str.Substring(str.IndexOf("["), ((str.IndexOf("]")+1) - (str.IndexOf("["))));
            Console.WriteLine(str);
            //[1,2,3,4,5]
            strTemp = str.Substring(0, 3);
            str = str.Substring(7,3);
            str = strTemp + str + ",6,7,8,9,10]";

            Console.WriteLine(str);

            //Console.ReadLine();


        }
    }
}
