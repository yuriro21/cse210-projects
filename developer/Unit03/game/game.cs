using System;
using System.Collections.Generic;

namespace Unit03.game;

    // The responsibility of a game is to control the sequence of play.
    public class game
    {   
        private List<char> userGuesses = new List<char>();
        /// Constructs a new instance of Director.
        public game()
        {
        }

        public void startGame()
        {
            secret_word scretWord = new secret_word();
            skydiver skyDiver = new skydiver();
            Terminal terminal = new Terminal();

            int numGuesses = 4;
            int win = 0;
            string word = scretWord.getWord();

            Console.WriteLine("Welcome to Jumpler game");
            initializeState(word);

            while (numGuesses > 0)
            {
                if (win == word.Length) {
                    Console.Write("Gongratilation! You Won!");
                    break;
                }

                skyDiver.drawSkydive(numGuesses);
                char c = terminal.ReadChar("Guess a letter [a-z]: ");
                userGuesses.Add(c);

                skyDiver.printWordState(word, userGuesses);

                if (isFound(word, c))
                {
                    win++;
                    continue;
                }
                else
                {
                    numGuesses--;
                }
                if (numGuesses == 0) {
                    skyDiver.drawSkydive(numGuesses);
                    Console.WriteLine("You lost, good luck next time.");
                }

            }

        }

        private void initializeState(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine("\n");            
        }

        private bool isFound(string word, char guess)
        {
            for (int i = 0; i < word.Length; i++) {
                if (word[i] == guess) {
                    return true;
                }
            }
            return false;
        }
    }