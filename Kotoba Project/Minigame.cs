using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotoba_Project
{
    class MinigameScript : DictForMiniGame
    {
        ExtendedSearch eDict = new ExtendedSearch();
        MenuTranslations MT = new MenuTranslations();

        public int currentAmountOfPoints = 0;
        public int languagueSettingsUpdater;
        List<string> guessedWords = new List<string>();

        public MinigameScript()
        {
            Initialize();
        }

        public void StartGame()
        {
            eDict.Initialize();
            guessedWords.Clear();

            while (AreWordsAvailable())
            {
                KeyValuePair<string, string> word;
                do
                {
                    word = ChooseRandomWord();
                } while (guessedWords.Contains(word.Key));

                Console.WriteLine(MT.minigameGuessWordMessage1[languagueSettingsUpdater] + word.Key + MT.minigameGuessWordMessage2[languagueSettingsUpdater]);
                string answer = ReceiveAnswer().Trim().ToLower();

                if (KOTOBAN5.ContainsValue(answer))
                {
                    var correctWord = KOTOBAN5.FirstOrDefault(x => x.Value == answer).Key;

                    if (correctWord == word.Key.ToLower())
                    {
                        Console.Clear();
                        ShowCorrectFeedback();
                        ShowWordDefinition(answer);
                        currentAmountOfPoints += 1;
                        guessedWords.Add(word.Key);
                    }
                    else
                    {
                        Console.Clear();
                        ShowIncorrectFeedback(correctWord);
                    }
                }
                else
                {
                    Console.Clear();
                    ShowIncorrectFeedback(word.Value);
                }

                if (!AskIfThePlayerWantsToContinue())
                {
                    break;
                }
            }

            Console.WriteLine(MT.minigameEndsWithNoWordsLeft[languagueSettingsUpdater]);
            Console.ReadKey();
        }

        private bool AreWordsAvailable()
        {
            return KOTOBAN5.Count > guessedWords.Count;
        }

        public void ShowWordDefinition(string word)
        {
            if (eDict.extraJisho.ContainsKey(word))
            {
                Console.WriteLine(MT.minigameWordDescription[languagueSettingsUpdater]);
                List<string> definitions = eDict.extraJisho[word];
                foreach (string definition in definitions)
                {
                    Console.WriteLine(definition);
                }
            }
        }

        public KeyValuePair<string, string> ChooseRandomWord()
        {
            Random random = new Random();
            int index = random.Next(KOTOBAN5.Count);
            return KOTOBAN5.ElementAt(index);
        }

        public string ReceiveAnswer()
        {
            Console.Write(MT.minigameAnswerText[languagueSettingsUpdater]);
            return Console.ReadLine();
        }

        public void ShowCorrectFeedback()
        {
            Console.WriteLine(MT.minigameCorrectMessague[languagueSettingsUpdater] + " " + MT.currentAmountofPointsInfo[languagueSettingsUpdater] + (currentAmountOfPoints + 1));
        }

        private void ShowIncorrectFeedback(string correctWord)
        {
            Console.WriteLine(MT.minigameIncorrectAnswerMessague1[languagueSettingsUpdater] + correctWord + MT.minigameIncorrectAnswerMessague2[languagueSettingsUpdater]);
        }

        private bool AskIfThePlayerWantsToContinue()
        {
            Console.Write(MT.minigameContinueMessague[languagueSettingsUpdater]);
            string answer = Console.ReadLine().Trim().ToLower();
            Console.Clear();
            return answer == "y";
        }
    }
}