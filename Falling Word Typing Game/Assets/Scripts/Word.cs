using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Word
{
    public string word;
    private int typeIndex;

    WordDisplay display;

    public Word(string word, WordDisplay display) 
    {
        this.word = word;
        typeIndex = 0;

        this.display = display;
        this.display.SetWord(word);
    }

    public char GetNextLetter()
    {
        return word[typeIndex];
    }

    public void TypeLetter()
    {
        typeIndex++;
        display.RemoveLetter();
    }

    public bool WordTyped()
    {
        bool wordType = (typeIndex >= word.Length);

        if (wordType)
        {
            display.RemoveWord();
        }

        return wordType;
    }

}
