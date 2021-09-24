using System;
using System.IO;


namespace ExcercisesPDF
{
    class Program
    {
        static void Main(string[] args)
        {
            var keepAlive = true;
            while (keepAlive)
            {
                try
                {
                    Console.Write("Enter assignment number (or -1 to exit): ");
                    var assignmentChoice = int.Parse(Console.ReadLine() ?? "");
                    Console.ForegroundColor = ConsoleColor.Green;
                    switch (assignmentChoice)
                    {
                        case 1:
                            Excercise01.RunExcercise1();
                            break;
                        case 2:
                            Excercise02.RunExcercise2();
                            break;
                        case 3:
                            Excercise03.RunExcercise3();
                            break;
                        case 4:
                            Excercise04.RunExcercise4();
                            break;
                        case 5:
                            Excercise05.RunExcercise5();
                            break;
                        case 6:
                            Excercise06.RunExcercise6();
                            break;
                        case 7:
                            Excercise07.RunExcercise7();
                            break;
                        case 8:
                            Excercise08.RunExcercise8();
                            break;
                        case 9:
                            Excercise09.RunExcercise9();
                            break;
                        case 10:
                            Excercise10.RunExcercise10();
                            break;
                        case 11:
                            Excercise11.RunExcercise11();
                            break;
                        case 12:
                            Excercise12.RunExcercise12();
                            break;
                        case 13:
                            Excercise13.RunExcercise13();
                            break;
                        case 14:
                            Excercise14.RunExcercise14();
                            break;
                        case 151:
                            Excercise151.RunExcercise15();
                            break;
                        case 152:
                            Excercise152.RunExcercise15();
                            break;
                        case 16:
                            Excercise16.RunExcercise16();
                            break;
                        case 17:
                            Excercise17.RunExcercise17();
                            break;
                        case 18:
                            Excercise18.RunExcercise18();
                            break;
                        case 19:
                            Excercise19.RunExcercise19();
                            break;
                        case -1:
                            keepAlive = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is not a valid assignment number!");
                            break;
                    }
                    Console.ResetColor();
                    Console.WriteLine("Hit any key to continue!");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid Assignment number!");
                    Console.ResetColor();
                }
            }
        }

    }
}
