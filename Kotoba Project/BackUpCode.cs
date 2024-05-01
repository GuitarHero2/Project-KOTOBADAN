using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotoba_Project
{
    //Just backup code in case I screw up the one I'm already using.

    /*class MinigameScript : DictForMiniGame
    {
        ExtendedSearch eDict = new ExtendedSearch();
        MenuTranslations MT = new MenuTranslations();

        public int currentAmountOfPoints = 0;
        public int languagueSettingsUpdater;

        public MinigameScript()
        {
            Initialize();
        }

        public void StartGame()
        {
            eDict.Initialize();

            while (true)
            {
                KeyValuePair<string, string> word = ChooseRandomWord();

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
    }*/

    // BACKUP of the main script


    /*
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Kotoba_Project
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.Title = "Project 言葉暖";

                Console.OutputEncoding = Encoding.Unicode;
                Console.InputEncoding = System.Text.Encoding.Unicode;

                Dictionary dict = new Dictionary();
                ExtendedSearch EDict = new ExtendedSearch();
                EnglishDictionary enDict = new EnglishDictionary();
                MenuTranslations MT = new MenuTranslations();
                MinigameScript quizGame = new MinigameScript();

                bool programIsOn = true;
                string searchBar;

                while (programIsOn)
                {
                    Console.Clear();
                    Console.WriteLine(MT.welcomeMessage[MT.languageVariable] + MT.mainMenuSelection[MT.languageVariable]);
                    ConsoleKeyInfo keyPressed = Console.ReadKey();

                    if (keyPressed.Key == ConsoleKey.D1)
                    {
                        Console.Clear();
                        Console.WriteLine(MT.choosingGameModeTitle[MT.languageVariable] + MT.levelSelectorMessage[MT.languageVariable]);
                        keyPressed = Console.ReadKey();

                        if (keyPressed.Key == ConsoleKey.D5)
                        {
                            Console.Clear();
                            quizGame.StartGame();
                        }
                    }
                    else if (keyPressed.Key == ConsoleKey.D2)
                    {
                        Console.Clear();
                        Console.WriteLine(MT.chooseDictionaryMenu[MT.languageVariable] +
                                   "\n" + MT.dictionaryModes1[MT.languageVariable] +
                                   "\n" + MT.dictionaryModes2[MT.languageVariable] +
                                   "\n" + MT.dictionaryModes3[MT.languageVariable] +
                                   "\n" + MT.dictionaryModes4[MT.languageVariable] +
                                   "\n" + MT.dictionaryModes5[MT.languageVariable]);

                        keyPressed = Console.ReadKey();

                        if (keyPressed.Key == ConsoleKey.D1)
                        {
                            Console.Clear();
                            Console.WriteLine(MT.dictionaryMenu[MT.languageVariable] + "\n \n" + MT.currentNumberOfWords[MT.languageVariable] + "204 \n" + MT.currentNumberOfDefinitions[MT.languageVariable] + "233");
                            searchBar = Console.ReadLine();

                            if (dict.jisho.ContainsKey(searchBar))
                            {
                                Console.Clear();
                                List<string> definitions = dict.jisho[searchBar];
                                Console.WriteLine(MT.wordDefinitionMessage[MT.languageVariable] + $"{searchBar}");

                                foreach (string definition in definitions)
                                {
                                    Console.WriteLine(definition);
                                }

                                Console.ReadKey();
                            }
                            else
                            {

                                Console.Clear();
                                Console.WriteLine(MT.dictionaryError[MT.languageVariable] + searchBar + "\n \n" + MT.dictionaryExtendedSearchMessage[MT.languageVariable]);
                                keyPressed = Console.ReadKey();

                                if (keyPressed.Key == ConsoleKey.Y)
                                {
                                    if (EDict.extraJisho.ContainsKey(searchBar.ToLower()))
                                    {
                                        Console.Clear();
                                        List<string> definitions = EDict.extraJisho[searchBar.ToLower()];
                                        Console.WriteLine(MT.wordDefinitionMessage[MT.languageVariable] + $"{searchBar}");

                                        foreach (string definition in definitions)
                                        {
                                            Console.WriteLine(definition);
                                        }

                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine(MT.dictionaryErrorExtendedSearch[MT.languageVariable] + searchBar);
                                        keyPressed = Console.ReadKey();
                                    }
                                }
                            }

                        }
                        else if (keyPressed.Key == ConsoleKey.D2)
                        {
                            Console.Clear();
                            Console.WriteLine(MT.dictionaryMenu[MT.languageVariable] + "\n \n" + MT.currentNumberOfWords[MT.languageVariable] + "2 \n" + MT.currentNumberOfDefinitions[MT.languageVariable] + "5");
                            searchBar = Console.ReadLine();

                            if (enDict.englishJisho.ContainsKey(searchBar.ToLower()))
                            {
                                Console.Clear();
                                List<string> definitions = enDict.englishJisho[searchBar.ToLower()];
                                Console.WriteLine(MT.wordDefinitionMessage[MT.languageVariable] + $"{searchBar}");

                                foreach (string definition in definitions)
                                {
                                    Console.WriteLine(definition);
                                }

                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine(MT.dictionaryError[MT.languageVariable] + searchBar);
                                Console.ReadKey();
                            }
                        }
                    }
                    else if (keyPressed.Key == ConsoleKey.D3)
                    {
                        Console.Clear();
                        Console.WriteLine(MT.settingsTitle[MT.languageVariable] + MT.settingsMenuSelection[MT.languageVariable]);

                        keyPressed = Console.ReadKey();

                        if (keyPressed.Key == ConsoleKey.D1)
                        {
                            Console.Clear();
                            Console.WriteLine(MT.languagueMenuTitle[MT.languageVariable] + MT.languagueMenuOptions[MT.languageVariable]);

                            keyPressed = Console.ReadKey();

                            if (keyPressed.Key == ConsoleKey.D1)
                            {
                                MT.languageVariable = 0;
                                quizGame.languagueSettingsUpdater = 0;
                                quizGame.Initialize();
                                dict.languagueSettingsUpdater = 0;
                                dict.Initialize();
                                EDict.languagueSettingsUpdater = 0;
                                EDict.Initialize();
                            }
                            else if (keyPressed.Key == ConsoleKey.D2)
                            {
                                MT.languageVariable = 1;
                                quizGame.languagueSettingsUpdater = 1;
                                quizGame.Initialize();
                                dict.languagueSettingsUpdater = 1;
                                dict.Initialize();
                                EDict.languagueSettingsUpdater = 1;
                                EDict.Initialize();
                            }
                            else if (keyPressed.Key == ConsoleKey.D3)
                            {
                                MT.languageVariable = 2;
                                quizGame.languagueSettingsUpdater = 2;
                                quizGame.Initialize();
                                dict.languagueSettingsUpdater = 2;
                                dict.Initialize();
                                EDict.languagueSettingsUpdater = 2;
                                EDict.Initialize();
                            }
                            else if (keyPressed.Key == ConsoleKey.D4)
                            {
                                MT.languageVariable = 3;
                                quizGame.languagueSettingsUpdater = 3;
                                quizGame.Initialize();
                                dict.languagueSettingsUpdater = 3;
                                dict.Initialize();
                                EDict.languagueSettingsUpdater = 3;
                                EDict.Initialize();
                            }
                        }
                    }
                    else if (keyPressed.Key == ConsoleKey.D4)
                    {
                        Console.Clear();
                        Console.WriteLine(MT.versionInfo[MT.languageVariable] + "Alpha 0.0.0.1");
                        Console.WriteLine(MT.currentAmountofPointsInfo[MT.languageVariable] + quizGame.currentAmountOfPoints);
                        Console.WriteLine("\n \n \n" + "This program has been coded by Nozomi Kobayashi");
                        Console.ReadKey();
                    }
                    else if (keyPressed.Key == ConsoleKey.D5)
                    {
                        programIsOn = false;
                    }
                }
            }
        }
    } */


}
