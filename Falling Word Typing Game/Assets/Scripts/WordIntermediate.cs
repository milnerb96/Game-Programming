using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class WordIntermediate : MonoBehaviour {

    private static string[] wordList = {
    //"aardvark", "abominable", "ammonia", "dementia", "beneveolent",
    //"delinquent", "chancellor", "bruxism", "delinquent", "denizen", "vestigial",
    //"vehement", "rambunctious", "psoriasis", "pyromania", "clientele", "biogenesis", "arrhythmia",
    //"circumference", "conservatory", "pseudonym", "topography", "ventriloquism", "saurischain", "repetitious",
    //"woebegone", "classification", "coexistence", "somersault", "sassafras", "demeanour",
    //"defibrillator", "desuetude", "sebaceous", "tabbouleh", "vanquish", "venoumous", "staphylococcus",
    //"taxidermist", "representative", "earth", "grate", "proud", "feel",
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

        StreamReader strReader = new StreamReader("/Users/BlazeMilner 1/Desktop/IntermediateWords.csv");
        bool endOFFile = false;

        while (!endOFFile)
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
