using System;

namespace Unit02.Game
{
    /// <summary>
    /// The responsibility of Card is to generate a number between 1 and 13 representing a card.
    /// </summary> 

    public class Card 
    {
        public int currentCard = 0;
        
        /// <summary>
        /// Constructs a new instance of Card.
        /// </summary>
        public Card()
        {
        }

        /// <summary>
        /// Generates a new random value for the Card.
        /// </summary>
        public void newCard()
        {
            Random random = new Random();
             currentCard = random.Next(1, 14);
        }
    }
}