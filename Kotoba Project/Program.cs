using System;
using System.CodeDom.Compiler;
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
            HiraganaDictionary hiraganaDict = new HiraganaDictionary();
            Genki1 genki1 = new Genki1();

            bool programIsOn = true;
            string searchBar;
            string dictModeSelector;

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
                        /*Console.Clear();
                        Console.WriteLine(MT.dictionaryMenu[MT.languageVariable] + "\n \n" + MT.currentNumberOfWords[MT.languageVariable] + "402 \n" + MT.currentNumberOfDefinitions[MT.languageVariable] + "486");
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
                            if (!hiraganaDict.kanaDict.ContainsKey(searchBar))
                            {
                                if (EDict.extraJisho.ContainsKey(searchBar))
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
                                else if (!EDict.extraJisho.ContainsKey(searchBar))
                                {
                                    Console.Clear();
                                    Console.WriteLine(MT.dictionaryErrorExtendedSearch[MT.languageVariable] + searchBar);
                                    Console.ReadKey();
                                }
                            }
                            else
                            {
                                Console.Clear();
                                List<string> definitions = hiraganaDict.kanaDict[searchBar.ToLower()];
                                Console.WriteLine(MT.wordDefinitionMessage[MT.languageVariable] + $"{searchBar}");

                                foreach (string definition in definitions)
                                {
                                    Console.WriteLine(definition);
                                }

                                Console.ReadKey();
                                
                            }
                        }*/

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
                    else if (keyPressed.Key == ConsoleKey.D4)
                    {
                        Console.Clear();
                        Console.WriteLine(MT.grammarDictTitleMessage[MT.languageVariable] + "\n \n" + MT.grammarDictMode1[MT.languageVariable]);
                        keyPressed = Console.ReadKey();

                        if (keyPressed.Key == ConsoleKey.D1)
                        {
                            Console.Clear();
                            Console.WriteLine(MT.genki1ModeTitleMessage[MT.languageVariable] + "\n \n" + 
                                MT.genki1Chapter1[MT.languageVariable] + "\n " + 
                                MT.genki1Chapter1point1[MT.languageVariable] + "\n " + 
                                MT.genki1Chapter1point2[MT.languageVariable] + "\n " + 
                                MT.genki1Chapter1point3[MT.languageVariable] + "\n" + 
                                MT.genki1Chapter2[MT.languageVariable] + "\n " + 
                                MT.genki1Chapter2point1[MT.languageVariable] + "\n " + 
                                MT.genki1Chapter2point2[MT.languageVariable] + "\n " + 
                                MT.genki1Chapter2point3[MT.languageVariable] + "\n " + 
                                MT.genki1Chapter2point4[MT.languageVariable] + "\n " + 
                                MT.genki1Chapter2point5[MT.languageVariable] + "\n " + 
                                MT.genki1Chapter2point6[MT.languageVariable] + "\n " + 
                                MT.genki1Chapter2point7[MT.languageVariable] + "\n" +
                                MT.genki1Chapter3[MT.languageVariable] + "\n " +
                                MT.genki1Chapter3point1[MT.languageVariable] + "\n " +
                                MT.genki1Chapter3point2[MT.languageVariable] + "\n " +
                                MT.genki1Chapter3point3[MT.languageVariable] + "\n " +
                                MT.genki1Chapter3point4[MT.languageVariable] + "\n " +
                                MT.genki1Chapter3point5[MT.languageVariable] + "\n " +
                                MT.genki1Chapter3point6[MT.languageVariable] + "\n " +
                                MT.genki1Chapter3point7[MT.languageVariable] + "\n " +
                                MT.genki1Chapter3point8[MT.languageVariable] + "\n ");
                            dictModeSelector = Console.ReadLine();

                            if (dictModeSelector.ToLower() == "1")
                            {
                                Console.Clear();
                                if (MT.languageVariable == 1 || MT.languageVariable == 2 || MT.languageVariable == 4)
                                {
                                    Console.WriteLine(genki1.topicTitle[MT.languageVariable] + genki1.chapter1name[MT.languageVariable] + "\n");
                                }
                                else if (MT.languageVariable == 3)
                                {
                                    Console.WriteLine("「" + genki1.chapter1name[MT.languageVariable] + "」" + genki1.topicTitle[MT.languageVariable] + "\n");
                                }
                                Console.WriteLine(genki1.chapter1Definition1[MT.languageVariable]);
                                Console.ReadKey();
                            }

                            else if (dictModeSelector.ToLower() == null)
                            {
                                
                            }
                            else
                            {

                            }
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
                            hiraganaDict.languagueSettingsUpdater = 0;
                            hiraganaDict.Initialize();
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
                            hiraganaDict.languagueSettingsUpdater = 1;
                            hiraganaDict.Initialize();
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
                            hiraganaDict.languagueSettingsUpdater = 2;
                            hiraganaDict.Initialize();
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
                            hiraganaDict.languagueSettingsUpdater = 3;
                            hiraganaDict.Initialize();
                        }
                    }
                }
                else if (keyPressed.Key == ConsoleKey.D4)
                {
                    Console.Clear();
                    Console.WriteLine(MT.versionInfo[MT.languageVariable] + "Alpha 0.0.0.2");
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
}