//Programmer: Brian Lee
//Date: 05/30/2024

//Title: C# Programing CheatSheet
//-------------------------------------------------------------------------------

using System.Text.RegularExpressions;

//----------------------------------------------------------------------------
namespace C__Programming_CheatSheat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exitProgram = false;

            do
            {
                MenuSelection.MainMenu();
            } while (!exitProgram);
        }//end of Main
    }//end of Program (class)
    public class InputChecker
    {
        public static int MenuChecker(int firstChoice, int lastChoice)
        {
            int userInput;
            while (!int.TryParse(Console.ReadLine(), out userInput) || userInput < firstChoice || userInput > lastChoice)
            {
                Console.WriteLine("Inalid Input. Try Again.");
            }
            Console.WriteLine();
            return userInput;
        }//end of MenuChecker(method)
        public static int IntChecker()
        {
            int userInput;
            while(!int.TryParse(Console.ReadLine(), out userInput))
            {
                Console.WriteLine("Invalid Input. Try Again");
            }
            return userInput;
        }//end of IntChecker(method)
        public static double DoubleChecker()
        {
            double userInput;
            while (!double.TryParse(Console.ReadLine(), out userInput))
            {
                Console.WriteLine("Invalid Input. Try Again");
            }
            return userInput;
        }//end of DoubleChecker(method)
        public static string StringChecker()
        {
            string? userInput; 
            string pattern = @"^[a-zA-Z]+$";
            
            while((userInput = Console.ReadLine()) != null && Regex.IsMatch(userInput, pattern))
            {
                Console.WriteLine("Invalid Input. Try Again");
            }
            return userInput ?? string.Empty;
        }//end of StringChecker(method)
        
    }//end of InputChecker(class)
    public class MenuSelection
    {
        public static bool MainMenu()
        {
            const int firstChoice = 1;
            const int lastChoice = 4;
            int userInput;
            bool exitProgram = false;

            Console.WriteLine("Please Select Method");
            Console.WriteLine("1. Method 1");
            Console.WriteLine("2. Method 2");
            Console.WriteLine("3. Method 3");
            Console.WriteLine("4. Exit");
            Console.WriteLine();
            userInput = InputChecker.MenuChecker(firstChoice,lastChoice);

            switch (userInput)
            {
                case 1:
                    Console.WriteLine("Running Method1");
                    Console.WriteLine("-------------------");
                    MethodList.Method1();
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine("Running Method2");
                    Console.WriteLine("-------------------");
                    MethodList.Method2();
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine("Running Method3");
                    Console.WriteLine("-------------------");
                    MethodList.Method3();
                    Console.WriteLine();
                    break;
                case 4:
                    Console.WriteLine("Exiting Program");
                    exitProgram = true;
                    break;
                default:
                    Console.WriteLine("An Error has occured in MainMenu");
                    break;
            }
            return exitProgram;
        }//end of MainMenu(method)

    }//end of MenuSelection(class)
    public class MethodList
    {
        public static void Method1()
        {

        }//end of Method1(method)
        public static void Method2()
        {

        }//end of Method2(method)
        public static void Method3()
        {

        }//end of Method3(method)
    }//end of MethodList(class)
}
