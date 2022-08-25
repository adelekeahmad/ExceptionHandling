// See https://aka.ms/new-console-template for more information
namespace exceptionHandling;
class Program
{  
    static void Main(string[] args)
    {
        try
        {
            string secretWord = "Chelsea";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;
            while (guess != secretWord && !outOfGuesses)
            {

                if (guessCount < guessLimit)
                {
                    Console.Write("Who wins today's match: ");
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
                Console.Write("you lose!");
            }
            else
            {
                //if condition does not hold
                Console.Write("you win!");
            }
        }
        catch(Exception e)
        {
            Console.Write(e.Message);
        }
        
        Console.ReadLine();
    }
}
