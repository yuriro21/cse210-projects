using System;

namespace Unit03.game;

/// <summary>
/// <para>A service that handles terminal operations.</para>
/// <para>
/// The responsibility of a Terminal is to provide input and output operations for the 
/// terminal.
/// </para>
/// </summary>
public class Terminal
{
    /// <summary>
    /// Constructs a new instance of Terminal.
    /// </summary>
    public Terminal()
    {
    }

    /// <summary>
    /// Gets a char from the terminal. Directs the user with the given prompt.
    /// </summary>
    /// <param name="prompt">The given prompt.</param>
    /// <returns>Inputted char.</returns>
    public char ReadChar(string prompt)
    {
        string rawValue = ReadText(prompt);
        char c = char.Parse(rawValue);
        return c;
    }

    /// <summary>
    /// Gets text input from the terminal. Directs the user with the given prompt.
    /// </summary>
    /// <param name="prompt">The given prompt.</param>
    /// <returns>Inputted text.</returns>
    public string ReadText(string prompt)
    {
        Console.Write(prompt);
        string letter = Console.ReadLine();
        return letter;            
    }
        
    /// <summary>
    /// Displays the given text on the terminal. 
    /// </summary>
    /// <param name="text">The given text.</param>
    public void WriteText(string text)
    {
        Console.WriteLine(text);
    }
}
