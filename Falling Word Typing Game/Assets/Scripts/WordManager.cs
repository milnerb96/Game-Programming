using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WordManager : MonoBehaviour {

    public List<Word> words;
    public WordSpawner wordSpawner;

    private bool hasActiveWord;
    private Word activeWord;


    public void AddWord()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (sceneName == "Beginner")
        {
            Word word = new Word(WordEasy.GetRandomWord(), wordSpawner.SpawnWord());
            Debug.Log(word.word);

            words.Add(word);
        }
        else if (sceneName == "Intermediate")
        {
            Word word = new Word(WordIntermediate.GetRandomWord(), wordSpawner.SpawnWord());
            Debug.Log(word.word);

            words.Add(word);
        }
        else if (sceneName == "Expert")
        {
            Word word = new Word(WordAdvance.GetRandomWord(), wordSpawner.SpawnWord());
            Debug.Log(word.word);

            words.Add(word);
        }
    }

    public void TypeLetter(char letter)
    {
        if (hasActiveWord) 
        {
            if (activeWord.GetNextLetter() == letter)
            {
                activeWord.TypeLetter();
            }
        }
        else
        {
            foreach(Word word in words)
            {
                if (word.GetNextLetter() == letter)
                {
                    activeWord = word;
                    hasActiveWord = true;
                    word.TypeLetter();
                    break;
                }
            }
        }

        if (hasActiveWord && activeWord.WordTyped())
        {
            hasActiveWord = false;
            words.Remove(activeWord);
        }
    }
}
