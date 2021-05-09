using System;
using System.Linq;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Words.GetList();
            Words.ChooseCurrentWord();
            Animate.FillProgress();

            while (Animate.progress.Contains('_') && Animate.incorrectGuesses < Animate.limbs.Length)
            {
                Animate.RenderGameState();
                char playerGuess = char.Parse(Console.ReadLine());
                for (int guessIndex = 0; guessIndex < Words.currentWord.Length; ++guessIndex)
                {
                    if (Animate.progress[guessIndex] == '_' && Words.currentWord[guessIndex] == playerGuess)
                    {
                        Animate.progress[guessIndex] = playerGuess;
                    }
                }
                if (!Words.currentWord.Contains(playerGuess)) ++Animate.incorrectGuesses;
            }
        }
    }
}
