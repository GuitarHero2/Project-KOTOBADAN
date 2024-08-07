using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
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

            bool programIsOn = true;
            string searchBar;
            string dictModeSelector;

            string line;
            string pathForMainFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "KOTOBADAN");
            string pathForGenki1Folder = Path.Combine(pathForMainFolder, "Genki 1");
            bool dictErrorMessage = false;

            // Crear la carpeta principal y la subcarpeta "Genki 1" si no existen
            if (!Directory.Exists(pathForGenki1Folder))
            {
                Directory.CreateDirectory(pathForGenki1Folder);
            }

            // Crear el archivo "Genki1Dict.txt" dentro de "Genki 1" si no existe
            string genki1DictErrorEN = Path.Combine(pathForGenki1Folder, "Genki1ErrorEN.txt");
            string genki1DictErrorES = Path.Combine(pathForGenki1Folder, "Genki1ErrorES.txt");
            string genki1DictErrorJP = Path.Combine(pathForGenki1Folder, "Genki1ErrorJP.txt");
            string genki1DictErrorSW = Path.Combine(pathForGenki1Folder, "Genki1ErrorSW.txt");
            string genki1DictBlank = Path.Combine(pathForGenki1Folder, "Genki1DictBlank.txt");
            string genki1Grammar1 = Path.Combine(pathForGenki1Folder, "Genki1Grammar1.txt");
            string genki1Grammar2 = Path.Combine(pathForGenki1Folder, "Genki1Grammar2.txt");
            string genki1Grammar3 = Path.Combine(pathForGenki1Folder, "Genki1Grammar3.txt");
            string genki1Grammar4 = Path.Combine(pathForGenki1Folder, "Genki1Grammar4.txt");
            string genki1Grammar5 = Path.Combine(pathForGenki1Folder, "Genki1Grammar5.txt");
            string genki1Grammar6 = Path.Combine(pathForGenki1Folder, "Genki1Grammar6.txt");
            string genki1Grammar7 = Path.Combine(pathForGenki1Folder, "Genki1Grammar7.txt");
            string genki1Grammar8 = Path.Combine(pathForGenki1Folder, "Genki1Grammar8.txt");
            string genki1Grammar9 = Path.Combine(pathForGenki1Folder, "Genki1Grammar9.txt");
            string genki1Grammar10 = Path.Combine(pathForGenki1Folder, "Genki1Grammar10.txt");
            string genki1Grammar11 = Path.Combine(pathForGenki1Folder, "Genki1Grammar11.txt");
            string genki1Grammar12 = Path.Combine(pathForGenki1Folder, "Genki1Grammar12.txt");
            string genki1Grammar13 = Path.Combine(pathForGenki1Folder, "Genki1Grammar13.txt");
            string genki1Grammar14 = Path.Combine(pathForGenki1Folder, "Genki1Grammar14.txt");
            string genki1Grammar15 = Path.Combine(pathForGenki1Folder, "Genki1Grammar15.txt");
            string genki1Grammar16 = Path.Combine(pathForGenki1Folder, "Genki1Grammar16.txt");
            string genki1Grammar17 = Path.Combine(pathForGenki1Folder, "Genki1Grammar17.txt");
            string genki1Grammar18 = Path.Combine(pathForGenki1Folder, "Genki1Grammar18.txt");
            if (!File.Exists(genki1DictErrorEN))
            {
                using (StreamWriter sw = File.CreateText(genki1DictErrorEN))
                {
                    sw.WriteLine("---------------------------------- ERROR MESSAGE ----------------------------------" +
            "\n Please check that you have installed all Genki 1 dictionaries correctly. \n If you don't know how, follow the following steps right bellow:" +
            "\n 1. Download the necessary files from '@@@'" +
            "\n 2. Go to your Documents folder, KOTOBADAN, Genki 1 Folder and paste them there. If it ask to overwrite the files, do it." +
            "\n 3. Restart the app. Remember to close the program before pasting the files." +
            "\n 4. Try again." +
            "\n" +
            "\n Notes: If you don't see this after doing the proccess and there is no text when selecting a grammar in the list" +
            "\n        Check the content of the TXT files.");
                }
                using (StreamWriter sw = File.CreateText(genki1DictErrorES))
                {
                    sw.WriteLine("---------------------------------- MENSAJE DE ERROR ----------------------------------" +
            "\n Por favor compruebe que ha installado todos los diccionarios de Genki 1 correctamente. \n Si no sabe cómo, siga los siguientes pasos a continuación:" +
            "\n 1. Descargue los archivos necesarios desde '@@@'" +
            "\n 2. Vaya a su carpeta Documentos, KOTOBADAN, Genki 1 y pegue todo allí. Si se le pregunta por sobreescribir, hagalo." +
            "\n 3. Reinicie la app. Recuerde cerrar el programa antés de pegar los archivos." +
            "\n 4. Intentelo de nuevo" +
            "\n" +
            "\n Notes: Si usted no ve este mensaje luego de hacer el proceso y no hay texto cuando selecciona una gramatica de la lista" +
            "\n        Compruebe el contenido de los archivos TXT.");
                }
                using (StreamWriter sw = File.CreateText(genki1DictErrorJP))
                {
                    sw.WriteLine();
                }
                using (StreamWriter sw = File.CreateText(genki1DictErrorSW))
                {
                    sw.WriteLine("---------------------------------- ERROR ----------------------------------" +
            "\n Bekräfta om alla filer är installerad korrekt. \n Om du inte vet hur, följa dessa följande step:" +
            "\n 1. Ladda ner de vederbörliga filerna från '@@@'" +
            "\n 2. Gå till din Dokumenter mapp, KOTOBADAN, Genki 1 och klistra in alla filer där. Om programmet frågar för att överskriva filer, gör det" +
            "\n 3. Starta om appen. Kom ihåg att stänga programmet innan ni klistrar in filerna." +
            "\n 4. Försök igen" +
            "\n" +
            "\n Notes: Om ni inte ser det här meddelande efter du gör processen och det inte finns något text när du väljer en grammatik från listan" +
            "\n        Bekräft filersinnehåll.");
                }
                using (StreamWriter sw = File.CreateText(genki1DictBlank))
                {
                    dictErrorMessage = true;
                    sw.WriteLine();
                }

                using (StreamWriter sw = File.CreateText(genki1Grammar1))
                {
                    sw.WriteLine();
                }
                using (StreamWriter sw = File.CreateText(genki1Grammar2))
                {
                    sw.WriteLine();
                }
                using (StreamWriter sw = File.CreateText(genki1Grammar3))
                {
                    sw.WriteLine();
                }
                using (StreamWriter sw = File.CreateText(genki1Grammar4))
                {
                    sw.WriteLine();
                }
                using (StreamWriter sw = File.CreateText(genki1Grammar5))
                {
                    sw.WriteLine();
                }
                using (StreamWriter sw = File.CreateText(genki1Grammar6))
                {
                    sw.WriteLine();
                }
                using (StreamWriter sw = File.CreateText(genki1Grammar7))
                {
                    sw.WriteLine();
                }
                using (StreamWriter sw = File.CreateText(genki1Grammar8))
                {
                    sw.WriteLine();
                }
                using (StreamWriter sw = File.CreateText(genki1Grammar9))
                {
                    sw.WriteLine();
                }
                using (StreamWriter sw = File.CreateText(genki1Grammar10))
                {
                    sw.WriteLine();
                }
                using (StreamWriter sw = File.CreateText(genki1Grammar11))
                {
                    sw.WriteLine();
                }
                using (StreamWriter sw = File.CreateText(genki1Grammar12))
                {
                    sw.WriteLine();
                }
                using (StreamWriter sw = File.CreateText(genki1Grammar13))
                {
                    sw.WriteLine();
                }
                using (StreamWriter sw = File.CreateText(genki1Grammar14))
                {
                    sw.WriteLine();
                }
                using (StreamWriter sw = File.CreateText(genki1Grammar15))
                {
                    sw.WriteLine();
                }
                using (StreamWriter sw = File.CreateText(genki1Grammar16))
                {
                    sw.WriteLine();
                }
                using (StreamWriter sw = File.CreateText(genki1Grammar17))
                {
                    sw.WriteLine();
                }
                using (StreamWriter sw = File.CreateText(genki1Grammar18))
                {
                    sw.WriteLine();
                }
            }

            //---------------------------------------------------------------- GENKI 1 ---------------------------------------------
            StreamReader genki1Grammar = new StreamReader(genki1DictBlank);
            StreamReader genki1ErrorEN = new StreamReader(genki1DictErrorEN);
            StreamReader genki1ErrorES = new StreamReader(genki1DictErrorES);
            StreamReader genki1ErrorJP = new StreamReader(genki1DictErrorJP);
            StreamReader genki1ErrorSW = new StreamReader(genki1DictErrorSW);
            StreamReader G1G1 = new StreamReader(genki1Grammar1);
            StreamReader G1G2 = new StreamReader(genki1Grammar2);
            StreamReader G1G3 = new StreamReader(genki1Grammar3);
            StreamReader G1G4 = new StreamReader(genki1Grammar4);
            StreamReader G1G5 = new StreamReader(genki1Grammar5);
            StreamReader G1G6 = new StreamReader(genki1Grammar6);
            StreamReader G1G7 = new StreamReader(genki1Grammar7);
            StreamReader G1G8 = new StreamReader(genki1Grammar8);
            StreamReader G1G9 = new StreamReader(genki1Grammar9);
            StreamReader G1G10 = new StreamReader(genki1Grammar10);
            StreamReader G1G11 = new StreamReader(genki1Grammar11);
            StreamReader G1G12 = new StreamReader(genki1Grammar12);
            StreamReader G1G13 = new StreamReader(genki1Grammar13);
            StreamReader G1G14 = new StreamReader(genki1Grammar14);
            StreamReader G1G15 = new StreamReader(genki1Grammar15);
            StreamReader G1G16 = new StreamReader(genki1Grammar16);
            StreamReader G1G17 = new StreamReader(genki1Grammar17);
            StreamReader G1G18 = new StreamReader(genki1Grammar18);

            //-----------------------------------------------------------------------------------------------------------------------
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
                            if (dictErrorMessage == true)
                            {
                                if (MT.languageVariable == 0)
                                {
                                    try
                                    {
                                        line = genki1ErrorEN.ReadLine();

                                        while (line != null)
                                        {
                                            Console.WriteLine(line);
                                            line = genki1ErrorEN.ReadLine();
                                        }

                                        genki1ErrorEN.Close();
                                        Console.ReadKey();
                                    }
                                    finally
                                    {

                                    }
                                }
                                else if (MT.languageVariable == 1)
                                {
                                    try
                                    {
                                        line = genki1ErrorES.ReadLine();

                                        while (line != null)
                                        {
                                            Console.WriteLine(line);
                                            line = genki1ErrorES.ReadLine();
                                        }

                                        genki1ErrorES.Close();
                                        Console.ReadKey();
                                    }
                                    finally
                                    {

                                    }
                                }
                                else if (MT.languageVariable == 2)
                                {
                                    try
                                    {
                                        line = genki1ErrorJP.ReadLine();

                                        while (line != null)
                                        {
                                            Console.WriteLine(line);
                                            line = genki1ErrorJP.ReadLine();
                                        }

                                        genki1ErrorJP.Close();
                                        Console.ReadKey();
                                    }
                                    finally
                                    {

                                    }
                                }
                            }
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
                                if (!dictErrorMessage)
                                {
                                    try
                                    {
                                        line = G1G1.ReadLine();

                                        while (line != null)
                                        {
                                            Console.WriteLine(line);
                                            line = G1G1.ReadLine();
                                        }

                                        G1G1.Close();
                                        Console.ReadLine();
                                    }
                                    finally
                                    {

                                    }
                                }
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