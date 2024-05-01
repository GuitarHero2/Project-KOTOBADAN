using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotoba_Project
{
    internal class MenuTranslations
    {
        public int languageVariable;

        public string[] versionInfo =
        {
            "Version: ",
            "Versión: ",
            "版： ",
            "Version: "
        };

        public string[] languagueMenuTitle =
        {
                "-- Languagues --",
                "-- Idiomas --",
                "-- 言語 --",
                "-- Språk --"
        };

        public string[] languagueMenuOptions =
        {
            "\n 1. English \n 2. Spansih \n 3. Japanese \n 4. Swedish",
            "\n 1. Inglés \n 2. Español \n 3. Japonés \n 4. Sueco",
            "\n 1. 英語 \n 2. スペイン語 \n 3. 日本語 \n 4. スウェーデン語",
            "\n 1. Engelska \n 2. Spanska \n 3. Japanska \n 4. Svenska"
        };

        public string[] welcomeMessage =
        {
            "-- Welcome to KOTOBADAN --",
            "-- Bienvenidos a KOTOBADAN --",
            "-- 言葉暖へよこそう --",
            "-- Välkommen till KOTOBADAN"

        };

        public string[] mainMenuSelection =
        {
            "\n 1. Start \n 2. Dictionary \n 3. Settings \n 4. Credits and Info \n 5. Exit",
            "\n 1. Empezar \n 2. Diccionario \n 3. Configuración \n 4. Creditos e Información \n 5. Salir",
            "\n 1. スタート \n 2. 辞書 \n 3. 設定 \n 4. 与信とインフォ \n 5. 出口する",
            "\n 1. Börja \n 2. Lexikon \n 3. Inställningar \n 4. Eftertext och Info \n 5. Stäng"
        };

        public string[] levelSelectorMessage =
        {
            "\n 1. N1 (Coming soon)  \n 2. N2 (Coming soon) \n 3. N3 (Coming soon) \n 4. N4 (Coming soon) \n 5. N5 (ALPHA Version)",
            "\n 1. N1 (Proximamente)  \n 2. N2 (Proximamente) \n 3. N3 (Proximamente) \n 4. N4 (Proximamente) \n 5. N5 (Versión ALPHA)",
            "\n 1. N1 (近刊)  \n 2. N2 (近刊) \n 3. N3 (近刊) \n 4. N4 (近刊) \n 5. N5 (アルファバージョン)",
            "\n 1. N1 (Kommer snart)  \n 2. N2 (Kommer snart) \n 3. N3 (Kommer snart) \n 4. N4 (Kommer snart) \n 5. N5 (ALPHA Version)",

        };

        public string[] currentAmountofPointsInfo =
        {
            "Your current amount of point is: ",
            "Tu puntuación actual es: ",
            "あなたの現在の点数は：　",
            "Din nuvarande poäng är: ",
        };

        public string[] settingsTitle =
        {
            "-- Settings --",
            "-- Configuración --",
            "-- 設定 --",
            "-- Inställningar --"
        };

        public string[] settingsMenuSelection =
        {
            "\n 1. Language",
            "\n 1. Idioma",
            "\n 1. 言語",
            "\n 1. Språk"
        };

        public string[] choosingGameModeTitle =
        {
            "-- Select Your Gamemode --",
            "-- Elige Tu Modo de Juego --",
            "-- ゲームモードを選んでください --",
            "-- Välj spelläget --"
        };

        public string[] dictionaryMenu =
        {
            "-- Type a word! --",
            "-- Escribe una palabra! --",
            "-- 言葉を書いてください! --",
            "-- Skriv ett ord! --"
        };

        public string[] dictionaryError = // <------ LEGACY?
        {
            "-- WHERE DID IT GO!? -- \n There is no definition available for: ",
            "-- A DÓNDE SE FUE!? -- \n No hay definiciones disponibles para: ",
            "-- 何処に行ったの！？ -- \n 次の言葉は定義がありません: ",
            "-- Vart gick det!? -- \n Det finns ingen definition för: "
        };

        public string[] dictionaryErrorExtendedSearch =
        {
            "-- We went to the end of the world together, but still couldn't find the answer~... --\n There is no definitions available for: ",
            "-- Fuimos hasta el fin del mundo juntos, pero no pudimos encontrar la respuesta~... -- \n No hay definiciones para: ",
            "--あの世まで行ったけど、答えが見つかりませんでした～…　\n 次の言葉は定義がありません: ",
            "-- Även när vi gick till andra livet, kunde vi inte hitta svaret~... \n Det finns ingen definition för: "
        };

        public string[] dictionaryExtendedSearchMessage =
        {
            "Do you want to do an extended search? (Y)",
            "Quieres hacer una busqueda extendida? (Y)",
            "奥に尋ねたいか？ (Y)",
            "Vill du göra en djup sökt? (Y)"
        };


        public string[] wordDefinitionMessage =
        {
            "Searched word: ",
            "Palabra buscada: ",
            "検察した言葉： ",
            "Sökt ord: "
        };

        public string[] currentNumberOfWords =
        {
            "Current Number of Words: ",
            "Numero actual de palabras: ",
            "現在の単語数: ",
            "Aktuell antal ord: "
        };

        public string[] currentNumberOfDefinitions =
        {
            "Current Number of Definitions: ",
            "Numero actual de definiciones: ",
            "現在の定義数: ",
            "Aktuell antal definitioner: "
        };

        public string[] chooseDictionaryMenu =
        {
            "-- How do you want to use the dictionary this time? --",
            "-- Cómo quieres usar el diccionario esta vez? --",
            "-- 今回がどのように辞書を使用したいですか？ --",
            "Hur vill du använda lexikon den här gången? --"
        };

        public string[] dictionaryModes1 =
        {
            "1. Japanese to English",
            "1. Japonés a Inglés",
            "1. 日本語から英語へ",
            "1. Japanska till Engelska"
        };

        public string[] dictionaryModes2 =
        {
            "2. English to Japanese (Beta)",
            "2. Inglés a Japonés (Beta)",
            "2. 英語から日本語へ 「ベータ版」",
            "2. Engelska till Japanska (Beta)"
        };

        public string[] dictionaryModes3 =
        {
            "3. Japanese to Spanish (Coming soon!)",
            "3. Japonés a Español (Pronto!)",
            "3. 日本語からスペイン語へ (近刊！)",
            "3. Japanska till Spanska (Kommer snart!)"
        };

        public string[] dictionaryModes4 =
        {
            "4. Grammar dictionary (Coming soon!)",
            "4. Diccionario de gramatica (Pronto!)",
            "4. 文法の辞書 (近刊！)",
            "4. Grammatik ordbok"
        };

        public string[] dictionaryModes5 =
        {
            "5. Kanji dictionary (Coming soon!)",
            "5. Diccionario de kanji (¡Pronto!)",
            "5. 漢字の辞書 (近刊！)",
            "5. Kanji ordbok (Kommer snart!)"
        };

        public string[] minigameWordDescription =
        {
            "- Word Description: ",
            "- Descripción de la palabra: ",
            "- 単語の説明: ",
            "- Information av ordet: "
        };

        public string[] dictionaryInformation1 =
        {
             "\n JLPT Level: ",
             "\n Nivel de JLPT: ",
             "\n 日本語能力試験のレベル： ",
             "\n JLPT nivå: "
        };

        public string[] dictionaryInformation2 =
        {
            "\n \n Pronunciation: ",
            "\n \n Pronunciación: ",
            "\n \n 読み方：　",
            "\n \n Uttal: "
        };

        public string[] dictionaryInformation3 =
        {
            "\n \n Furigana: ",
            "\n \n Furigana: ",
            "\n \n ふりがな： ",
            "\n \n Furigana: "
        };

        public string[] dictionaryInformation4 =
        {
            "\n \n Alternative forms: ",
            "\n \n Formas alternativas: ",
            "\n \n 異表記： ",
            "\n \n Alternativa former: "
        };

        public string[] dictionaryInformation5 =
        {
            "\n \n Meaning: ",
            "\n \n Significado: ",
            "\n \n 意味：　",
            "\n \n Betydelse: "
        };

        // Minigame text

        public string[] minigameGuessWordMessage1 =
        {
            "How do you read 「",
            "¿Comó se lee 「",
            "「",
            "Hur läser man 「",
        };

        public string[] minigameGuessWordMessage2 =
        {
            "」 in Japanese?",
            "」 en japonés?",
            "」の読み方は何ですか？",
            "」 på Japanska?"
        };

        public string[] minigameAnswerText =
        {
            "Answer: ",
            "Respuesta: ",
            "解答：　",
            "Svar: "
        };

        public string[] minigameCorrectMessague =
        {
            "Correct!",
            "¡Correcto!",
            "正解!",
            "Korrekt!"
        };

        public string[] minigameIncorrectAnswerMessague1 =
        {
            "Incorrect answer, the correct answer is: 「",
            "Respuesta incorrecta, la respuesta correcta es: 「",
            "不正解、正解は：　「",
            "Fel svar, Rätt svaret är: 「"
        };

        public string[] minigameIncorrectAnswerMessague2 =
        {
            "」",
            "」",
            "」です。",
            "」"
        };

        public string[] minigameContinueMessague =
        {
            "\n \n Would you like to continue? (Y/N): ",
            "\n \n ¿Quieres continuar? (Y/N): ",
            "\n \n 続けたい？ (Y/N): ",
            "\n \n Vill du fortsätta?"
        };

        public string[] minigameEndsWithNoWordsLeft =
        {
            "There are no word left, you complete this deck!",
            "No quedan palabras disponibles. ¡Has completado este mazo!",
            "言葉は残されていない、このデッキを揃えた！",
            "Det finns inget ord kvart, du slutade den här decken!"
        };
    }
}
