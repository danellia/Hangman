using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();
            using (StreamReader sr = new StreamReader("words.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string word = sr.ReadLine();
                    words.Add(word);
                }
            }
            string[] Words = words.ToArray();

            Random rand = new Random();
            int currentWordIndex = rand.Next(0, Words.Length);
            string currentWord = Words[currentWordIndex];
            char[] progress = new char[currentWord.Length];
            int incorrectGuesses = 0;

            for (int progressIndex = 0; progressIndex < currentWord.Length; ++progressIndex)
            {
                progress[progressIndex] = '_';
            }

            while (progress.Contains('_'))
            {
                char playerGuess = char.Parse(Console.ReadLine());
                for (int guessIndex = 0; guessIndex < currentWord.Length; guessIndex++)
                {
                    if (playerGuess == currentWord[guessIndex])
                    {
                        progress[guessIndex] = playerGuess;
                    }
                    else
                    {
                        ++incorrectGuesses;
                    }

                }
                if (incorrectGuesses >= Animate.limbs.Length)
                {
                    break;
                }
                Console.WriteLine(progress);
            }
        }
    }
}
