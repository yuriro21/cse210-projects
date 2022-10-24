using System;
using System.Collections.Generic;

namespace Unit03.game;

// The responsibility of scret_word is to prove and store a word.
public class secret_word 
{   
    //Create a list  
    private List<string> wordsList = new List<string>();

    //Create a constuctor that initialize the list of words.
    public secret_word() {
        string[] words = {"mango", "mouse", "pray", "code", "game", "nephi"};
        wordsList.AddRange(words);
    }
    
    //Create a random number with the length of the words in the list, and pick one random word of the list.
    public string getWord() 
    {
        Random random = new Random();
        int index = random.Next(0,6);
        return wordsList[index];
    }

}