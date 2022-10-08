using System;
using System.Collections.Generic;


namespace Unit02.Game
{
    /// <summary>
    /// A person who directs the game. 
    ///
    /// The responsibility of a Director is to control the sequence of play.
    /// </summary>
    public class Director
    {
        List<Card> deck = new List<Card>();
        bool isPlaying = true;
        int live = 300; //The user start with 300 points
        int win = 100; //Each time that the user wins, he wins 100 points
        int loss = 75; //Each time that the user loss, he loss 75 points 
        int actualCard = 0;
        int nextCard = 0;

        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director() 
        {
            for (int i = 0; i < 1; i++)
            {
                Card card = new Card();
                deck.Add(card);
            }
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>

        public void StartGame()
        {
            Console.WriteLine("Welcom to Guess the Card!");

            foreach (Card card in deck)
            {
                card.newCard();
                actualCard = card.currentCard;
            }

            while (isPlaying)
            {
                game();
                DoUpScore();                
            }
        }

        /// <summary>
        /// Asks the user what he thinks.
        /// </summary>
        public void game()
        {
            Console.WriteLine($"The card is: {actualCard}");

            if (!isPlaying)
            {
                return;
            }

            foreach (Card card in deck)
            {
                card.newCard();
                nextCard = card.currentCard;
            }
            
            Console.Write("Higher ir lower? [h/l] ");
            string userGuess = Console.ReadLine();
            Console.WriteLine($"Next card was: {nextCard}");

            if (userGuess == "h" && actualCard < nextCard)
            {
                live += win;
            }

            else if (userGuess == "h" && actualCard > nextCard)
            {
                live -= loss;
                if (live < 0)
                {
                    live = 0;
                }
            }

            else if (userGuess == "l" && actualCard > nextCard)
            {
                live += win;
            }

            else if (userGuess == "l" && actualCard < nextCard)
            {
                live -= loss;
                if (live < 0)
                {
                    live = 0;
                }
            }            
        }

        /// <summary>
        /// Updates the player's score.
        /// </summary>
        public void DoUpScore()
        {
            Console.WriteLine($"Your score is: {live}");
            
            if (live == 0)
            {
                isPlaying = false;
                Console.WriteLine("Game Over. Good luck for the next time.");
            }

            actualCard = nextCard;
            Console.Write("Play again? [y/n] ");
            string userWant = Console.ReadLine();
            isPlaying = (userWant == "y");
        }
    }
}