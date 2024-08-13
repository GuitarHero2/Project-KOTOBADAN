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
            string pathForGenki2Folder = Path.Combine(pathForMainFolder, "Genki 2");
            bool dictErrorMessage = false;

            // Crear la carpeta principal y la subcarpeta "Genki 1" si no existen
            if (!Directory.Exists(pathForGenki1Folder))
            {
                Directory.CreateDirectory(pathForGenki1Folder);
            }

            if (!Directory.Exists(pathForGenki2Folder))
            {
                Directory.CreateDirectory(pathForGenki2Folder);
            }

            // Crear el archivo "Genki1Dict.txt" dentro de "Genki 1" si no existe
            string genki1DictErrorEN = Path.Combine(pathForGenki1Folder, "Genki1ErrorEN.txt");
            string genki1DictErrorES = Path.Combine(pathForGenki1Folder, "Genki1ErrorES.txt");
            string genki1DictErrorJP = Path.Combine(pathForGenki1Folder, "Genki1ErrorJP.txt");
            string genki1DictErrorSW = Path.Combine(pathForGenki1Folder, "Genki1ErrorSW.txt");
            string genki1GrammarEN = Path.Combine(pathForGenki1Folder, "Genki1GrammarEN.txt");
            string genki1GrammarES = Path.Combine(pathForGenki1Folder, "Genki1GrammarES.txt");
            string genki1GrammarJP = Path.Combine(pathForGenki1Folder, "Genki1GrammarJP.txt");
            string genki1GrammarSW = Path.Combine(pathForGenki1Folder, "Genki1GrammarSW.txt");

            int startLineG1G1 = 0, endLineG1G1 = 3; // Random Values that have to be modified later.
            int startLineG1G2 = 4, endLineG1G2 = 7;
            int startLineG1G3 = 8, endLineG1G3 = 11;
            int startLineG1G4 = 12, endLineG1G4 = 15;
            int startLineG1G5 = 16, endLineG1G5 = 17;
            int startLineG1G6 = 18, endLineG1G6 = 19;
            int startLineG1G7 = 20, endLineG1G7 = 21;
            int startLineG1G8 = 22, endLineG1G8 = 23;
            int startLineG1G9 = 24, endLineG1G9 = 25;
            int startLineG1G10 = 26, endLineG1G10 = 27;
            int startLineG1G11 = 28, endLineG1G11 = 29;
            int startLineG1G12 = 30, endLineG1G12 = 31;
            int startLineG1G13 = 32, endLineG1G13 = 33;
            int startLineG1G14 = 34, endLineG1G14 = 35;
            int startLineG1G15 = 36, endLineG1G15 = 37;
            int startLineG1G16 = 38, endLineG1G16 = 39;
            int startLineG1G17 = 40, endLineG1G17 = 41;
            int startLineG1G18 = 42, endLineG1G18 = 43;
            

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
                    dictErrorMessage = true;
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

                using (StreamWriter sw = File.CreateText(genki1GrammarEN))
                {
                    sw.WriteLine();
                }
                using (StreamWriter sw = File.CreateText(genki1GrammarES))
                {
                    sw.WriteLine();
                }
                using (StreamWriter sw = File.CreateText(genki1GrammarJP))
                {
                    sw.WriteLine();
                }
                using (StreamWriter sw = File.CreateText(genki1GrammarSW))
                {
                    sw.WriteLine();
                }

            }

            //-------------------------------- GENKI 1 ERROR LIST -------------------------------------------
            StreamReader genki1ErrorEN = new StreamReader(genki1DictErrorEN);
            StreamReader genki1ErrorES = new StreamReader(genki1DictErrorES);
            StreamReader genki1ErrorJP = new StreamReader(genki1DictErrorJP);
            StreamReader genki1ErrorSW = new StreamReader(genki1DictErrorSW);
            //-----------------------------------------------------------------------------------------------
            while (programIsOn)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(MT.welcomeMessage[MT.languageVariable]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(MT.mainMenuSelection[MT.languageVariable]);
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

                            // English Version

                            if(dictModeSelector.ToLower() == "1" && MT.languageVariable == 0)
                            {
                                if (!dictErrorMessage)
                                {
                                    Console.Clear();
                                    try
                                    {
                                        using (StreamReader G1G1 = new StreamReader(genki1GrammarEN))
                                        {
                                            int currentLine = 0;

                                            while ((line = G1G1.ReadLine()) != null)
                                            {
                                                currentLine++;

                                                if (currentLine > startLineG1G1 && currentLine <= endLineG1G1)
                                                {
                                                    Console.WriteLine(line);
                                                }
                                                else if (currentLine > endLineG1G1)
                                                {
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                    finally
                                    {

                                    }
                                }
                            }
                            else if (dictModeSelector.ToLower() == "2" && MT.languageVariable == 0)
                            {
                                if (!dictErrorMessage)
                                {
                                    Console.Clear();
                                    try
                                    {
                                        using (StreamReader G1G1 = new StreamReader(genki1GrammarEN))
                                        {
                                            int currentLine = 0;

                                            while ((line = G1G1.ReadLine()) != null)
                                            {
                                                currentLine++;
                                                if (currentLine > startLineG1G2 && currentLine <= endLineG1G2 && currentLine >= startLineG1G2)
                                                {
                                                    Console.WriteLine(line);
                                                }
                                                else if (currentLine > endLineG1G2)
                                                {
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                    finally
                                    {

                                    }
                                }
                            }
                            else if (dictModeSelector.ToLower() == "3" && MT.languageVariable == 0)
                            {
                                if (!dictErrorMessage)
                                {
                                    Console.Clear();
                                    try
                                    {
                                        using (StreamReader G1G1 = new StreamReader(genki1GrammarEN))
                                        {
                                            int currentLine = 0;

                                            while ((line = G1G1.ReadLine()) != null)
                                            {
                                                currentLine++;
                                                if (currentLine > startLineG1G3 && currentLine <= endLineG1G3 && currentLine >= startLineG1G3)
                                                {
                                                    Console.WriteLine(line);
                                                }
                                                else if (currentLine > endLineG1G3)
                                                {
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                    finally
                                    {

                                    }
                                }
                            }
                            else if (dictModeSelector.ToLower() == "4" && MT.languageVariable == 0)
                            {
                                if (!dictErrorMessage)
                                {
                                    Console.Clear();
                                    try
                                    {
                                        using (StreamReader G1G1 = new StreamReader(genki1GrammarEN))
                                        {
                                            int currentLine = 0;

                                            while ((line = G1G1.ReadLine()) != null)
                                            {
                                                currentLine++;
                                                if (currentLine > startLineG1G4 && currentLine <= endLineG1G4 && currentLine >= startLineG1G4)
                                                {
                                                    Console.WriteLine(line);
                                                }
                                                else if (currentLine > endLineG1G4)
                                                {
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                    finally
                                    {

                                    }
                                }
                            }
                            else if (dictModeSelector.ToLower() == "5" && MT.languageVariable == 0)
                            {
                                if (!dictErrorMessage)
                                {
                                    Console.Clear();
                                    try
                                    {
                                        using (StreamReader G1G1 = new StreamReader(genki1GrammarEN))
                                        {
                                            int currentLine = 0;

                                            while ((line = G1G1.ReadLine()) != null)
                                            {
                                                currentLine++;
                                                if (currentLine > startLineG1G5 && currentLine <= endLineG1G5 && currentLine >= startLineG1G5)
                                                {
                                                    Console.WriteLine(line);
                                                }
                                                else if (currentLine > endLineG1G5)
                                                {
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                    finally
                                    {

                                    }
                                }
                            }
                            else if (dictModeSelector.ToLower() == "6" && MT.languageVariable == 0)
                            {
                                if (!dictErrorMessage)
                                {
                                    Console.Clear();
                                    try
                                    {
                                        using (StreamReader G1G1 = new StreamReader(genki1GrammarEN))
                                        {
                                            int currentLine = 0;

                                            while ((line = G1G1.ReadLine()) != null)
                                            {
                                                currentLine++;
                                                if (currentLine > startLineG1G6 && currentLine <= endLineG1G6 && currentLine >= startLineG1G6)
                                                {
                                                    Console.WriteLine(line);
                                                }
                                                else if (currentLine > endLineG1G6)
                                                {
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                    finally
                                    {

                                    }
                                }
                            }
                            else if (dictModeSelector.ToLower() == "7" && MT.languageVariable == 0)
                            {
                                if (!dictErrorMessage)
                                {
                                    Console.Clear();
                                    try
                                    {
                                        using (StreamReader G1G1 = new StreamReader(genki1GrammarEN))
                                        {
                                            int currentLine = 0;

                                            while ((line = G1G1.ReadLine()) != null)
                                            {
                                                currentLine++;
                                                if (currentLine > startLineG1G7 && currentLine <= endLineG1G7 && currentLine >= startLineG1G7)
                                                {
                                                    Console.WriteLine(line);
                                                }
                                                else if (currentLine > endLineG1G7)
                                                {
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                    finally
                                    {

                                    }
                                }
                            }
                            else if (dictModeSelector.ToLower() == "8" && MT.languageVariable == 0)
                            {
                                if (!dictErrorMessage)
                                {
                                    Console.Clear();
                                    try
                                    {
                                        using (StreamReader G1G1 = new StreamReader(genki1GrammarEN))
                                        {
                                            int currentLine = 0;

                                            while ((line = G1G1.ReadLine()) != null)
                                            {
                                                currentLine++;
                                                if (currentLine > startLineG1G8 && currentLine <= endLineG1G8 && currentLine >= startLineG1G8)
                                                {
                                                    Console.WriteLine(line);
                                                }
                                                else if (currentLine > endLineG1G8)
                                                {
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                    finally
                                    {

                                    }
                                }
                            }
                            else if (dictModeSelector.ToLower() == "9" && MT.languageVariable == 0)
                            {
                                if (!dictErrorMessage)
                                {
                                    Console.Clear();
                                    try
                                    {
                                        using (StreamReader G1G1 = new StreamReader(genki1GrammarEN))
                                        {
                                            int currentLine = 0;

                                            while ((line = G1G1.ReadLine()) != null)
                                            {
                                                currentLine++;
                                                if (currentLine > startLineG1G9 && currentLine <= endLineG1G9 && currentLine >= startLineG1G9)
                                                {
                                                    Console.WriteLine(line);
                                                }
                                                else if (currentLine > endLineG1G9)
                                                {
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                    finally
                                    {

                                    }
                                }
                            }
                            else if (dictModeSelector.ToLower() == "10" && MT.languageVariable == 0)
                            {
                                if (!dictErrorMessage)
                                {
                                    Console.Clear();
                                    try
                                    {
                                        using (StreamReader G1G1 = new StreamReader(genki1GrammarEN))
                                        {
                                            int currentLine = 0;

                                            while ((line = G1G1.ReadLine()) != null)
                                            {
                                                currentLine++;
                                                if (currentLine > startLineG1G10 && currentLine <= endLineG1G10 && currentLine >= startLineG1G10)
                                                {
                                                    Console.WriteLine(line);
                                                }
                                                else if (currentLine > endLineG1G10)
                                                {
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                    finally
                                    {

                                    }
                                }
                            }
                            else if (dictModeSelector.ToLower() == "11" && MT.languageVariable == 0)
                            {
                                if (!dictErrorMessage)
                                {
                                    Console.Clear();
                                    try
                                    {
                                        using (StreamReader G1G1 = new StreamReader(genki1GrammarEN))
                                        {
                                            int currentLine = 0;

                                            while ((line = G1G1.ReadLine()) != null)
                                            {
                                                currentLine++;
                                                if (currentLine > startLineG1G11 && currentLine <= endLineG1G11 && currentLine >= startLineG1G11)
                                                {
                                                    Console.WriteLine(line);
                                                }
                                                else if (currentLine > endLineG1G11)
                                                {
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                    finally
                                    {

                                    }
                                }
                            }
                            else if (dictModeSelector.ToLower() == "12" && MT.languageVariable == 0)
                            {
                                if (!dictErrorMessage)
                                {
                                    Console.Clear();
                                    try
                                    {
                                        using (StreamReader G1G1 = new StreamReader(genki1GrammarEN))
                                        {
                                            int currentLine = 0;

                                            while ((line = G1G1.ReadLine()) != null)
                                            {
                                                currentLine++;
                                                if (currentLine > startLineG1G12 && currentLine <= endLineG1G12 && currentLine >= startLineG1G12)
                                                {
                                                    Console.WriteLine(line);
                                                }
                                                else if (currentLine > endLineG1G12)
                                                {
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                    finally
                                    {

                                    }
                                }
                            }
                            else if (dictModeSelector.ToLower() == "13" && MT.languageVariable == 0)
                            {
                                if (!dictErrorMessage)
                                {
                                    Console.Clear();
                                    try
                                    {
                                        using (StreamReader G1G1 = new StreamReader(genki1GrammarEN))
                                        {
                                            int currentLine = 0;

                                            while ((line = G1G1.ReadLine()) != null)
                                            {
                                                currentLine++;
                                                if (currentLine > startLineG1G13 && currentLine <= endLineG1G13 && currentLine >= startLineG1G13)
                                                {
                                                    Console.WriteLine(line);
                                                }
                                                else if (currentLine > endLineG1G13)
                                                {
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                    finally
                                    {

                                    }
                                }
                            }
                            else if (dictModeSelector.ToLower() == "14" && MT.languageVariable == 0)
                            {
                                if (!dictErrorMessage)
                                {
                                    Console.Clear();
                                    try
                                    {
                                        using (StreamReader G1G1 = new StreamReader(genki1GrammarEN))
                                        {
                                            int currentLine = 0;

                                            while ((line = G1G1.ReadLine()) != null)
                                            {
                                                currentLine++;
                                                if (currentLine > startLineG1G14 && currentLine <= endLineG1G14 && currentLine >= startLineG1G14)
                                                {
                                                    Console.WriteLine(line);
                                                }
                                                else if (currentLine > endLineG1G14)
                                                {
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                    finally
                                    {

                                    }
                                }
                            }
                            else if (dictModeSelector.ToLower() == "15" && MT.languageVariable == 0)
                            {
                                if (!dictErrorMessage)
                                {
                                    Console.Clear();
                                    try
                                    {
                                        using (StreamReader G1G1 = new StreamReader(genki1GrammarEN))
                                        {
                                            int currentLine = 0;

                                            while ((line = G1G1.ReadLine()) != null)
                                            {
                                                currentLine++;
                                                if (currentLine > startLineG1G15 && currentLine <= endLineG1G15 && currentLine >= startLineG1G15)
                                                {
                                                    Console.WriteLine(line);
                                                }
                                                else if (currentLine > endLineG1G15)
                                                {
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                    finally
                                    {

                                    }
                                }
                            }
                            else if (dictModeSelector.ToLower() == "16" && MT.languageVariable == 0)
                            {
                                if (!dictErrorMessage)
                                {
                                    Console.Clear();
                                    try
                                    {
                                        using (StreamReader G1G1 = new StreamReader(genki1GrammarEN))
                                        {
                                            int currentLine = 0;

                                            while ((line = G1G1.ReadLine()) != null)
                                            {
                                                currentLine++;
                                                if (currentLine > startLineG1G16 && currentLine <= endLineG1G16 && currentLine >= startLineG1G16)
                                                {
                                                    Console.WriteLine(line);
                                                }
                                                else if (currentLine > endLineG1G16)
                                                {
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                    finally
                                    {

                                    }
                                }
                            }
                            else if (dictModeSelector.ToLower() == "17" && MT.languageVariable == 0)
                            {
                                if (!dictErrorMessage)
                                {
                                    Console.Clear();
                                    try
                                    {
                                        using (StreamReader G1G1 = new StreamReader(genki1GrammarEN))
                                        {
                                            int currentLine = 0;

                                            while ((line = G1G1.ReadLine()) != null)
                                            {
                                                currentLine++;
                                                if (currentLine > startLineG1G17 && currentLine <= endLineG1G17 && currentLine >= startLineG1G17)
                                                {
                                                    Console.WriteLine(line);
                                                }
                                                else if (currentLine > endLineG1G17)
                                                {
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                    finally
                                    {

                                    }
                                }
                            }
                            else if (dictModeSelector.ToLower() == "18" && MT.languageVariable == 0)
                            {
                                if (!dictErrorMessage)
                                {
                                    Console.Clear();
                                    try
                                    {
                                        using (StreamReader G1G1 = new StreamReader(genki1GrammarEN))
                                        {
                                            int currentLine = 0;

                                            while ((line = G1G1.ReadLine()) != null)
                                            {
                                                currentLine++;
                                                if (currentLine > startLineG1G18 && currentLine <= endLineG1G18 && currentLine >= startLineG1G18)
                                                {
                                                    Console.WriteLine(line);
                                                }
                                                else if (currentLine > endLineG1G18)
                                                {
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                    finally
                                    {

                                    }
                                }
                            }

                            // Spanish Version


                            // Japanese Version


                            // Swedish Version


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
                    Console.WriteLine("YouTube Link");
                    Console.ReadKey();
                }
                else if (keyPressed.Key == ConsoleKey.D5)
                {
                    Console.Clear();
                    Console.WriteLine(MT.versionInfo[MT.languageVariable] + "Alpha 0.0.0.2");
                    Console.WriteLine(MT.currentAmountofPointsInfo[MT.languageVariable] + quizGame.currentAmountOfPoints);
                    Console.WriteLine("\n \n \n" + "This program has been coded by Nozomi Kobayashi");
                    Console.ReadKey();
                }
                else if (keyPressed.Key == ConsoleKey.D6)
                {
                    programIsOn = false;
                }
            }
        }
    }
}