using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotoba_Project
{
    // Dictionary for original form searches (words in its most common form in Japanese).

    class Dictionary : JLPTClass
    {
        MenuTranslations MT = new MenuTranslations();

        public int languagueSettingsUpdater;

        public Dictionary<string, List<string>> jisho;
        public Dictionary()
        {
            Initialize();
        }

        public void Initialize()
        {
            jisho = new Dictionary<string, List<string>>()
            {
            // N5

            {
                "こんにちは", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "Kon'nichiwa" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "こんにちは" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "今日は [こんにちは] (Obsolete), こんにちわ, こんちは, こんちわ" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Hello, Good day, Good Afternoon" +
                 "\n -- A way of greeting someone politely in the afternoon."}},

                {"コンピューター", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5]+
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "Kon'piuu taa" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "こんぴゅーたー" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [From English] Computer, Desktop, PC" +
                 "\n -- Multipurpose machine usually used for working, gaming and studying."}},

                {"勉強", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "Ben kyoo" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "べんきょう" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "べんきょう [Also writen in Hiragana]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To study, Diligence" +
                 "\n -- The act of acquiring knowledge by investigating and learning from a source like a book or any related material about a certain topic."}},

                {"軽い", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5]+
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "karui" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "かるい" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "軽い [かろい]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Light, Light feeling, Efforless, Agile, easy" +
                 "\n -- (い-Adjective) Something easy to move, lift or/and easy to do." +
                 "\n 2. Non-serious, Unimportant, Trivial" +
                 "\n -- (い-Adjective) Something you don't give the sufficient attention or you think it's not worthy to worry about."}},

                {"浴びる", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "a biru " +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "あびる" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To bathe, To shower" +
                 "\n \n 2. To be covered in, To be flooded with"}},

                {"危ない", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "abu nai " +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "あぶない" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Dangerous, Risky, Hazardous, Perilous, Precarious" +
                 "\n \n 2. Look out!, Watch out!, Be careful!, That's Dangerous!"}},

                {"あっち", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "Acchi " +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "あっち" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "彼方 [あっち] (Rarely used with Kanji), 彼方 [あち] (Obsolete), 彼方 [あちら] (Rarely used with Kanji)" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. That way (over there), There" +
                 "\n -- Usually written using kana alone"}},

                {"あげる", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "ageru " +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "あげる" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "揚げる [あげる], 挙げる [あげる], 上げる [あげる] (Commonly used)" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To give (Sender is marked with は/が and receiver is marked with に)" +
                 "\n -- To give someone else something." +
                 "\n 2. To do a favor, To give someone else a favor, To do (something) for (the sake of someone else)." +
                 "\n -- (～てあげる) to do something for someone else." +
                 "\n 3. To raise, To elevate, To increase" +
                 "\n -- The action of making something going up (in one or other way)." +
                 "\n 4. To throw up, To vomit"}},

                {"赤", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "aka " +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "あか" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "あか, 紅 [あか]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. (Color) [Noun] Red, Crimson, Scarlet"}},

                {"赤い", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "akai " +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "あかい" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "あかい, 紅い [あかい]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. (Color) [Adjective] Red, Crimson, Scarlet"}},

                {"明るい", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "Akarui " +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "あかるい" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Light, Bright" +
                 "\n -- High intensity of luminity." +
                 "\n 2. Happy, Cheerful, Bright, Sunny"}},

                {"あける", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "akeru " +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "あける" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "開ける [あける], 空ける [あける], 明ける [あける]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To open (e.g a door, etc), To unlock, To unwrap, To open (a business)" +
                 "\n \n 2. To empty, To remove, To make space, To leave (one's schedule) open, To make time (for something / someone)"}},

                {"秋", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "aki " +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "あき" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Autumn, Fall"}},

                {"開く", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "aku " +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "空く [あく], 明く [あく]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To open (e.g doors, business, etc)"}},

                {"甘い", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "amai " +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "あまい" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Sugary, Naive, Sweet, sweet-tasting, indulgent" +
                 "\n -- Something with a lot of sugar of a very sweet taste (can be either an object or words)"}},

                {"あめ", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "ame " +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "あめ" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [雨] Rain" +
                 "\n -- The third step of the the water cycle." +
                 "\n 2. [飴] Candy, Sweet, Caramel"}},

                {"あなた", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "anata " +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "あなた" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "貴方 [あなた], 貴女 [あなた], 貴男 [あなた]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. You, Dear, Honey" +
                 "\n -- Polite but also considered rude and direct"}},

                {"姉", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "ane " +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "あね" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "姉 [ねえ] (Casual), 姉 [し] (Honorific), 姐 [あね]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Older sister, Elder sister, [姉さん] Young lady, Miss, Ma'am" +
                 "\n -- A young woman" +
                 "\n 2. Honorific suffix used after the name of a woman of equal or higher status"}},

                {"兄", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "ani " +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "あに" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "兄 [けい]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Older brother, Elder brother, Young Boy" +
                 "\n -- A young man"}},

                {"あの", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "Ano " +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "あの" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "彼の [あの] (Rarely used kanji form), あん" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. That (thing, place, etc) over there" +
                 "\n -- Something far from both the speaker and the listener."}},

                {"青", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "ao " +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "あお" +
                 "\n \n Alternative forms:　蒼 [あお], 碧 [あお]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. (Color) [Noun] Blue, Azure, Immature, young, green (like a plant that haven't grown up yet)"}},

                {"青い", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "aoi " +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "あおい" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "蒼い [あおい], 碧い [あおい]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. (Color) [Adjective] Blue, Azure, Unexperienced (Only applies to 蒼い and 青い)"}},

                {"アパート", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "apaato " +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "あぱあと" +
                 "\n \n Alternative forms:" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [From English] Apartment building, Apartment block, Apartment house, Apartment, House" +
                 "\n -- A building where more than one house is combined into a big house and is divided by level or floors"}},

                {"洗う", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "Arau " +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "あらう" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To wash, To cleanse, To rinse, To purify (One's heart)" +
                 "\n -- Action of taking of the dirty parts of something."}},

                {"あれ", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "are" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "あれ" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "彼 [あれ], 彼れ [あれ] (Rarely kanji usage)" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. That (thing) over there" +
                 "\n -- Something far from both the speaker and the listener." +
                 "\n 2. Huh?, Eh?, What?" +
                 "\n -- Exclamation of confusion"}},

                {"ある", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "aru" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ある" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "有る [ある], 在る [ある]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To exist, To be, To live (For unanimated things)" +
                 "\n \n 2. To have" +
                 "\n -- To possess something" +
                 "\n 3. To be located"}},

                {"歩く", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "aruku" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "あるく" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To walk" +
                 "\n -- The action of moving your legs towards a direction"}},

                {"朝", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "asa" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "あさ" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. morning" +
                 "\n -- State of time where it is between 06:00 AM and 11:59 AM."}},

                {"朝ごはん", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "asa gohan" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "あさごはん" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "朝ご飯 [あさごはん]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Breakfast" +
                 "\n -- The first meal of the day"}},

                {"明後日", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "asatte" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "あさって" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "あさって [みょうごにち]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. The day after tomorrow" +
                 "\n -- Two days after the current day (E.g 05/10, 明後日 would be 07/10)" +
                 "\n 2. Wrong (E.g Direction) [Only applies to あせって]"}},

                {"足", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "ashi" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "あし" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "脚 [あし], 肢 [あし]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Foot, leg, paw, arm"}},

                {"明日", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "ashita" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "あした" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "明日 [あす], 明日 [みょうにち]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Tomorrow, Near Future [Only applies to あす]" +
                 "\n -- The day after the current day."}},

                {"遊ぶ", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "asobu" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "あそぶ" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "遊ぶ [あすぶ], あすぶ [Obsolete]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To play (Games, sports), To hang out, To have a good time, To meet up"}},

                {"あそこ", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "asoko" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "あそこ" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "彼処 [あそこ], 彼処 [かしこ], 彼所 [あそこ] (Rarely used with Kanji)" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Over there, There, That place" +
                 "\n -- A place far from both the speaker and the listener" +
                 "\n 2. That far, That much, That point (Usually written with kana only)"}},

                {"頭", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "atama" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "あたま" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "頭 [かしら]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Head, Top" +
                 "\n -- The upper part of any body."}},

                {"新しい", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "atarashii" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "あたらしい" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "新らしい [あたらしい]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. New, Novel, Fresh, Recent, Latest"}},

                {"あたたかい", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "atatakai" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "あたたかい" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "暖かい [あたたかい], 温かい [あたたかい], 温かい [あったかい]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Warm, mild, (pleasantly) hot" +
                 "\n -- Of or at a fairly or comfortably high temperature." +
                 "\n 2. Considerate, Kind, Genial"}},

                {"後", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "ato" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "あと" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Behind, rear (position)" +
                 "\n \n 2. After, Later, More(e.g minutes), left (Time)"}},

                {"あつい", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "atsui" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "あつい" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "暑い [あつい], 熱い [あつい], 厚い [あつい]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [厚い] Thick, Deep, Heavy" +
                 "\n -- Density level" +
                 "\n 2. [熱い] Hot (to the touch), passionate, Hot (topic)" +
                 "\n \n 3. Hot, Warm, Heated (Temperature)"}},

                {"あう", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "au" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "あう" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "逢う [あい], 遭う [あう], 遇う [あう], 会う [あう] (Standard Kanji Form)" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To meet, To encounter, To see, To have an accident" +
                 "\n -- To meet something (Like an accident) or someone"}},

                {"ばんごはん", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "ban gohan" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ばんごはん" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "晩御飯 [ばんごはん], 晩ご飯 [ばんごはん]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Dinner, evening meal" +
                 "\n -- The last meal of the day"}},

                {"番号", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "bangoo" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ばんごう" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. a number"}},

                {"バス", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "basu | bas" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ばす" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [From English] Bus" +
                 "\n -- Big and (not necessarily) large car that is used to transport people from one place to another "}},

                {"バター", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "bataa" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ばたあ" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [From English] Butter"}},

                {"ベッド", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "Beddo" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "べっど" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [From English] Bed" +
                 "\n -- Thing one uses to sleep into, usually, this word is used for big beds and not floor beds (futons)."}},

                {"便利", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "ben ri" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "べんり" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [な-Adjective] Convenient, Handy, Useful" +
                 "\n -- Something one can use to take advantage of or to help in the current situation."}},

                {"ボールペン", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "booru pen" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ぼおるぺん" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [From English] Pen, Ball-point pen"}},

                {"ボタン", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "Botan" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ぼたん" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [From English] Button"}},

                {"ぼうし", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "booshi" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ぼうし" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "帽子 [ぼうし] (Usually written in Kana only)" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Hat, Cap"}},

                {"豚肉", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "Buta niku" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ぶたにく" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "ぶた肉 [ぶたにく], 豚肉 [とんにく]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Pork (meat)"}},

                {"病院", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "Byoo in" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "びょういん" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Hospital, Health Center" +
                 "\n -- Place where sick people usually go."}},

                {"病気", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "byoo ki" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "びょうき" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Illness, disease, sickness"}},

                {"茶色", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "Cha iro" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ちゃいろ" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Brown" +
                 "\n -- Combination of the colors red and green, yellow and purple or blue and orange"}},

                {"茶碗", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "Cha wan" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ちゃわん" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Rice bowl, Tea cup, Teacup"}},

                {"父", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "Chichi" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ちち" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "父 [ちゃん] [Obsolete kanji usage]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Father" +
                 "\n -- Your paternal guardian"}},

                {"違い", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "Chiga u" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ちがう" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To differ, To not be the way someone say, To be wrong, incorrect or mistaken" +
                 "\n \n 2. Isn't it?, Wasn't it? (Kansai dialect)"}},

                {"小さい", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "Chii sai" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ちいさい" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "ちいさい" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [い-Adjective] Small, Little, Tiny" +
                 "\n -- Not big"}},

                {"小さな", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "Chii sa na" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ちいさな" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "ちいさな" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [な-Adjective] [Pre-noun adjectival] Small, Little, Tiny" +
                 "\n -- Not big"}},

                {"近い", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "Chikai" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ちかい" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "ちかい" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Near, Close"}},

                {"地下鉄", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "chikate tsu" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ちかてつ" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "ちかてつ" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Subway, Metro, Underground railway" +
                 "\n -- A place where people go to go into a train and be transported to another (marked) place"}},

                {"地図", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "Chizu" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ちず" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Map, Atlas, Chart" +
                 "\n -- Piece of paper use for orientation"}},

                {"ちょっと", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "Chotto" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ちょっと" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "一寸 [ちょっと] (Rarely kanji usage)" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. A little" +
                 "\n \n 2. Wait!" +
                 "\n -- Abbreviation of ちょっと待って"}},

                {"ちょうど", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "choodo" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ちょうど" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "丁度 [ちょうど]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1.Exactly, Precisely, Just, Right" +
                 "\n -- The point something usually prefer or is looking for at some moment."}},

                {"台所", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "Dai dokoro" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "だいどころ" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Kitchen" +
                 "\n -- Place where food is made and (in some places) also is eaten."}},

                {"大学", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "Dai gaku" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "だいがく" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. University, College"}},

                {"大丈夫", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "Dai jou bu" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "だいじょうぶ" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "だいじょうぶ" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Okay, Good, OK, Alright, Problem free"}},

                {"大好き", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Dai suki | Dai ski" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "だいすき" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. To love, To like, To like very much, To Adore"

                }},
                {"だんだん", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Dan dan" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "だんだん" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "段々 [だんだん], 段段 [だんだん]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Gradually, By degrees, Little by little, More and more, Increasingly" +
                "\n \n 2. [Onomatopeia] Steps, Stairs"
                }},

                {"誰", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Dare" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "だれ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "誰 [だあれ], 誰 [たれ] (Obsolete), 誰 [た] (Obsolete)" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Who"
                }},

                {"誰か", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "dare ka" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "だれか" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Someone, Somebody"
                }},

                {"出す", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Dasu" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "だす" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. To take out, To get out, To put out, To reveal, To show, To submit, To publish, To send" +
                "\n \n 2. To produce (a sound), To let a sound escape" +
                "\n \n 3. To start... (doing something suddenly), To begin... (doing something suddenly)"
                }},

                {"出口", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "de guchi" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "でぐち" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Exit, Gateway, Way out" +
                "\n \n 2. Outlet, Vent, Leak"
                }},

                {"出かける", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Dekakeru" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "でかける" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. To depart, To go out (e.g on an excursion or outing), To leave"
                }},

                {"電気", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Den ki" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "でんき" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Electricity" +
                "\n \n 2. (Electric) Light" +
                "\n \n 3. (As a science) Electricity"
                }},

                {"電車", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Densha" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "でんしゃ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Train, Electric train"
                }},

                {"電話", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Denwa" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "でんわ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Telephone call, Phone call" +
                "\n \n 2. Telephone (device), Phone" +
                "\n \n 3. (In telecommunications) Telephony"
                }},

                {"デパート", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Depaato" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "でぱーと" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Department Store"
                }},

                {"出る", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "deru" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "でる" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. To exit, To leave, To go out,"
                }},

                {"ドア", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Doa" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "どあ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "ドアー" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. [From English] Door (Western-style, car, etc)"
                }},

                {"どっち", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Docchi" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "どっち" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "何方 [どっち] (Rarely used with Kanji)" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Which, Which one"
                }},

                {"どちら", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Do chira" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "どちら" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "何方 [どちら] (Rarely used with Kanji)" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Which one (of two), Which way, Which direction"
                }},

                {"どこ", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "doko" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "どこ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "何処 [どこ]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Where, What place"
                }},

                {"どなた", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Donata" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "どなた" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "何方 [どなた]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Who (Polite)"
                }},

                {"どの", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Dono" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "どの" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "何の [どの] (Rarely used with Kanji)" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Which (of two or more things of the same name, like for example a car)"
                }},
                {"どれ", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Dore" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "どれ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "何れ [どれ] (Rarely used with Kanji)" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Which (of three or more things)" +
                "\n \n 2. Let's see... (When used two times [どれどれ])"
                }},

                {"どう", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Doo" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "どう" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "如何 [どう] (Rarely used Kanji form)" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. How, In what way, How about"
                }},

                {"動物", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Doo butsu" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "どうぶつ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Animal"
                }},

                {"どうも", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Doomo" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "どうも" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Thanks, Thank you" +
                "\n \n 2. Much (Thanks), Very (Sorry), Quite (Regret)" +
                "\n \n 3. Greetings, Hello, Goodbye"
                }},

                {"どうぞ", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Doozo" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "どうぞ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Please (Go ahead), Go ahead"
                }},

                {"土曜日", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Doyoobi" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "どようび" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Saturday"
                }},

                {"絵", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "E" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "え" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "画 [え], 画 [が]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Picture, Drawing, Painting, Sketch" +
                "\n \n 2. Image (TV, film, etc), Picture, Footage"
                }},

                {"ええ", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "EE" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "ええ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Yes, Affirmative, That is correct, Right"
                }},

                {"映画", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Eega" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "えいが" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Movie, Film, Motion picture"
                }},

                {"映画館", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Eega kan" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "えいがかん" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Movie theater, Cinema"
                }},

                {"英語", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Eego" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "えいご" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. English (Language)"
                }},

                {"駅", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Eki" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "えき" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "驛 [えき]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Railway station, Train station" +
                "\n \n 2. Counter for railway stations and bus stations"
                }},

                {"鉛筆", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Enpitsu" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "えんぴつ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "エンピツ [えんぴつ]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Pencil"
                }},

                {"エレベーター", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Erebee taa" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "えれべーたー" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Elevator, lift"
                }},

                {"フィルム", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "firumu" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ふぃるむ" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Film"}},

                {"フォーク", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "fooku" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ふぉーく" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Fork"}},

                {"吹く", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "fuku" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ふく" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To blow (of the wind)"}},

                {"服", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "fuku" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ふく" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Clothes"}},

                {"降る", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "furu" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ふる" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To rain, To fall (from the sky)"}},

                {"古い", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "furui" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ふるい" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Old (for things)"}},

                {"二人", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "futari" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ふたり" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Two people, Together (with you)"}},

                {"二つ", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "futatsu" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ふたつ" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Two (things)"}},

                {"太い", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "futoi" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ふとい" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Thick, Fat"}},

                {"二日", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "futsuka" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ふつか" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Two days, The second day of the month"}},

                {"封筒", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "fuutou" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ふうとう" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Envelope"}},

                {"冬", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "fuyu" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ふゆ" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Winter"}},

                {"外国", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "gaikoku" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "がいこく" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Foreign Country"}},

                {"外国人", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "gaikokujin" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "がいこくじん" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Foreigner, Foreign citizen, Foreign national, Non-Japanese person"}},

                {"学校", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "gakkou" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "がっこう" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. School"}},

                {"学生", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "gakusei" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "がくせい" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Student"}},

                {"玄関", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "genkan" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "げんかん" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Entrance"}},

                {"元気", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "genki" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "げんき" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Lively, full of spirit, energetic, healthy"}},

                {"月曜日", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "getsuyoubi" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "げつようび" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Monday, The day of the moon"}},

                {"銀行", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "ginkou" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ぎんこう" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Bank"}},

                {"ギター", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "gita-" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ギター" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Guitar"}},
                 
                {"五", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "go" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ご" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Five, Number five"}},

                {"午後", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "gogo" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ごご" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Afternoon, P.M"}},

                {"ごはん", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "gohan" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ごはん" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "ご飯 [ごはん]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Rice, Lunch"}},

                {"午前", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "gozen" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ごぜん" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Morning, A.M"}},

                {"グラム", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "guramu" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "グラム" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. A gram"}},
                 
                {"牛肉", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "gyuuniku" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ぎゅうにく" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Cow meat, Beef"}},

                {"牛乳", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "gyuunyuu" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ぎゅうにゅう" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. (Cow's) Milk"}},

                {"歯", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "ha" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "は" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Tooth"}},

                {"八", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hachi" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はち" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Eight, Number eight"}},

                {"葉書", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hagaki" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はがき" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Podcast"}},

                {"母", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "haha" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はは" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Mother"}},

                {"はい", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hai" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はい" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Yes, That is correct"}},

                {"入る", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hairu" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はいる" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To enter, To go in"}},

                {"灰皿", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "haizara" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はいざら" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Ashtray"}},

                {"始まる", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hajimaru" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はじまる" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To begin, To start"}},

                {"初めて", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hajimete" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はじめて" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. For the first time"}},

                {"箱", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hako" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はこ" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Box, Crate"}},

                {"履く", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "haku" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はく" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To wear, To put on trousers"}},

                {"半", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "han" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はん" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Half, Semi-, Half-past"}},

                {"花", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hana" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はな" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Flower"}},

                {"鼻", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hana" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はな" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Nose"}},

                {"話", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hana" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はな" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Conversation, Talk, Speech, Chat"}},

                {"話す", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hana" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はな" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To talk, To speak, To convense"}},

                {"半分", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hanbun" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はんぶん" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Half"}},

                {"ハンカチ", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hankachi" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はんかち" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Handkerchief"}},

                {"晴れ", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hare" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はれ" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Clear weather, Sunny"}},

                {"晴れる", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hareru" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はれる" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To be sunny"}},

                {"貼る", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "haru" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はる" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To stick, To paste"}},

                {"春", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "haru" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はる" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Spring, Springtime"}},

                {"箸", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hashi" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はし" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Chopsticks"}},

                {"橋", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hashi" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はし" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Bridge"}},

                {"走る", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hashiru" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はしる" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To run"}},

                {"二十歳", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hatachi" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はたち" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. 20 years old, Twenty years old"}},

                {"働く", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hataraku" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はたらく" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To work"}},

                {"二十日", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hatsuka" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はつか" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Twentieth day of the month, 20 days"}},

                {"早い", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hayai" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はやい" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Fast, Early"}},

                {"速い", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hayai" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はやい" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Fast, Quick, Hasty, Brisk"}},

                {"辺", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hen" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "へん" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Area"}},

                {"下手", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "heta" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "へた" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Unskillful, Poor (in skills), awkwark"}},

                {"部屋", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "heya" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "へや" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Room"}},

                {"左", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hidari" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ひだり" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Left, Left hand side"}},

                {"東", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "higashi" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ひがし" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. East"}},

                {"飛行機", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hikouki" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ひこうき" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Airplane, Aircraft"}},

                {"引く", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hiku" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ひく" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To pull"}},

                {"弾く", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hiku" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ひく" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To play (an instrument)"}},

                {"低い", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hikui" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ひくい" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Short, Low"}},

                {"暇", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hima" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ひま" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Free time"}},

                {"広い", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hiroi" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ひろい" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Spacious, Vast, Wide"}},

                {"昼", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hiru" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ひる" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Noon, Midday, Daytime, Lunch"}},

                {"昼ご飯", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hirugohan" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ひるごはん" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Lunch"}},

                {"人", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hito" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ひと" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Person, Human"}},

                {"一人", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hitori" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ひとり" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. One person, Alone, Single"}},

                {"一つ", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hitotsu" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ひとつ" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. One thing, Only (one thing)"}},

                {"他", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hoka" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ほか" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Other (place, thing, person), The rest"}},

                {"本", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hon" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ほん" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Book, Volume, Script"}},

                {"本棚", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hondana" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ほんだな" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Bookshelf, Bookcase"}},

                {"本当", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hontou" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ほんとう" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Truth, Reality, Actuality, Fact" +
                 "\n 2. Really, Not lying"}},

                {"欲しい", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hoshii" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ほしい" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Want"}},

                {"細い", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hosoi" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ほそい" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Thin, Slender"}},

                {"ホテル", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hoteru" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ほてる" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Hotel"}},

                {"百", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hyaku" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ひゃく" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. 100, Hundred"}},

                {"一", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "ichi" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いち" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. One, Number one, Best, Foremost"}},

                {"一番", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "ichiban" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いちばん" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Number one, First, 1st, First Place, Best, Most"}},

                {"一日", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "ichinichi" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いちにち" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "一日 [いちにち], 一日 [ついたち]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. One day, all day" +
                 "\n 2. The first day of the month"}},

                {"家", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "ie" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いえ" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. House, Residence, Family"}},

                {"いかが", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "ikaga" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いかが" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. How, In what day, How about"}},

                {"池", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "ike" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いけ" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Pond"}},

                {"行く", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "iku" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いく" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To go, To move"}},

                {"いくら", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "ikura" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いくら" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. How much?, How many?"}},

                {"いくつ", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "ikutsu" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いくつ" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. How many?, How old?"}},

                {"今", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "ima" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いま" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Now, The present time"}},

                {"意味", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "imi" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いみ" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Meaning, Significance, Sense"}},

                {"妹", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "imouto" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いもうと" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Younger Sister"}},

                {"犬", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "inu" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いぬ" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Dog"}},

                {"入れる", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "ireru" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いれる" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To put in, To let in, To take in, To bring in, To insert, To install"}},

                {"入口", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "iriguchi" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いりぐち" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Entrance, Entry, Gate"}},

                {"色", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "iro" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いろ" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Colour, Color"}},

                {"色々", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "iroiro" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いろいろ" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Various"}},

                {"いる", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "iru" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いる" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "居る [いる]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To be (Animated things), To have"}},

                {"要る", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "iru" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "いる" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. To be needed, To be necessary, To be required, To be wanted, To need, To want"}},

                {"医者", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "isha" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "いしゃ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "お医者さん [おいしゃさん] (Polite)" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Doctor, Physician"}},

                {"忙しい", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "isogashii" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "いそがしい" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "忙がしい [いそがしい］(Irregular)" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Busy, Occupied, Hectic" +
                "\n \n 2. Restless, Hurried, Fidgety"}},

                {"一緒", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "issho" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "いっしょ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. (Doing something) Together" +
                "\n \n 2. (at) The same time"}},

                {"椅子", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "isu" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "いす" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "倚子 [いす] (Rarely used kanji form), イス [いす]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Chair, Seat, Stool, Bench" +
                "\n \n 2. Position, Seat, Office"}},

                {"痛い", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "itai" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "いたい" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "甚い [いたい] (Rarely used kanji form), いたい (kana only)" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Painful, Sore" +
                "\n \n 2. (Colloquial) Cringy, Embarrassing"}},

                {"いつ", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "itsu" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "いつ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "何時 [いつ] (rarely used kanji form, usually written using kana alone)" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. When, At what time, How soon"}},

                {"五日", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "itsuka" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "いつか" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "5日 [ごにち] (Irregular kana usage, 5 can be replaced with 五)" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. 5th day of the month" +
                "\n \n 2. Five days"}},

                {"五つ", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "itsutsu" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "いつつ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. 5 (things)"}},

                {"言う", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "iu" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "いう" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "言う [ゆう], 云う [いう], 云う [ゆう], 謂う [いう], 謂う [ゆう]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. To say, To utter, To declare" +
                "\n \n 2. To name, To call (someone or something by its name)" +
                "\n \n 3. To make a noise"}},

                {"嫌", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "iya" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "いや" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Disliking, Not Wanting, Unwilling (to do), Reluctant, To not like"}},

                {"じゃあ", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "jaa" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "じゃあ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "じゃ" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Then, Well, So, Well then"}},

                {"字引", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "jibiki" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "じびき" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "字引き [じびき]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Dictionary (Not very common nowadays, but still used in phrases like '生き字引'.)"}},

                {"自分", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "jibun" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "じぶん" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Myself, Yourself, Oneself, Himself, Herself" +
                "\n \n 2. I, Me" +
                "\n \n 3. (Kansai dialect) You"}},

                {"自動車", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "jidousha" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "じどうしゃ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Automobile, Car, Motorcar, Motor Vehicle, Auto"}},

                {"時間", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "jikan" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "じかん" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Time" +
                "\n \n 2. Hour" +
                "\n \n 3. Period, Class, Lesson"}},

                {"辞書", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "jisho" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "じしょ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Dictionary, Lexicon"}},

                {"自転車", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "jitensha" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "じてんしゃ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "自転車 [じでんしゃ]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Bicycle, Bike"}},

                {"丈夫", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "joubu" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "じょうぶ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Healthy, Robust, Strong, Solid, Durable"}},

                {"上手", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "jouzu" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "じょうず" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Skillful, Skilled, Proficient, Good (at something), Adept, Clever"}},


{"授業", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "jyugyou" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "じゅぎょう" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Lesson, Class work, Class (Time)"}},
{"十", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "jyuu" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "じゅう" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Number 10"}},
{"鞄", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kaban" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かばん" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Bag, Satchel, Briefcase, Basket"}},
{"花瓶", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kabin" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かびん" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. (Flower) Vase"}},
{"角", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kado" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かど" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Corner, Angle"}},
{"帰る", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kaeru" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かえる" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. To go back, To return back" +
    "\n \n 2. To return home"}},
{"返す", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kaesu" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かえす" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. To return something"}},
{"鍵", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kagi" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かぎ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Key, Key (to a problem, success, etc), Clue" +
    "\n \n 2. Lock"}},
{"階段", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kaidan" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かいだん" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Stairs, Stairway, Staircase"}},
{"買い物", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kaimono" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かいもの" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Shopping, Purchased goods"}},

{"会社", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kaisha" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かいしゃ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Company, Corporation"}},
{"掛かる", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kakaru" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かかる" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. To take (a resource, e.g time or money)"}},
{"掛ける", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kakeru" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かける" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. To hang up (e.g a coat, a picture on the wall, etc), To let hang(ing), To raise (e.g a flag)" +
    "\n \n 2. To make (a call)" +
    "\n \n 3. To multiply (arithmetic operations)"}},
{"書く", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kaku" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かく" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. To write, To compose, To pen, To draw [See also 描く]"}},
{"カメラ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kamera" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かめら" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. [From English] Camera"}},
{"紙", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kami" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かみ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Paper"}},
{"漢字", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kanji" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かんじ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Kanji, Chinese characters"}},
{"カップ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kappu" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かっぷ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. [From English] Cup"}},
{"体", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "karada" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "からだ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "身体 [からだ]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Body" +
    "\n \n 2. Dead body"}},
{"辛い", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "karai" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "からい" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "辛い [つらい]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Spicy, Hot" +
    "\n \n 2. Salty" +
    "\n \n 3. [Only applies to つらい] Painful, Bitter, Difficult (Emotionally), Tough"}},

{"カレー", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "karee" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かれー" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. [From English] Curry"}},
{"カレンダー", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "karendaa" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かれんだー" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. [From English] Calendar"}},
{"借りる", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kariru" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かりる" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. To borrow, To have a loan" +
    "\n \n 2. To rent, To hire"}},
{"傘", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kasa" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かさ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Umbrella, Parasol"}},
{"貸す", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kasu" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かす" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. To lend, To loan"}},
{"方", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kata" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かた" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Way of doing something" +
    "\n \n 2. Direction, Way"}},
{"家庭", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "katei" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かてい" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Household"}},
{"買う", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kau" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かう" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. To buy, To purchase"}},
{"川", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kawa" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かわ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. River, Stream"}},
{"可愛い", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kawaii" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かわいい" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Adorable, Cute, charming, lovely, Pretty" +
    "\n \n Innocent, Childlike, Childish, Lovable, Little, Tiny"}},

{"火曜日", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kayoubi" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かようび" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Tuesday, The second day of the week"}},
{"風", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kaze" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かぜ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Wind,"}},

{"風邪", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kaze" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かぜ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. A cold, Ague, Inflammatory respiratory system illness (in general)"}},

{"家族", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kazoku" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かぞく" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Family, Member of family"}},
{"警官", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "keikan" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "けいかん" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Policeman, Police officer"}},
{"結婚", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kekkon" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "けっこん" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Marriage" +
    "\n \n 2. (Used as 結婚する) To marry"}},
{"結構", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kekkon" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "けっこん" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Splendid, Enough"}},
{"今朝", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kesa" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "けさ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. This morning"}},
{"消す", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kesu" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "けす" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. To erase, To rub off, To cross out, To delete" +
    "\n \n 2. To turn off (A light, TV, heater, etc), To switch off" +
    "\n \n 3. To extinguish (a fire, candle, etc), To put out"}},
{"木", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "ki" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "き" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Tree, Wood, Timber"}},
{"消える", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kieru" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "きえる" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. To disappear"}},
{"黄色い", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kiiro" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "きいろ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. (Color) Yellow"}},

{"聞く", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kiku" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "きく" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. To hear, To listen (To music)" +
    "\n \n 2. To ask"}},
{"昨日", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kinou" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "きのう" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Yesterday, The day before today"}},
{"金曜日", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kin'youbi" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "きんようび" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Friday, The fifth day of the week"}},
{"切符", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kippu" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "きっぷ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Ticket"}},
{"嫌い", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kirai" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "きらい" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. To hate, To detest, To dislike, Disagreeable"}},
{"綺麗", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kirei" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "きれい" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Clean, Clear, Pure, Tidy, Neat" +
    "\n \n 2. Pretty, Lovely, Beautiful"}},
{"キログラム", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kiroguramu" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "きろぐらむ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. [From English] Kilogram, KG"}},
{"キロメートル", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kiromeetoru" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "きろめーとる" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. [From English] Kilometer, KM"}},
{"切る", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kiru" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "きる" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. To cut, To cut through" +
    "\n \n 2. To perform (Surgery)" +
    "\n \n 3. To turn off (e.g the light)" +
    "\n \n 4. To terminate (e.g a conversation), To hang up (the phone), To disconnect (from a call)."}},
{"着る", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kiru" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "きる" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. To wear (From the shoulders down), To put on" +
    "\n \n 2. To take (the blame, responsability), To bear"}},

{"喫茶店", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kissaten" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "きっさてん" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Coffee shop, tearoom, (a) Cafe"}},
{"北", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kita" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "きた" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. North, N"}},
{"汚い", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kitanai" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "きたない" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Dirty, Unclean, Indecent (Language, etc), Vulgar" +
    "\n \n 2. Disordered, Messy, Untidy, Poor"}},
{"切手", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kitte" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "きって" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Stamp (postage), Merchandise certificate"}},
{"こっち", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kocchi" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "こっち" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. This person, This way" +
    "\n \n 2. Here"}},
{"こちら", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kochira" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "こちら" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. This direction, This way"}},
{"子供", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kodomo" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "こども" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Child" +
    "\n \n 2. Childish"}},
{"声", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "koe" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "こえ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Voice" +
    "\n \n 2. Singing (of a bird), Chirping (of an insect)"}},
{"ここ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "koko" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "ここ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Here"}},
{"九日", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kokonoka" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "ここのか" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Nine days, The nineth day of the month"}},

{"九つ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kokonotsu" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "ここのつ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Nine things"}},
{"困る", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "komaru" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "こまる" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. To be troubled"}},
{"今晩", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "konban" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "こんばん" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Tonight, This evening"}},
{"今月", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kongetsu" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "こんげつ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. This month, The month one is currently on"}},
{"こんな", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "konna" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "こんな" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Such, Like this"}},
{"この", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kono" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "この" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. This... (followed by a noun)"}},
{"今週", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "konshuu" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "こんしゅう" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. This week"}},
{"コーヒー", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "koohii" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "コーヒー" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. [From English] Coffee"}},
{"コート", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kooto" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "コート" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. [From English] Coat"}},
{"コピー", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kopi" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "コピー" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. [From English] Copy, Photocopy"}},

{"コップ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "koppu" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "コップ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. [From English] Cup (Drinking vessel, Measure, Brassiere, Prize, etc)"}},
{"これ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kore" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "これ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. This (one)"}},
{"答える", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kotaeru" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "こたえる" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. To answer, To reply"}},
{"言葉", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kotoba" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "ことば" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Language, Dialect" +
    "\n \n Word, Phrase, Expression, Term"}},
{"今年", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kotoshi" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "ことし" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. This year"}},
{"交番", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kouban" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "こうばん" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Police box"}},
{"紅茶", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "koucha" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "こうちゃ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Black tea"}}

            };
        }
    }
}
