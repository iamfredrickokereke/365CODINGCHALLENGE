using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe.Whileloop
{
    class Guessgame
    {
        static void Main()
        {
            string secretWord = "Mercy";
            string guess = string.Empty;
            int guessCount = 0;
            const int guessLimit = 3;
            bool outOfGuesses = false;

          
            
                while (guess != secretWord && !outOfGuesses)
                {
                    if (guessCount < guessLimit) {
                        Console.Write("Enter a guess: ");
                        guess = Console.ReadLine();
                        guessCount++;
                    }
                    else
                    {
                    outOfGuesses = true;
                    }

                }

            if (outOfGuesses)
            {
                Console.Write("You have exceeded the limit and you lost!");

            }
            else
            {
                Console.WriteLine("You guessed right! with {0} attempts", guessCount);
            }
         
        }

    }
}
