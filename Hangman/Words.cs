using System;
using System.Collections.Generic;
using System.IO;

public class Words
{
    static List<string> words = new List<string>();
    static string[] WordsList;
    static int currentWordIndex;
    public static string currentWord;
    public static void ChooseCurrentWord()
    {
        Random rand = new Random();
        currentWordIndex = rand.Next(0, WordsList.Length);
        currentWord = WordsList[currentWordIndex];
    }
    public static void GetList()
    {
        using (StreamReader sr = new StreamReader("words.txt"))
        {
            while (!sr.EndOfStream)
            {
                string word = sr.ReadLine();
                words.Add(word);
            }
        }
        WordsList = words.ToArray();
    }
}
