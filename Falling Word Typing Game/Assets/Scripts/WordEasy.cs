using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class WordEasy : MonoBehaviour {

    private static string[] wordList = { 
    //"sidewalk", "robin", "three", "protect", "periodic",
    //"somber", "majestic", "jump", "pretty", "wound", "jazzy", 
    //"memory", "join", "crack", "grade", "boot", "cloudy", "sick",
    //"mug", "hot", "tart", "dangerous", "mother", "rustic", "economic",
    //"weird", "cut", "parallel", "wood", "encouraging", "interrupt",
    //"guide", "long", "chief", "mom", "signal", "relay", "abortive",
    //"hair", "representative", "earth", "grate", "proud", "feel", 
    //"hilarious", "addition", "silent", "play", "floor", "numerous",
    //"friend", "pizzas", "building", "organic", "past", "mute", "unusual",
    //"mellow", "analyse", "crate", "homely", "protest", "painstaking", 
    //"society", "head", "female", "eager", "heap", "dramatic", "present",
    //"sin", "box", "pies", "awesome", "root", "available", "sleet", "wax",
    //"boring", "smash", "thought", "distinct", "nimble", "practise", "cream",
    //"ablaze", "thoughtless", "love", "verdict", "giant"
    };

    public static List<string> wordsEasy = new List<string>();

    public static void ReadFile()
    {
        //TextAsset easyWords = Resources.Load<TextAsset>("BeginnerWords");
        //string[] data = easyWords.text.Split(new char[] { ',' });

        //for (int i = 0; i < data.Length; i++)
        //{
        //    if (data[i] != "")
        //    {
        //        wordsEasy.Add(data[i]);
        //        Debug.Log(data[i]);
        //    }
        //}

        //wordList = wordsEasy.ToArray();

        StreamReader strReader = new StreamReader("/Users/BlazeMilner 1/Desktop/BeginnerWords.csv");
        bool endOFFile = false;

        while(!endOFFile)
        {
            string data_String = strReader.ReadLine();
            if (data_String == null)
            {
                endOFFile = true;
                break;
            }

            var data_values = data_String.Split(',');

            for (int i = 0; i < data_values.Length; i++)
            {
                wordsEasy.Add(data_values[i]);
            }

            wordList = wordsEasy.ToArray();
        }

    }

    public static string GetRandomWord()
    {
        ReadFile();
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }
}
