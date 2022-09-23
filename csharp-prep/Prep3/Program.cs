using System;

namespace Prep3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Prep 3, Loops");

            string game = "yes";

            while (game == "yes")
            {
                Random randomGenerator = new Random();
                int magicNumber = randomGenerator.Next(1, 100);
                
                int guessU = 0;
                int count = 0;

                while (magicNumber != guessU)
                {
                    Console.Write("What is your guess? ");
                    guessU = int.Parse(Console.ReadLine());
                                
                    if (magicNumber > guessU)
                    {
                        Console.WriteLine("Higher");
                    }
                    else if (magicNumber < guessU)
                    {
                        Console.WriteLine("Lower");
                    }
                    else
                    {
                        Console.WriteLine("You guessed it!");
                    }

                    count = count + 1;
                }

                Console.WriteLine($"You tried {count}");
                Console.WriteLine("Do you want to play again? ");
                game = Console.ReadLine();
            }


        }
    }
}
