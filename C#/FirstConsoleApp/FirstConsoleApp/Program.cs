using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// namespace of the project
namespace FirstConsoleApp
{
    // the program object template
    class Program
    {
        // Entry start point
        static void Main(string[] args)
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Fredrick Okereke";

            // change the text color

            Console.ForegroundColor = ConsoleColor.DarkGreen;

            //Show the app info

            Console.WriteLine("{0}: Version {1}, by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();

            //Ask user name an greet

            Console.WriteLine("What's your name? ");

            string inputName = Console.ReadLine().ToUpper();

            Console.WriteLine("Hello {0}, welcome lets guess a number between 1 -10", inputName);


            // set correctNumber 

            int correctNumber = 7;

            // set guess

            int guess = 0;

            // init game

            while (guess != correctNumber)
            {
                // get users input
                string input = Console.ReadLine();

                // cast to int and put into guess

                guess = Convert.ToInt16(input);
                if (guess != correctNumber)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Wrong Number, please guess again");
                    Console.ResetColor();
                }

            }


            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Successful, You guessed it right...");
            Console.ResetColor();


        }
    }
}
