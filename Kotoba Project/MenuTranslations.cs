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
            "\n 1. English \n 2. Spanish \n 3. Japanese \n 4. Swedish",
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
            "\n 1. Start \n 2. Dictionary \n 3. Settings \n 4. External Resources \n 5. Credits and Info \n 6. Exit",
            "\n 1. Empezar \n 2. Diccionario \n 3. Configuración \n 4. Recursos Externos \n 5. Creditos e Información \n 6. Salir",
            "\n 1. スタート \n 2. 辞書 \n 3. 設定 \n 4. 外部リソース \n 5. 与信とインフォ \n 6. 出口する",
            "\n 1. Börja \n 2. Lexikon \n 3. Inställningar \n 4. Externa medel \n 5. Eftertext och Info \n 6. Stäng"
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

        public string[] dictionaryExtendedSearchMessage = // <------ LEGACY?
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
            "-- Hur vill du använda lexikon den här gången? --"
        };

        public string[] dictionaryModes1 =
        {
            "1. Japanese to English (Temporally unavailable)",
            "1. Japonés a Inglés (Temporalmente no disponible)",
            "1. 日本語から英語へ (Temporally unavailable)",
            "1. Japanska till Engelska (Temporärt inte tillgängligt)"
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
            "4. Grammar dictionary (Beta)",
            "4. Diccionario de gramatica (Beta)",
            "4. 文法の辞書 (ベータ版)",
            "4. Grammatik ordbok (Beta)"
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

        public string[] grammarDictTitleMessage =
        {
            "-- Select the grammar dictionary mode you want to use --",
            "-- Elige el modo de diccionario de gramática que quieres usar --",
            "-- 文法の辞書のモードを選んでください --",
            "-- Välja grammatikslexinlägen du vill använda --"
        };

        public string[] grammarDictMode1 =
        {
            "1. Genki I Grammar (BETA)",
            "1. Gramática de Genki I (BETA)",
            "1. げんきIの文法 (ベータ版)",
            "1. Grammatik från Genki I (BETA)"
        };

        public string[] grammarDictMode2 =
        {
            "2. Genki II Grammar (NOT AVAILABLE)",
            "2. Gramática de Genki II (NO DISPONIBLE)",
            "2. げんきIIの文法 (無効)",
            "2. Grammatik från Genki II (Inte tillgänglig)"
        };

        

        // ------------------ Genki 1 Grammar Translations -----------------------
        public string[] genki1ModeTitleMessage =
        {
            "-- Select what grammar you want to see --",
            "-- Elige que gramática quieres ver --",
            "-- どの文法を見たい --",
            "-- Vilken grammatik vill du se --"
        };

        public string[] genki1Chapter1 =
        {
            "* Lesson 1",
            "* Lección 1",
            "* 第1課",
            "* Lektion 1"
        };

        public string[] genki1Chapter1point1 =
        {
            "1. 1-1 (XはYです)",
            "1. 1-1 (XはYです)",
            "1. 1-1 (XはYです)",
            "1. 1-1 (XはYです)"
        };
        public string[] genki1Chapter1point2 =
        {
            "2. 1-2 (Question Sentences)",
            "2. 1-2 (Oraciónes Interrogativas)",
            "2. 1-2 (疑問文)",
            "2. 1-2 (Frågesats)"
        };
        public string[] genki1Chapter1point3 =
        {
            "3. 1-3 (Noun1のNoun2)",
            "3. 1-3 (Sustantivo1のSustantivo2)",
            "3. 1-3 (所有接辞)",
            "3. 1-3 (Possessiv)"
        };

        public string[] genki1Chapter2 =
        {
            "* Lesson 2",
            "* Lección 2",
            "* 第2課",
            "* Lektion 2"
        };

        public string[] genki1Chapter2point1 =
        {
            "4. 2-1 (これ / それ / あれ / どれ)",
            "4. 2-1 (これ / それ / あれ / どれ)",
            "4. 2-1 (これ / それ / あれ / どれ)",
            "4. 2-1 (これ / それ / あれ / どれ)"
        };
        public string[] genki1Chapter2point2 =
        {
            "5. 2-2 (この / その / あの /　どの + Noun)",
            "5. 2-2 (この / その / あの /　どの + Sustantivo)",
            "5. 2-2 (この / その / あの /　どの + 名詞)",
            "5. 2-2 (この / その / あの /　どの + Substantiv)"
        };
        public string[] genki1Chapter2point3 =
        {
            "6. 2-3 (ここ / そこ / あそこ / どこ)",
            "6. 2-3 (ここ / そこ / あそこ / どこ)",
            "6. 2-3 (ここ / そこ / あそこ / どこ)",
            "6. 2-3 (ここ / そこ / あそこ / どこ)"
        };
        public string[] genki1Chapter2point4 =
        {
            "7. 2-4 (だれの + Noun)",
            "7. 2-4 (だれの + Sustantivo)",
            "7. 2-4 (だれの + 名詞)",
            "7. 2-4 (だれの + Substantiv)"
        };
        public string[] genki1Chapter2point5 =
        {
            "8. 2-5 (Nounも)",
            "8. 2-5 (Sustantivo + も)",
            "8. 2-5 (名詞 + も)",
            "8. 2-5 (Substantiv + も)"
        };
        public string[] genki1Chapter2point6 =
        {
            "9. 2-6 (Nounじゃない)",
            "9. 2-6 (Sustantivoじゃない)",
            "9. 2-6 (名詞 + じゃない)",
            "9. 2-6 (Substantivじゃない)"
        };
        public string[] genki1Chapter2point7 =
        {
            "10. 2-7 (～ね / ～よ)",
            "10. 2-7 (～ね / ～よ)",
            "10. 2-7 (～ね / ～よ)",
            "10. 2-7 (～ね / ～よ)"
        };

        public string[] genki1Chapter3 =
        {
            "* Lesson 3",
            "* Lección 3",
            "* 第3課",
            "* Lektion 3"
        };

        public string[] genki1Chapter3point1 =
        {
            "11. 3-1 (Verb Conjugation)",
            "11. 3-1 (Conjugaciones de los Verbos)",
            "11. 3-1 (四段活用)",
            "11. 3-1 (Konjugationer av verb)"
        };
        public string[] genki1Chapter3point2 =
        {
            "12. 3-2 (Verb Types and the 'Present Form')",
            "12. 3-2 (Formas del verbo y la 'Forma Presente')",
            "12. 3-2 (動詞の種類と「現在形」)",
            "12. 3-2 (Verb sorter och 'nutiden')"
        };
        public string[] genki1Chapter3point3 =
        {
            "13. 3-3 (Particles)",
            "13. 3-3 (Particulas)",
            "13. 3-3 (てにをは)",
            "13. 3-3 (Partiklar)"
        };
        public string[] genki1Chapter3point4 =
        {
            "14. 3-4 (Time References)",
            "14. 3-4 (Referencias al Tiempo)",
            "14. 3-4 (時間の参考)",
            "14. 3-4 (Tid referens)"
        };
        public string[] genki1Chapter3point5 =
        {
            "15. 3-5 (～ませんか)",
            "15. 3-5 (～ませんか)",
            "15. 3-5 (～ませんか)",
            "15. 3-5 (～ませんか)"
        };
        public string[] genki1Chapter3point6 =
        {
            "16. 3-6 (Frequency Adverbs)",
            "16. 3-6 (Adverbios de frecuencia)",
            "16. 3-6 (度数の副詞)",
            "16. 3-6 (Adverb av frekvens)"
        };
        public string[] genki1Chapter3point7 =
        {
            "17. 3-7 (Word Order)",
            "17. 3-7 (Orden de las Palabras)",
            "17. 3-7 (語順)",
            "17. 3-7 (Ordordning)"
        };
        public string[] genki1Chapter3point8 =
        {
            "18. 3-8 (The Topic Marker は)",
            "18. 3-8 (El Marcador de Tema は)",
            "18. 3-8 (トピックマーカー「は」)",
            "18. 3-8 (Ämnemarkerare は)"
        };
    }
}
