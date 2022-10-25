using System;
using System.Collections.Generic;

namespace Unit03.game;

///The responsibility of skydive is to draw a figure and establish the condition to win or lose the game.
public class skydiver
{
    ///Construct a new instance for skydive
    public skydiver()
    {
    }

    ///Create a method to draw a skydiver.
    public void drawSkydive (int number)
    {
        if (number == 4)
        {
        Console.WriteLine("   ___");
        Console.WriteLine("  /___\\");
        Console.WriteLine("  \\   /");
        Console.WriteLine("   \\ /");
        Console.WriteLine("    0");
        Console.WriteLine("   /|\\");
        Console.WriteLine("   / \\");
        Console.WriteLine("\n^^^^^^^");
        }

        else if (number == 3)
        {
        Console.WriteLine("  /___\\");
        Console.WriteLine("  \\   /");
        Console.WriteLine("   \\ /");
        Console.WriteLine("    0");
        Console.WriteLine("   /|\\");
        Console.WriteLine("   / \\");
        Console.WriteLine("\n^^^^^^^");
        }

        else if (number == 2)
        {
        Console.WriteLine("  \\   /");
        Console.WriteLine("   \\ /");
        Console.WriteLine("    0");
        Console.WriteLine("   /|\\");
        Console.WriteLine("   / \\");
        Console.WriteLine("\n^^^^^^^");
        }

        else if (number == 1)
        {
        Console.WriteLine("   \\ /");
        Console.WriteLine("    0");
        Console.WriteLine("   /|\\");
        Console.WriteLine("   / \\");
        Console.WriteLine("\n^^^^^^^");
        }

        else if (number == 0)
        {
        Console.WriteLine("    x");
        Console.WriteLine("   /|\\");
        Console.WriteLine("   / \\");
        Console.WriteLine("\n^^^^^^^");
        }
    }

    //draw the line of the secret word and iterate through them to determine if the correct char is in the word.
    public void printWordState (string word, List <char> letter)
    {
        foreach (char c in word)
        {
            if (letter.Contains(c))
            {
                Console.Write(c);
            }

            else
            {
                Console.Write("_");
            }
        }
        Console.WriteLine("\n");
    }

}