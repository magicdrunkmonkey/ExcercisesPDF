using System;
using System.Collections.Generic;
using System.Text;

namespace ExcercisesPDF
{
    class Excercise4
    {
        public static void RunExcercise4()
        {
            // Declare and/or initiate variables
            String str = "The quick fox Jumped Over the DOG";
            string strTemp = str;

            // code here
            Console.WriteLine(strTemp);
            strTemp = str.Replace(str.Substring(14,1),"j");            //Replace letter J with j in Jumped

            Console.WriteLine(strTemp);
            strTemp = strTemp.Replace(strTemp.Substring(21, 1), "o");          //Replace letter O with o in Over

            strTemp = strTemp.Remove(30); //Remove "DOG" from string
            strTemp = strTemp + "lazy dog"; //Add "lazy dog" to the string

            //String is not typing "The quick fox jumped over the lazy dog"
            str = strTemp;
            str = str.Substring(0, 4); //Cut out "The "
            strTemp = strTemp.Substring(10, 28); //Cut out "fox jumped over the lazy dog"

            Console.WriteLine(str+"brown "+strTemp);
            
        }
    }
}
