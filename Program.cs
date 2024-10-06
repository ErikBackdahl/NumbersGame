using System.Drawing;

namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");

            Random random = new Random();

            int secretRandom = random.Next(0,20);
            bool correctGuess = false;
            int PlayerInput = 0;
            int totalGuesses  = 0;

            while(correctGuess == false)
            {

                dynamic tempNumber = Console.ReadLine();

                bool success = (int.TryParse(tempNumber, out PlayerInput));
                if (success)
                {
                    correctGuess = Checkguess(PlayerInput, secretRandom);

                    //keeps track of the ammout of guesses and fails the games after 5 guesses have been made.
                    
                    totalGuesses++;

                    if (totalGuesses == 5)
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("misslyckades. måste skriva ett nummer. försök igen:");

                }
            }

            if (correctGuess == false)
            {
                Console.WriteLine("“Tyvärr, du lyckades inte gissa talet på fem försök!");
            }
            else
            {
                Console.WriteLine("Wohoo! Du klarade det!");
            }
        }

        static bool Checkguess(int playerInput2, int secretRandom2)
        {
            if (playerInput2 == secretRandom2)
            {
                return true;
            }
            else if (playerInput2 > secretRandom2)
            {
                Console.WriteLine("Tyvärr, du gissade för högt!");
                return false;
            }
            else if (playerInput2 < secretRandom2)
            {
                Console.WriteLine("Tyvärr, du gissade för lågt!");
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}
