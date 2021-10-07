using System;
using System.Collections.Generic;
using System.Text;

namespace ExcercisesPDF
{
    class Excercise22
    {
        public static void RunExcercise22()
        {
            // Declare variables
            string userInputText;
            StringBuilder sb = new StringBuilder();

            //ShowSBInfo(sb);

            Console.Write("Write any text (do not use swearwords): ");
            userInputText = Console.ReadLine();
            sb.AppendFormat(userInputText);

            //ShowSBInfo(sb);

            string[] stringArray = sb.ToString().Split(" "); //Split words to array

            //Console.WriteLine(stringArray.ToString());

            string[] badWords = CheckForHarshWords(stringArray); // Check text for bad words and store in array

            //Replace bad words
            for(int i=0; i<stringArray.Length; i++)
            {
                for (int j = 0; j < badWords.Length; j++)
                {
                    string temp1 = stringArray[i].ToUpper();
                    string temp2 = badWords[j].ToUpper();
                    string strReplace = "";
                    if (temp1 == temp2)
                    {
                        for (int x = 0; x <= badWords[j].Length; x++)
                        {
                            strReplace += "*";
                        }
                        stringArray[i] = strReplace;
                    }
                }
            }

            Console.WriteLine("\nOriginal text" +
                              "\n---------"+
                              "\n"+userInputText);
            

            Console.WriteLine("\nCensured text" +
                              "\n---------");
            foreach (string items in stringArray)
            {
                Console.WriteLine(items);
            }


            Console.WriteLine("\nBad Words" +
                              "\n---------");
            foreach(string items in badWords)
            {
                try
                {
                    Console.WriteLine(items);
                }
                catch
                {

                }
                
            }

            sb.Clear();

            ShowSBInfo(sb);
            
        }

        private static string[] CheckForHarshWords(string[] words)
        {
            //string[] result = new string[0];
            string[] result = Array.Empty<string>();
            string[] badWordsListArray;
            int count = 0;

            // Creating a List<T> of strings 
            List<string> BadWords = new List<string>();

            // Bad words to List 
            BadWords.Add("fuck");
            BadWords.Add("dumhuvud");
            BadWords.Add("skit");

            badWordsListArray = BadWords.ToArray();

            for (int i=0; i < words.Length; i++)
            {
                for(int j=0; j < badWordsListArray.Length; j++)
                {
                    string temp1 = words[i].ToUpper();
                    string temp2 = badWordsListArray[j].ToUpper();
                    if(temp1 == temp2)
                    {
                        Array.Resize(ref result, result.Length + 1);
                        result[count] = temp1;
                        count++;
                    }
                }
            }

            return result;
        }

        private static void ShowSBInfo(StringBuilder sb)
        {
            foreach (var prop in sb.GetType().GetProperties())
            {
                if (prop.GetIndexParameters().Length == 0)
                    Console.Write("{0}: {1:N0}    ", prop.Name, prop.GetValue(sb));
            }
            Console.WriteLine();
        }
    }
}
