using System;
using System.Linq;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 15);
            Words.GetList();
            Words.ChooseCurrentWord();
            Animate.FillProgress();

            while (Animate.progress.Contains('_') && Animate.incorrectGuesses < Animate.limbs.Length)
            {
                Animate.RenderGameState();
                string input = Console.ReadLine();
                if (input.Length > 1)
                {
                    continue;
                }
                char playerGuess = char.Parse(input);
                for (int guessIndex = 0; guessIndex < Words.currentWord.Length; ++guessIndex)
                {
                    if (Animate.progress[guessIndex] == '_' && Words.currentWord[guessIndex] == playerGuess)
                    {
                        Animate.progress[guessIndex] = playerGuess;
                    }
                }
                if (!Words.currentWord.Contains(playerGuess))
                {
                    ++Animate.incorrectGuesses;
                }
            }
            
            if (Animate.incorrectGuesses >= Animate.limbs.Length)
            {
                Animate.Death();
            } else
            {
                Animate.Win();
            }
        }
    }
}
