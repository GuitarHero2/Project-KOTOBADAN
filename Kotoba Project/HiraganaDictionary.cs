using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotoba_Project
{
    internal class HiraganaDictionary : JLPTClass
    {
        public Dictionary<string, List<string>> kanaDict;

        MenuTranslations MT = new MenuTranslations();

        public int languagueSettingsUpdater;

        public HiraganaDictionary()
        {
            Initialize();
        }

        public void Initialize()
        {
            kanaDict = new Dictionary<string, List<string>>()
            {
                {"こんにちは", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "Kon'nichiwa" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "こんにちは" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "今日は [こんにちは] (Obsolete), こんにちわ, こんちは, こんちわ" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Hello, Good day, Good Afternoon" +
                 "\n -- A way of greeting someone politely in the afternoon."}},

                {"こんにちわ", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "Kon'nichiwa" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "こんにちは" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "今日は [こんにちは] (Obsolete), こんにちわ, こんちは, こんちわ" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Hello, Good day, Good Afternoon" +
                 "\n -- A way of greeting someone politely in the afternoon."}},

                {"こんぴゅうたあ", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5]+
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "Kon'piuu taa" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "こんぴゅーたー" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "コンピューター [こんぴゅーたー]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [From English] Computer, Desktop, PC" +
                 "\n -- Multipurpose machine usually used for working, gaming and studying."}},

                {"こんぴゅーたあ", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5]+
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "Kon'piuu taa" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "こんぴゅーたー" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "コンピューター [こんぴゅーたー]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [From English] Computer, Desktop, PC" +
                 "\n -- Multipurpose machine usually used for working, gaming and studying."}},

                {"こんぴゅうたー", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5]+
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "Kon'piuu taa" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "こんぴゅーたー" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "コンピューター [こんぴゅーたー]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [From English] Computer, Desktop, PC" +
                 "\n -- Multipurpose machine usually used for working, gaming and studying."}},

                {"こんぴゅーたー", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5]+
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "Kon'piuu taa" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "こんぴゅーたー" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "コンピューター [こんぴゅーたー]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [From English] Computer, Desktop, PC" +
                 "\n -- Multipurpose machine usually used for working, gaming and studying."}},

                {"べんきょう", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Ben kyoo" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "べんきょう" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "べんきょう (Also writen in Hiragana)" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To study, Diligence" +
                 "\n -- The act of acquiring knowledge by investigating and learning from a source like a book or any related material about a certain topic."}},

                {"べんきょ", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Ben kyoo" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "べんきょう" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "べんきょう (Also writen in Hiragana), 勉強 [べんきょう]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To study, Diligence" +
                 "\n -- The act of acquiring knowledge by investigating and learning from a source like a book or any related material about a certain topic."}},

                {"かるい", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5]+
                MT.dictionaryInformation2[languagueSettingsUpdater] + "karui" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "かるい" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "軽い [かろい]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Light, Light feeling, Efforless, Agile, easy" +
                 "\n -- (い-Adjective) Something easy to move, lift or/and easy to do." +
                 "\n 2. Non-serious, Unimportant, Trivial" +
                 "\n -- (い-Adjective) Something you don't give the sufficient attention or you think it's not worthy to worry about."}},

                {"あびる", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "a biru " +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あびる" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "浴びる [あびる]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To bathe, To shower" +
                 "\n \n 2. To be covered in, To be flooded with"}},

                {"あぶない", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "abu nai " +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あぶない" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "危ない [あぶない]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Dangerous, Risky, Hazardous, Perilous, Precarious" +
                 "\n \n 2. Look out!, Watch out!, Be careful!, That's Dangerous!"}},

                {"あっち", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Acchi " +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あっち" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "彼方 [あっち] (Rarely used with Kanji), 彼方 [あち] (Obsolete), 彼方 [あちら] (Rarely used with Kanji), あっち" +
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

                {"あか", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "aka " +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あか" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "赤 [あか]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. (Color) [Noun] Red, Crimson, Scarlet"}},

                {"あかい", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "akai " +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あかい" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "赤い [あかい]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. (Color) [Adjective] Red, Crimson, Scarlet"}},

                {"あかるい", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Akarui " +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あかるい" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "明るい [あかるい]" +
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

                {"あき", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "aki " +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あき" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "秋 [あき]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Autumn, Fall"}},

                {"あく", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "aku " +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "空く [あく], 明く [あく]< 開く [あく] (Standard)" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To open (e.g doors, business, etc)"}},

                {"あまい", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "amai " +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あまい" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "甘い [あまい] (Standard)" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Sugary, Naive, Sweet, sweet-tasting, indulgent" +
                 "\n -- Something with a lot of sugar of a very sweet taste (can be either an object or words)"}},

                {"あめ", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "ame " +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あめ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "雨 [あめ]" +
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

                {"あね", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "ane " +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あね" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "姉 [ねえ] (Casual), 姉 [し] (Honorific), 姐 [あね], 姉 [あね] (Standard)" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Older sister, Elder sister, [姉さん] Young lady, Miss, Ma'am" +
                 "\n -- A young woman" +
                 "\n 2. Honorific suffix used after the name of a woman of equal or higher status"}},

                {"あに", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "ani " +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あに" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "兄 [けい], 兄 [あに] (Standard)" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Older brother, Elder brother, Young Boy" +
                 "\n -- A young man"}},

                {"あの", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Ano " +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あの" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "彼の [あの] (Rarely used kanji form), あん, あの (Standard)" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. That (thing, place, etc) over there" +
                 "\n -- Something far from both the speaker and the listener."}},

                {"あお", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "ao " +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あお" +
                 "\n \n Alternative forms:　蒼 [あお], 碧 [あお], 青 [あお] (Standard)" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. (Color) [Noun] Blue, Azure, Immature, young, green (like a plant that haven't grown up yet)"}},

                {"あおい", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "aoi " +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あおい" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "蒼い [あおい], 碧い [あおい], 青い [あおい] (Standard)" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. (Color) [Adjective] Blue, Azure, Unexperienced (Only applies to 蒼い and 青い)"}},

                {"あぱーと", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "apaato " +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あぱーと" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "アパート [あぱーと]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [From English] Apartment building, Apartment block, Apartment house, Apartment, House" +
                 "\n -- A building where more than one house is combined into a big house and is divided by level or floors"}},

                {"あぱあと", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "apaato " +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あぱーと" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "アパート [あぱーと]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [From English] Apartment building, Apartment block, Apartment house, Apartment, House" +
                 "\n -- A building where more than one house is combined into a big house and is divided by level or floors"}},

                {"あらう", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Arau " +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あらう" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "洗う [あらう]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To wash, To cleanse, To rinse, To purify (One's heart)" +
                 "\n -- Action of taking of the dirty parts of something."}},

                {"あれ", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "are" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あれ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "彼 [あれ], 彼れ [あれ] (Rarely kanji usage), あれ (Standard)" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. That (thing) over there" +
                 "\n -- Something far from both the speaker and the listener." +
                 "\n 2. Huh?, Eh?, What?" +
                 "\n -- Exclamation of confusion"}},

                {"ある", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "aru" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "ある" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "有る [ある], 在る [ある], ある" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To exist, To be, To live (For unanimated things)" +
                 "\n \n 2. To have" +
                 "\n -- To possess something" +
                 "\n 3. To be located"}},

                {"あるく", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "aruku" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あるく" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "歩く [あるく]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To walk" +
                 "\n -- The action of moving your legs towards a direction"}},

                {"あさ", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "asa" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あさ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "朝 [あさ]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. morning" +
                 "\n -- State of time where it is between 06:00 AM and 11:59 AM."}},

                {"あさごはん", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "asa gohan" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あさごはん" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "朝ご飯 [あさごはん], 朝ごはん [あさごはん]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Breakfast" +
                 "\n -- The first meal of the day"}},

                {"あさって", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "asatte" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あさって" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "あさって [みょうごにち], 明後日 [あさって]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. The day after tomorrow" +
                 "\n -- Two days after the current day (E.g 05/10, 明後日 would be 07/10)" +
                 "\n 2. Wrong (E.g Direction) [Only applies to あさって]"}},

                {"あし", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "ashi" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あし" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "脚 [あし], 肢 [あし], 足 [あし] (Standard)" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Foot, leg, paw, arm"}},

                {"あした", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "ashita" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あした" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "明日 [あす], 明日 [みょうにち], 明日 [あした]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Tomorrow, Near Future [Only applies to あす]" +
                 "\n -- The day after the current day."}},

                {"あそぶ", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "asobu" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あそぶ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "遊ぶ [あすぶ], あすぶ [Obsolete], 遊ぶ [あそぶ]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To play (Games, sports), To hang out, To have a good time, To meet up"}},

                {"あそこ", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "asoko" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あそこ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "彼処 [あそこ], 彼処 [かしこ], 彼所 [あそこ] (Rarely used with Kanji), あそこ" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Over there, There, That place" +
                 "\n -- A place far from both the speaker and the listener" +
                 "\n 2. That far, That much, That point (Usually written with kana only)"}},

                {"あたま", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "atama" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あたま" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "頭 [かしら], 頭 [あたま] (Standard)" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Head, Top" +
                 "\n -- The upper part of any body."}},

                {"あたらしい", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "atarashii" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あたらしい" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "新らしい [あたらしい], 新しい [あたらしい]" +
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

                {"あと", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "ato" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あと" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "後 [あと]" +
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
                MT.dictionaryInformation4[languagueSettingsUpdater] + "晩御飯 [ばんごはん], 晩ご飯 [ばんごはん], ばんごはん" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Dinner, evening meal" +
                 "\n -- The last meal of the day"}},

                {"ばんごう", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "bangoo" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "ばんごう" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "番号 [ばんごう]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. a number"}},

                {"ばす", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "basu | bas" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "ばす" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "バス [ばす]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [From English] Bus" +
                 "\n -- Big and (not necessarily) large car that is used to transport people from one place to another "}},

                {"ばたあ", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "bataa" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "ばたあ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "バター [ばたー]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [From English] Butter"}},

                {"ばたー", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "bataa" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "ばたあ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "バター [ばたー]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [From English] Butter"}},

                {"べっど", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Beddo" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "べっど" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "ベッド [べっど]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [From English] Bed" +
                 "\n -- Thing one uses to sleep into, usually, this word is used for big beds and not floor beds (futons)."}},

                {"べんり", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "ben ri" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "べんり" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "便利 [べんり]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [な-Adjective] Convenient, Handy, Useful" +
                 "\n -- Something one can use to take advantage of or to help in the current situation."}},

                {"ぼおるぺん", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "booru pen" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "ぼおるぺん" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "ボールペン [ぼーるぺん]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [From English] Pen, Ball-point pen"}},

                {"ぼーるぺん", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "booru pen" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "ぼおるぺん" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "ボールペン [ぼーるぺん]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [From English] Pen, Ball-point pen"}},

                {"ぼたん", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Botan" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "ぼたん" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "ボタン [ぼたん]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [From English] Button"}},

                {"ぼうし", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "booshi" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "ぼうし" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "帽子 [ぼうし] (Usually written in Kana only), ぼうし" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Hat, Cap"}},

                {"ぶたにく", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Buta niku" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "ぶたにく" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "ぶた肉 [ぶたにく], 豚肉 [とんにく], 豚肉 [ぶたにく]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Pork (meat)"}},

                {"びょういん", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Byoo in" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "びょういん" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "病院 [びょういん]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Hospital, Health Center" +
                 "\n -- Place where sick people usually go."}},

                {"びょうき", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "byoo ki" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "びょうき" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "病気 [びょうき]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Illness, disease, sickness"}},

                {"ちゃいろ", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Cha iro" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "ちゃいろ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "茶色 [ちゃいろ]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Brown" +
                 "\n -- Combination of the colors red and green, yellow and purple or blue and orange"}},

                {"ちゃわん", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Cha wan" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "ちゃわん" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "茶碗 [ちゃわん]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Rice bowl, Tea cup, Teacup"}},

                {"ちち", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Chichi" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "ちち" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "父 [ちゃん] [Obsolete kanji usage], 父 [ちち]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Father" +
                 "\n -- Your paternal guardian"}},

                {"ちがう", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Chiga u" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "ちがう" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "違う [ちがう]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To differ, To not be the way someone say, To be wrong, incorrect or mistaken" +
                 "\n \n 2. Isn't it?, Wasn't it? (Kansai dialect)"}},

                {"ちいさいい", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Chii sai" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "ちいさい" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "ちいさい, 小さい [ちいさい]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [い-Adjective] Small, Little, Tiny" +
                 "\n -- Not big"}},

                {"ちいさな", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Chii sa na" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "ちいさな" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "ちいさな, 小さな [ちいさな]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [な-Adjective] [Pre-noun adjectival] Small, Little, Tiny" +
                 "\n -- Not big"}},

                {"ちかい", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Chikai" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "ちかい" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "ちかい, 近い [ちかい]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Near, Close"}},

                {"ちかてつ", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "chikate tsu" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "ちかてつ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "ちかてつ, 地下鉄 [ちかてつ]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Subway, Metro, Underground railway" +
                 "\n -- A place where people go to go into a train and be transported to another (marked) place"}},

                {"ちず", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Chizu" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "ちず" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "地図 [ちず]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Map, Atlas, Chart" +
                 "\n -- Piece of paper use for orientation"}},

                {"ちょっと", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Chotto" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "ちょっと" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "一寸 [ちょっと] (Rarely kanji usage), ちょっと" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. A little" +
                 "\n \n 2. Wait!" +
                 "\n -- Abbreviation of ちょっと待って"}},

                {"ちょうど", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "choodo" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "ちょうど" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "丁度 [ちょうど], ちょうど" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1.Exactly, Precisely, Just, Right" +
                 "\n -- The point something usually prefer or is looking for at some moment."}},

                {"だいどころ", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Dai dokoro" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "だいどころ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "台所 [だいどころ]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Kitchen" +
                 "\n -- Place where food is made and (in some places) also is eaten."}},

                {"だいがく", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Dai gaku" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "だいがく" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "大学 [だいがく]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. University, College"}},

                {"だいじょうぶ", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Dai jou bu" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "だいじょうぶ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "だいじょうぶ, 大丈夫 [だいじょうぶ]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Okay, Good, OK, Alright, Problem free"}},

                {"だいじょぶ", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Dai jou bu" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "だいじょうぶ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "だいじょうぶ, 大丈夫 [だいじょうぶ]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Okay, Good, OK, Alright, Problem free"}},

                {"だいすき", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Dai suki | Dai ski" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "だいすき" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "大好き [だいすき]" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. To love, To like, To like very much, To Adore"

                }},
                {"だんだん", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Dan dan" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "だんだん" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "段々 [だんだん], 段段 [だんだん], だんだん" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Gradually, By degrees, Little by little, More and more, Increasingly" +
                "\n \n 2. [Onomatopeia] Steps, Stairs"
                }},

                {"だれ", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Dare" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "だれ" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "誰 [だあれ], 誰 [たれ] (Obsolete), 誰 [た] (Obsolete), 誰 [だれ] (Standard)" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Who"
                }},

                {"だれか", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "dare ka" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "だれか" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "誰か [だれか]" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Someone, Somebody"
                }},

                {"だす", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Dasu" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "だす" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "出す [だす]" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. To take out, To get out, To put out, To reveal, To show, To submit, To publish, To send" +
                "\n \n 2. To produce (a sound), To let a sound escape" +
                "\n \n 3. To start... (doing something suddenly), To begin... (doing something suddenly)"
                }},

                {"でぐち", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "de guchi" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "でぐち" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "出口 [でぐち]" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Exit, Gateway, Way out" +
                "\n \n 2. Outlet, Vent, Leak"
                }},

                {"でかける", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Dekakeru" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "でかける" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "出かける [でかける]" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. To depart, To go out (e.g on an excursion or outing), To leave"
                }},

                {"でんき", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Den ki" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "でんき" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "電気 [でんき]" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Electricity" +
                "\n \n 2. (Electric) Light" +
                "\n \n 3. (As a science) Electricity"
                }},

                {"でんしゃ", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Densha" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "でんしゃ" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "電車 [でんしゃ]" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Train, Electric train"
                }},

                {"でんわ", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Denwa" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "でんわ" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "電話 [でんわ]" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Telephone call, Phone call" +
                "\n \n 2. Telephone (device), Phone" +
                "\n \n 3. (In telecommunications) Telephony"
                }},

                {"でぱあと", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Depaato" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "でぱーと" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "デパート [でぱーと］" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Department Store"
                }},

                {"でぱーと", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Depaato" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "でぱーと" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "デパート [でぱーと］" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Department Store"
                }},

                {"でる", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "deru" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "でる" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "出る [でる]" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. To exit, To leave, To go out,"
                }},

                {"どあ", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Doa" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "どあ" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "ドアー [どあー], ドア [どあ]" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. [From English] Door (Western-style, car, etc)"
                }},

                {"どっち", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Docchi" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "どっち" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "何方 [どっち] (Rarely used with Kanji), どっち (Standard)" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Which, Which one"
                }},

                {"どちら", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Do chira" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "どちら" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "何方 [どちら] (Rarely used with Kanji), どちら (Standard)" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Which one (of two), Which way, Which direction"
                }},

                {"どこ", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "doko" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "どこ" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "何処 [どこ], どこ (Standard)" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Where, What place"
                }},

                {"どなた", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Donata" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "どなた" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "何方 [どなた], どなた (Standard)" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Who (Polite)"
                }},

                {"どの", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Dono" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "どの" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "何の [どの] (Rarely used with Kanji), どの (Standard)" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Which (of two or more things of the same name, like for example a car)"
                }},
                {"どれ", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Dore" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "どれ" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "何れ [どれ] (Rarely used with Kanji), どれ (Standard)" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Which (of three or more things)" +
                "\n \n 2. Let's see... (When used two times [どれどれ])"
                }},

                {"どう", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Doo" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "どう" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "如何 [どう] (Rarely used Kanji form), どう (Standard)" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. How, In what way, How about"
                }},

                {"どうぶつ", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Doo butsu" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "どうぶつ" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "動物 [どうぶつ]" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Animal"
                }},

                {"どうも", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Doomo" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "どうも" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "どうも (Standard)" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Thanks, Thank you" +
                "\n \n 2. Much (Thanks), Very (Sorry), Quite (Regret)" +
                "\n \n 3. Greetings, Hello, Goodbye"
                }},

                {"どうぞ", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Doozo" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "どうぞ" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "どうぞ" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Please (Go ahead), Go ahead"
                }},

                {"どようび", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Doyoobi" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "どようび" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "土曜日 [どようび]" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Saturday"
                }},

                {"え", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "E" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "え" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "画 [え], 画 [が], 絵 [え] (Standard)" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Picture, Drawing, Painting, Sketch" +
                "\n \n 2. Image (TV, film, etc), Picture, Footage"
                }},

                {"ええ", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "EE" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "ええ" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "ええ" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Yes, Affirmative, That is correct, Right"
                }},

                {"えいが", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Eega" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "えいが" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "映画 [えいが]" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Movie, Film, Motion picture"
                }},

                {"えいがかん", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Eega kan" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "えいがかん" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "映画館 [えいがかん]" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Movie theater, Cinema"
                }},

                {"えいご", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Eego" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "えいご" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "英語 [えいご]" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. English (Language)"
                }},

                {"えき", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Eki" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "えき" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "驛 [えき], 駅 [えき]" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Railway station, Train station" +
                "\n \n 2. Counter for railway stations and bus stations"
                }},

                {"えんぴつ", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Enpitsu" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "えんぴつ" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "エンピツ [えんぴつ], 鉛筆 [えんぴつ]" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Pencil"
                }},

                {"えれべえたあ", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Erebee taa" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "えれべーたー" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "エレベーター [えれべーたー]" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. [From English] Elevator, lift"
                }},

                {"えれべーたあ", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Erebee taa" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "えれべーたー" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "エレベーター [えれべーたー]" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. [From English] Elevator, lift"
                }},

                {"えれべーたー", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Erebee taa" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "えれべーたー" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "エレベーター [えれべーたー]" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. [From English] Elevator, lift"
                }},

                {"えれべえたー", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Erebee taa" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "えれべーたー" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "エレベーター [えれべーたー]" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. [From English] Elevator, lift"
                }},

                {
                "ふぃるむ", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "firumu" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ふぃるむ" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "フィルム" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Film"}},

                {"ふぉおく", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "fooku" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ふぉーく" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "フォーク" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Fork"}},

                {"ふぉーく", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "fooku" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ふぉーく" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "フォーク" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Fork"}},

                {"ふく", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "fuku" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ふく" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [服] Clothes" +
                 "\n 2. [吹く] To blow (of the wind)"}},

                {"ふる", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "furu" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ふる" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "降る [ふる]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To rain, To fall (from the sky)"}},

                {"ふるい", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "furui" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ふるい" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "古い [ふるい]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Old (for things)"}},

                {"ふたり", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "futari" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ふたり" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "二人 [ふたり]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Two people, Together (with you)"}},

                {"ふたつ", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "futatsu" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ふたつ" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "二つ [ふたつ]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Two (things)"}},

                {"ふとい", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "futoi" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ふとい" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "太い [ふとい]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Thick, Fat"}},

                {"ふつか", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "futsuka" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ふつか" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "二日 [ふつか]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Two days, The second day of the month"}},

                {"ふうとう", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "fuutou" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ふうとう" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "封筒 [ふうとう]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Envelope"}},

                {"ふゆ", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "fuyu" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ふゆ" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "冬 [ふゆ]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Winter"}},

                {"ふぁいこく", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "gaikoku" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "がいこく" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "外国 [がいこく]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Foreign Country"}},

                {"がいこくじん", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "gaikokujin" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "がいこくじん" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "外国人 [がいこくじん]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Foreigner, Foreign citizen, Foreign national, Non-Japanese person"}},

                {"がっこう", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "gakkou" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "がっこう" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "学校 [がっくう]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. School"}},

                {"がくせい", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "gakusei" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "がくせい" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "学生 [がくせい]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Student"}},

                {"げんかん", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "genkan" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "げんかん" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "玄関 [げんかん]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Entrance"}},

                {"げんき", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "genki" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "げんき" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "元気 [げんき]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Lively, full of spirit, energetic, healthy"}},

                {"げつようび", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "getsuyoubi" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "げつようび" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "月曜日 [げつようび]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Monday, The day of the moon"}},

                {"ぎんこう", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "ginkou" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ぎんこう" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "銀行 [ぎんこう]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Bank"}},

                {"ぎたあ", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "gita-" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ぎたー" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "ギター [ぎたー]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Guitar"}},

                {"ぎたー", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "gita-" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ぎたー" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "ギター [ぎたー]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Guitar"}},

                {"ぎた", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "gita-" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ぎたー" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "ギター [ぎたー]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Guitar"}},

                {"ご", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "go" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ご" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "五 [ご]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Five, Number five"}},

                {"ごご", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "gogo" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ごご" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "午後 [ごご]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Afternoon, P.M"}},

                {"ごはん", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "gohan" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ごはん" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "ご飯 [ごはん]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Rice, Lunch"}},

                {"ごぜん", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "gozen" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ごぜん" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "午前 [ごぜん]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Morning, A.M"}},

                {"ぐらむ", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "guramu" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ぐらむ" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "グラム [ぐらむ]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. A gram"}},

                {"ぎゅうにく", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "gyuuniku" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ぎゅうにく" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "牛肉 [ぎゅうにく]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Cow meat, Beef"}},

                {"ぎゅうにゅう", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "gyuunyuu" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ぎゅうにゅう" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "牛乳 [ぎゅうにゅう]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. (Cow's) Milk"}},

                {"は", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "ha" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "は" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "歯 [は]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Tooth"}},

                {"はち", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hachi" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はち" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "八 [はち]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Eight, Number eight"}},

                {"はがき", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hagaki" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はがき" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "葉書 [はがき]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Podcast"}},

                {"はは", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "haha" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はは" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "母 [はは]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Mother"}},

                {"はい", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hai" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はい" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Yes, That is correct"}},

                {"はいる", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hairu" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はいる" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "入る [はいる], 入る [いる]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To enter, To go in"}},

                {"はいざら", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "haizara" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はいざら" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "灰皿 [はいざら]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Ashtray"}},

                {"はじまる", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hajimaru" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はじまる" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "始まる [はじまる]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To begin, To start"}},

                {"はじめて", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hajimete" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はじめて" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "初めて [はじめて]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. For the first time"}},

                {"はこ", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hako" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はこ" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "箱 [はこ]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Box, Crate"}},

                {"はく", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "haku" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はく" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "履く [はく]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To wear, To put on trousers"}},

                {"はん", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "han" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はん" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "半 [はん]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Half, Semi-, Half-past"}},

                {"はな", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hana" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はな" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [花] Flower" +
                 "\n 2. [鼻] Nose"}},

                {"はなし", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hana" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はな" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "話 [はなし]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Conversation, Talk, Speech, Chat"}},

                {"はなす", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hana" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はな" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "話す [はなす]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To talk, To speak, To convense"}},

                {"はんぶん", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hanbun" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はんぶん" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "半分 [はんぶん]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Half"}},

                {"はんかち", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hankachi" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はんかち" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "ハンカチ [はんかち]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Handkerchief"}},

                {"はれ", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hare" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はれ" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "晴れ [はれ]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Clear weather, Sunny"}},

                {"はれる", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hareru" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はれる" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "晴れる [はれる]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To be sunny"}},

                {"はる", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "haru" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はる" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [貼る] To stick, To paste" +
                 "\n 2. [春] Spring, Springtime"}},

                {"はし", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hashi" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はし" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [箸] Chopsticks" +
                 "\n 2. [橋] Bridge"}},

                {"はしる", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hashiru" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はしる" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "走る [はしる]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To run"}},

                {"はたち", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hatachi" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はたち" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "二十歳 [はたち]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. 20 years old, Twenty years old"}},

                {"はたらく", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hataraku" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はたらく" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "働く [はたらく]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To work"}},

                {"はつか", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hatsuka" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はつか" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "二十日 [はつか]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Twentieth day of the month, 20 days"}},

                {"はやい", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hayai" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はやい" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [早い] Fast, Early" +
                 "\n 2. [速い] Fast, Quick, Hasty, Brisk"}},

                {"へん", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hen" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "へん" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [辺] Area" +
                 "\n 2. [変] Strange, Weird, Odd"}},

                {"へた", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "heta" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "へた" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "下手 [下手]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Unskillful, Poor (in skills), awkwark"}},

                {"へや", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "heya" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "へや" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "部屋 [へや]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Room"}},

                {"ひだり", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hidari" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ひだり" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "左 [ひだり]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Left, Left hand side"}},

                {"はがし", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "higashi" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ひがし" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "東 [ひがし]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. East"}},

                {"ひこうき", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hikouki" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ひこうき" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "飛行機 [ひこうき]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Airplane, Aircraft"}},

                {"ひく", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hiku" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ひく" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [引く] To pull" +
                 "\n 2. [弾く] To play (an instrument)"}},

                {"ひくい", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hikui" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ひくい" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "低い [ひくい]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Short, Low"}},

                {"ひま", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hima" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ひま" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "暇 [ひま]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Free time"}},

                {"ひろい", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hiroi" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ひろい" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "広い [ひろい]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Spacious, Vast, Wide"}},

                {"ひる", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hiru" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ひる" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "昼 [ひる]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Noon, Midday, Daytime, Lunch"}},

                {"ひるごはん", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hirugohan" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ひるごはん" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "昼ご飯 [ひるごはん]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Lunch"}},

                {"ひと", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hito" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ひと" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "人 [ひと]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Person, Human"}},

                {"ひとり", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hitori" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ひとり" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "一人 [ひとり]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. One person, Alone, Single"}},

                {"ひとつ", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hitotsu" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ひとつ" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "一つ [ひとつ]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. One thing, Only (one thing)"}},

                {"ほか", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hoka" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ほか" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "他 [ほか]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Other (place, thing, person), The rest"}},

                {"ほん", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hon" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ほん" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "本 [ほん]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Book, Volume, Script"}},

                {"ほんだな", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hondana" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ほんだな" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "本棚 [ほんだな]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Bookshelf, Bookcase"}},

                {"ほんとう", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hontou" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ほんとう" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "本当 [ほんとう]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Truth, Reality, Actuality, Fact" +
                 "\n 2. Really, Not lying"}},

                {"ほしい", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hoshii" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ほしい" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "欲しい [ほしい]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Want"}},

                {"ほそい", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hosoi" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ほそい" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "細い [ほそい]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Thin, Slender"}},

                {"ほてる", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hoteru" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ほてる" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "ホテル [ほてる]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Hotel"}},

                {"ひゃく", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hyaku" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ひゃく" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "百 [ひゃく]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. 100, Hundred"}},

                {"いち", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "ichi" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いち" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "一 [いち]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. One, Number one, Best, Foremost"}},

                {"いちばん", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "ichiban" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いちばん" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "一番 [いちばん]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Number one, First, 1st, First Place, Best, Most"}},

                {"いちにち", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "ichinichi" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いちにち" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "一日 [いちにち], 一日 [ついたち]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. One day, all day" +
                 "\n 2. The first day of the month"}},

                {"ついたち", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "ichinichi" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いちにち" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "一日 [いちにち], 一日 [ついたち]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. One day, all day" +
                 "\n 2. The first day of the month"}},

                {"いえ", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "ie" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いえ" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "家 [いえ]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. House, Residence, Family"}},

                {"いかが", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "ikaga" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いかが" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. How, In what day, How about"}},

                {"いけ", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "ike" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いけ" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "池 [いけ]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Pond"}},

                {"いく", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "iku" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いく" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "行く [いく], 行く [やく]" +
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

                {"いま", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "ima" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いま" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "今 [いま]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Now, The present time"}},

                {"いみ", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "imi" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いみ" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "意味 [いみ]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Meaning, Significance, Sense"}},

                {"いもうと", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "imouto" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いもうと" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "妹 [いもうと]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Younger Sister"}},

                {"いぬ", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "inu" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いぬ" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "犬 [いぬ]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Dog"}},

                {"いれる", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "ireru" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いれる" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "入れる [いれる]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To put in, To let in, To take in, To bring in, To insert, To install"}},

                {"いりぐち", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "iriguchi" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いりぐち" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "入口 [いりぐち]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Entrance, Entry, Gate"}},

                {"いろ", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "iro" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いろ" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "色 [いろ]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Colour, Color"}},

                {"いろいろ", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "iroiro" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いろいろ" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "色々 [いろいろ]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Various"}},

                {"いる", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "iru" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いる" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "いる, 居る [いる]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [居る] To be (Animated things), To have" +
                 "\n \n 2. [要る] To be needed, To be necessary, To be required, To be wanted, To need, To want"}},

                {"いしゃ", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "isha" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "いしゃ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "お医者さん [おいしゃさん] (Polite), 医者 [いしゃ]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Doctor, Physician"}},

                {"いそがしい", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "isogashii" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "いそがしい" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "忙がしい [いそがしい］(Irregular), 忙しい [いそがしい]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Busy, Occupied, Hectic" +
                "\n \n 2. Restless, Hurried, Fidgety"}},

                {"いっしょ", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "issho" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "いっしょ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "一緒 [いっしょ]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. (Doing something) Together" +
                "\n \n 2. (at) The same time"}},

                {"いす", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "isu" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "いす" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "倚子 [いす] (Rarely used kanji form), イス [いす], 椅子 [いす]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Chair, Seat, Stool, Bench" +
                "\n \n 2. Position, Seat, Office"}},

                {"いたい", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "itai" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "いたい" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "甚い [いたい] (Rarely used kanji form), いたい (kana only), 痛い [いたい]" +
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

                {"いつか", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "itsuka" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "いつか" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "5日 [ごにち] (Irregular kana usage, 5 can be replaced with 五), 五日 [いつか] (Standard form)" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. 5th day of the month" +
                "\n \n 2. Five days"}},

                {"いつつ", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "itsutsu" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "いつつ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "五つ" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. 5 (things)"}},

                {"いう", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "iu" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "いう" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "言う [いう], 言う [ゆう], 云う [いう], 云う [ゆう], 謂う [いう], 謂う [ゆう]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. To say, To utter, To declare" +
                "\n \n 2. To name, To call (someone or something by its name)" +
                "\n \n 3. To make a noise"}},

                {"いや", new List<string>{
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

                {"じびき", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "jibiki" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "じびき" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "字引き [じびき]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Dictionary (Not very common nowadays, but still used in phrases like '生き字引'.)"}},

                {"じぶん", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "jibun" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "じぶん" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Myself, Yourself, Oneself, Himself, Herself" +
                "\n \n 2. I, Me" +
                "\n \n 3. (Kansai dialect) You"}},

                {"じどうしゃ", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "jidousha" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "じどうしゃ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Automobile, Car, Motorcar, Motor Vehicle, Auto"}},

                {"じかん", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "jikan" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "じかん" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Time" +
                "\n \n 2. Hour" +
                "\n \n 3. Period, Class, Lesson"}},

                {"じしょ", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "jisho" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "じしょ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Dictionary, Lexicon"}},

                {"じてんしゃ", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "jitensha" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "じてんしゃ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "自転車 [じでんしゃ]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Bicycle, Bike"}},

                {"じょうぶん", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "joubu" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "じょうぶ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Healthy, Robust, Strong, Solid, Durable"}},

                {"じょうず", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "jouzu" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "じょうず" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Skillful, Skilled, Proficient, Good (at something), Adept, Clever"}},

{"じゅぎょう", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "jyugyou" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "じゅぎょう" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "授業 [じゅぎょう]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Lesson, Class work, Class (Time)"}},
{"じゅう", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "jyuu" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "じゅう" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "十 [じゅう], 中 [ちゅう, じゅう]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Number 10" +
    "\n \n 2. ～ing, In the middle of something (e.g studying, 勉強中)"}},
{"かばん", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kaban" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かばん" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "鞄 [かばん]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Bag, Satchel, Briefcase, Basket"}},
{"かびん", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kabin" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かびん" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "花瓶 [かびん]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. (Flower) Vase"}},
{"かど", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kado" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かど" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "角 [かど]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Corner, Angle"}},
{"かえる", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kaeru" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かえる" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "帰る [かえる]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. To go back, To return back" +
    "\n \n 2. To return home"}},
{"かえす", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kaesu" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かえす" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "返す [かえす]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. To return something"}},
{"かぎ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kagi" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かぎ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "鍵 [かぎ]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Key, Key (to a problem, success, etc), Clue" +
    "\n \n 2. Lock"}},
{"かいだん", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kaidan" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かいだん" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "階段 [かいだん]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Stairs, Stairway, Staircase"}},
{"かいもの", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kaimono" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かいもの" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "買い物 [かいもの]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Shopping, Purchased goods"}},

{"かいしゃ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kaisha" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かいしゃ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "会社 [かいしゃ]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Company, Corporation"}},
{"かかる", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kakaru" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かかる" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "掛かる [かかる]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. To take (a resource, e.g time or money)"}},
{"かける", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kakeru" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かける" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "掛ける [かける]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. To hang up (e.g a coat, a picture on the wall, etc), To let hang(ing), To raise (e.g a flag)" +
    "\n \n 2. To make (a call)" +
    "\n \n 3. To multiply (arithmetic operations)"}},
{"かく", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kaku" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かく" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "書く [かく]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. To write, To compose, To pen, To draw [See also 描く]"}},
{"かめら", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kamera" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かめら" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "カメラ [かめら]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. [From English] Camera"}},
{"かみ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kami" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かみ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "紙 [かみ]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Paper"}},
{"かんじ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kanji" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かんじ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "漢字 [かんじ]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Kanji, Chinese characters"}},
{"かっぷ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kappu" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かっぷ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "カップ [かっぷ]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. [From English] Cup"}},
{"からだ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "karada" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "からだ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "身体 [からだ], 体 [からだ]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Body" +
    "\n \n 2. Dead body"}},
{"からい", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "karai" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "からい" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "辛い [つらい], 辛い [からい]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Spicy, Hot" +
    "\n \n 2. Salty" +
    "\n \n 3. [Only applies to つらい] Painful, Bitter, Difficult (Emotionally), Tough"}},

{"つらい", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "karai" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "からい" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "辛い [つらい]," +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n \n 1. Painful, Bitter, Difficult (Emotionally), Tough"}},

{"かれえ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "karee" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かれー" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "カレー [かれー]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. [From English] Curry"}},
{"かれー", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "karee" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かれー" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "カレー [かれー]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. [From English] Curry"}},
{"かれんだあ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "karendaa" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かれんだー" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "カレンダー [かれんだー]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. [From English] Calendar"}},
{"かれんだー", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "karendaa" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かれんだー" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "カレンダー [かれんだー]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. [From English] Calendar"}},
{"かりる", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kariru" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かりる" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "借りる [かりる]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. To borrow, To have a loan" +
    "\n \n 2. To rent, To hire"}},
{"かさ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kasa" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かさ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "傘 [かさ]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Umbrella, Parasol"}},
{"かす", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kasu" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かす" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "貸す [かす]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. To lend, To loan"}},
{"かた", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kata" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かた" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "方 [かた]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Way of doing something" +
    "\n \n 2. Direction, Way"}},
{"かてい", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "katei" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かてい" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "家庭 [かてい]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Household"}},
{"かう", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kau" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かう" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "買う [かう]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. To buy, To purchase"}},
{"かわ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kawa" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かわ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "川 [かわ]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. River, Stream"}},
{"かわいい", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kawaii" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かわいい" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "可愛い [かわいい]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Adorable, Cute, charming, lovely, Pretty" +
    "\n \n Innocent, Childlike, Childish, Lovable, Little, Tiny"}},

{"かようび", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kayoubi" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かようび" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "火曜日 [かようび]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Tuesday, The second day of the week"}},
{"かぜ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kaze" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かぜ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. [風] Wind" +
    "\n \n 2. [風邪] A cold, Ague, Inflammatory respiratory system illness (in general)"}},

{"かぞく", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kazoku" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "かぞく" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "家族 [かぞく]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Family, Member of family"}},
{"かいかん", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "keikan" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "けいかん" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "警官 [けいかん]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Policeman, Police officer"}},
{"けっこん", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kekkon" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "けっこん" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "結婚 [けっこん]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Marriage" +
    "\n \n 2. (Used as 結婚する) To marry"}},
{"けっこう", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kekkon" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "けっこん" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "結構 [けっこう]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Splendid, Enough"}},
{"けさ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kesa" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "けさ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "今朝 [けさ]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. This morning"}},
{"けす", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kesu" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "けす" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "消す [けす]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. To erase, To rub off, To cross out, To delete" +
    "\n \n 2. To turn off (A light, TV, heater, etc), To switch off" +
    "\n \n 3. To extinguish (a fire, candle, etc), To put out"}},
{"き", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "ki" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "き" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "木 [き]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Tree, Wood, Timber"}},
{"きえる", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kieru" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "きえる" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "消える [きえる]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. To disappear"}},
{"きいろい", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kiiroi" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "きいろい" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "黄色い [きいろい]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. (Color) Yellow"}},

{"きく", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kiku" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "きく" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "聞く [きく]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. To hear, To listen (To music)" +
    "\n \n 2. To ask"}},
{"きのう", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kinou" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "きのう" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "昨日 [きのう]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Yesterday, The day before today"}},
{"きんようび", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kin'youbi" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "きんようび" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "金曜日 [きんようび]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Friday, The fifth day of the week"}},
{"きっぷ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kippu" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "きっぷ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "切符 [きっぷ]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Ticket"}},
{"きらい", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kirai" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "きらい" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "嫌い [きらい]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. To hate, To detest, To dislike, Disagreeable"}},
{"きれい", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kirei" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "きれい" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "綺麗 [きれい]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Clean, Clear, Pure, Tidy, Neat" +
    "\n \n 2. Pretty, Lovely, Beautiful"}},
{"きろぐらむ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kiroguramu" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "きろぐらむ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "キログラム [きろぐらむ]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. [From English] Kilogram, KG"}},
{"きろめえとる", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kiromeetoru" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "きろめーとる" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "キロメートル [きろめーとる]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. [From English] Kilometer, KM"}},
{"きろめーとる", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kiromeetoru" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "きろめーとる" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "キロメートル [きろめーとる]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. [From English] Kilometer, KM"}},
{"きる", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kiru" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "きる" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. [切る] To cut, To cut through" +
    "\n \n 2. [切る] To perform (Surgery)" +
    "\n \n 3. [切る] To turn off (e.g the light)" +
    "\n \n 4. [切る] To terminate (e.g a conversation), To hang up (the phone), To disconnect (from a call)." +
    "\n \n 5. [着る] To wear (From the shoulders down), To put on" +
    "\n \n 6. [着る] To take (the blame, responsability), To bear"}},

{"きっさてん", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kissaten" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "きっさてん" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "喫茶店 [きっさてん]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Coffee shop, tearoom, (a) Cafe"}},
{"きた", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kita" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "きた" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "北 [きた]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. North, N"}},
{"きたない", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kitanai" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "きたない" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "汚い [きたない]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Dirty, Unclean, Indecent (Language, etc), Vulgar" +
    "\n \n 2. Disordered, Messy, Untidy, Poor"}},
{"きって", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kitte" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "きって" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "切手 [きって]" +
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
{"こども", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kodomo" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "こども" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "子供 [こども]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Child" +
    "\n \n 2. Childish"}},
{"こえ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "koe" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "こえ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "声 [こえ]" +
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
{"ここのか", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kokonoka" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "ここのか" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "九日 [ここのか], 9日 [ここのか]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Nine days, The nineth day of the month"}},

{"ここのつ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kokonotsu" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "ここのつ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "九つ [ここのつ], ９つ [ここのつ]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Nine things"}},
{"こまる", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "komaru" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "こまる" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "困る [こまる]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. To be troubled"}},
{"こんばん", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "konban" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "こんばん" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "今晩 [こんばん]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Tonight, This evening"}},
{"こんげつ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kongetsu" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "こんげつ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "今月 [こんげつ]" +
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
{"こんしゅう", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "konshuu" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "こんしゅう" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "今週 [こんしゅう]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. This week"}},
{"こおひい", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "koohii" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "こーひー" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "コーヒー [こーひー]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. [From English] Coffee"}},
{"こうひい", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "koohii" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "こーひー" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "コーヒー [こーひー]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. [From English] Coffee"}},
{"こーひい", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "koohii" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "こーひー" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "コーヒー [こーひー]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. [From English] Coffee"}},
{"こおひー", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "koohii" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "こーひー" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "コーヒー [こーひー]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. [From English] Coffee"}},
{"こーひー", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "koohii" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "こーひー" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "コーヒー [こーひー]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. [From English] Coffee"}},
{"こーと", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kooto" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "こーと" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "コート [こーと]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. [From English] Coat"}},
{"こおと", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kooto" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "こーと" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "コート [こーと]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. [From English] Coat"}},
{"こぴい", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kopi" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "こぴー" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "コピー [こぴー]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. [From English] Copy, Photocopy"}},
{"こぴー", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kopi" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "こぴー" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "コピー [こぴー]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. [From English] Copy, Photocopy"}},

{"こっぷ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "koppu" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "こっぷ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "コップ [こっぷ]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. [From English] Cup (Drinking vessel, Measure, Brassiere, Prize, etc)"}},
{"これ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kore" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "これ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. This (one)"}},
{"こたえる", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kotaeru" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "こたえる" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "答える [こたえる]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. To answer, To reply"}},
{"ことば", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kotoba" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "ことば" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "言葉 [ことば]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Language, Dialect" +
    "\n \n Word, Phrase, Expression, Term"}},
{"ことし", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kotoshi" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "ことし" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "今年 [ことし]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. This year"}},
{"こうばん", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kouban" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "こうばん" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "交番 [こうばん]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Police box"}},
{"こうちゃ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "koucha" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "こうちゃ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "紅茶 [こうちゃ]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Black tea"}},

{"こうえん", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kouen" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "こうえん" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "公園 [こえん]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Park"}},
{"こうさてん", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kousaten" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "こうさてん" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "交差点 [こうさてん]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Intersection"}},
{"くち", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kuchi" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "くち" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "口 [くち]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Mouth" +
    "\n \n 2. Opening, Hole, Orifice" +
    "\n \n 3. Gate, Door, Entrance, Exit"}},
{"くだもの", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kudamono" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "くだもの" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "果物 [くだもの]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Fruit"}},
{"ください", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kudasai" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "ください" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "下さい [ください] (Usually written in kana only)" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Please"}},
{"くもり", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kumori" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "くもり" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "曇り [くもり]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Cloudiness, Cloudy weather"}},
{"くもる", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kumoru" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "くもる" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "曇る [くもる]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. To become cloudy, To become dim"}},
{"くに", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kuni" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "くに" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "国 [くに]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Country, State, Region"}},
{"くらい", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kurai" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "くらい" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "暗い [くらい]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Dark, Gloomy, Murky, Obscure"}},
{"くらす", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kurasu" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "くらす" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "クラス [くらす]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Class"}},

{"くろ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kuro" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "くろ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "黒 [くろ]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Black"}},
{"くろい", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kuroi" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "くろい" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "黒い [くろい]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. (Adjective) Color Black"}},
{"くる", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kuru" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "くる" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "来る [くる]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. To come, To arrive" +
    "\n \n 2. To come back, To do... and come back" +
    "\n \n 3. To come to be, To become"}},
{"くるま", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kuruma" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "くるま" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "車 [くるま]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Car, Automobile, Vehicle"}},
{"くすり", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kusuri" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "くすり" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "薬 [くすり]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Medicine"}},
{"くつ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kutsu" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "くつ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "靴 [くつ]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Shoes"}},
{"くつした", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kutsushita" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "くつした" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "靴下 [くつした]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Socks"}},
{"きょねん", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kyonen" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "きょねん" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "去年 [きょねん]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Last year"}},
{"きょう", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kyou" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "きょう" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "今日 [きょう]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Today, The day one is currently on, This day"}},
{"きょうだい", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kyoudai" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "きょうだい" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "兄弟 [きょうだい]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Siblings, Brothers and sisters"}},


{"きょうしつ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kyoushitsu" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "きょうしつ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "教室 [きょうしつ]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Classroom"}},
{"きゅう", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "kyuu" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "きゅう" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "九 [きゅう], 九 [く]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Number nine, 9"}},
{"まっち", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "macchi" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "まっち" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "マッチ [まっち]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. [From English] Match"}},
{"まち", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "machi" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "まち" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "町 [まち], 街 [まち]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Town, Block, Neighborhood"}},
{"まど", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "mado" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "まど" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "窓 [まど]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Window"}},
{"まえ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "mae" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "まえ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "前 [まえ]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. (Used as a adverb, 前に) Previous, Before" +
    "\n \n 2. (Used as a adjective with の particle, 前の) The front / frontal part" +
    "\n \n 3. (Use to count time pased, ～前に) ...ago"}},
{"まがる", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "magaru" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "まがる" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "曲がる [まがる]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. To bend, To curve, To Twist" +
    "\n \n 2. To turn"}},
{"まいあさ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "maiasa" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "まいあさ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "毎朝 [まいあさ]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Every morning"}},
{"まいばん", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "maiban" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "まいばん" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "毎晩 [まいばん]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Every night"}},
{"まいにち", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "mainichi" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "まいにち" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "毎日 [まいにち]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Every day"}},

{"まいしゅう", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "maishuu" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "まいしゅう" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "毎週 [まいしゅう]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Every week"}},
{"まいねん", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "maitoshi / mainen" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "まいとし / まいねん" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "毎年 [まいねん], 毎年 [まいとし]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Every year"}},
{"まいとし", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "maitoshi / mainen" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "まいとし / まいねん" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "毎年 [まいねん], 毎年 [まいとし]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Every year"}},
{"まいげつ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "maigetsu" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "まいげつ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "毎月 [まいげつ]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Every month"}},
{"まん", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "man" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "まん" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "万 [まん]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. 10.000, Ten thousand"}},
{"まんねんひつ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "mannenhitsu" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "まんねんひつ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "万年筆 [まんねんひつ]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Fountain pen"}},
{"まるい", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "marui" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "まるい" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "丸い [まるい]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Round, Circular" +
    "\n \n 2. Perfect"}},
{"まっすぐ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "massugu" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "まっすぐ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "真っ直ぐ [まっすぐ]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Straight ahead, Direct" +
    "\n \n 2. Straightforward, Honest, Frank"}},
{"まつ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "matsu" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "まつ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "待つ [まつ]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. To wait"}},
{"まずい", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "mazui" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "まずい" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "不味い [まずい]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Unpleasant"}},
{"め", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "me" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "め" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "目 [め]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Eye"}},

{"めえとる", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "meetoru" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "めーとる" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "メートル [めーとる]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. M, Meter"}},
{"めーとる", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "meetoru" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "めーとる" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "メートル [めーとる]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. M, Meter"}},
{"めがね", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "megane" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "めがね" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "眼鏡 [めがね]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Glasses"}},
{"みち", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "michi" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "みち" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "道 [みち]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Road, Street"}},
{"もどり", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "midori" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "みどり" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "緑 [みどり]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Green"}},
{"みがく", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "migaku" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "みがく" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "磨く [みがく]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. To polish, To shine, To brush (e.g teeth)"}},
{"みぎ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "migi" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "みぎ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "右 [みぎ]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Right (direction), Right hand side"}},
{"みじかい", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "mijikai" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "みじかい" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "短い [みじかい]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Short"}},
{"みっか", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "mikka" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "みっか" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "三日 [みっか]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Third day of the month, three days"}},
{"みみ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "mimi" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "みみ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "耳 [みみ]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Ears"}},
{"みなみ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "minami" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "みなみ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "南 [みなみ]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. South"}},

{"みなさん", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "minasan" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "みなさん" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "皆さん [みなさん]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Everyone"}},
{"みんな", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "minna" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "みんな" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. All, Everyone, Everybody"}},
{"みる", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "miru" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "みる" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "見る [みる]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. To see, To look, To watch, To view, To observe" +
    "\n \n 2. To examinate, To look over, To assess, To check, To judge"}},
{"みせ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "mise" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "みせ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "店 [みせ]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Store, Shop, Establishment, Restaurant (See レストラン)"}},
{"みせる", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "miseru" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "みせる" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "見せる [みせる]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. To show, To display"}},
{"みっつ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "mittsu" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "みっつ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "三つ [みっつ]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Three (things)"}},
{"みず", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "mizu" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "みず" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "水 [みず]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Water, Fluid, Liquid"}},
{"もくようび", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "mokuyoubi" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "もくようび" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "木曜日 [もくようび]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Thursday"}},
{"もん", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "mon" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "もん" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "門 [もん]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Gate"}},

{"もんだい", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "mondai" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "もんだい" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "問題 [もんだい]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Problem"}},
{"もの", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "mono" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "もの" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "物 [もの], 者 [もの]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Object, Thing"}},
{"もつ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "motsu" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "もつ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "持つ [もつ]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. To have, To possess, To own" +
    "\n \n 2. To hold (In one's hand), To take, To carry"}},
{"もっと", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "motto" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "もっと" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. More, Longer, Further"}},
{"もういちどう", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "mou ichido" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "もういちど" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "もう一度 [もういちど]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Once more, Again"}},
{"むいか", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "muika" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "むいか" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "六日 [むいか]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. The sixth day of the month, Six days"}},
{"むこう", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "mukou" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "むこう" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "向こう [むこう]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Over there, That way, Far away, Beyond" +
    "\n \n 2. Opposite side, Other side, Opposite direction"}},
{"むら", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "mura" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "むら" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "村 [むら]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Village"}},
{"むっつ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "muttsu" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "むっつ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "六つ [むっつ]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Six (things)"}},
{"むずかしい", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "muzukashii" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "むずかしい" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "難しい [むずかしい]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Hard, Difficult" +
    "\n \n 2. Impossible, Unfeasible (Euphemistic)"}},

{"ながい", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "nagai" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "ながい" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "長い [ながい]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Long (Distance), Long (Time), Lengthy"}},
{"ないふ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "naifu" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "ないふ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "ナイフ [ないふ]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. [From English] Knife"}},
{"なか", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "naka" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "なか" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "中 [なか], 中 [じゅう, ちゅう]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Inside, In, Within, Center" +
    "\n \n 2. ～ing, In the middle of something (e.g studying, 勉強中)"}},
{"ちゅう", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "naka" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "なか" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "中 [なか], 中 [じゅう, ちゅう]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Inside, In, Within, Center" +
    "\n \n 2. ～ing, In the middle of something (e.g studying, 勉強中)"}},
{"なく", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "naku" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "なく" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "鳴く [なく], 泣く [なく]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. To cry, To chirp, To bark, To meow" +
    "\n \n 2. To cry, To weep, To sob, To howl"}},
{"なくす", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "nakusu" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "なくす" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "無くす [なくす]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. To lose (something)" +
    "\n \n 2. To get rid of, To eliminate, To eradicate, To abolish"}},
{"なまえ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "namae" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "なまえ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "名前 [なまえ]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Name, Given name, First name"}},
{"ななつ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "nanatsu" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "ななつ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "七つ [ななつ]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Seven (Things)"}},
{"なに", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "nani" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "なに" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "何 [ななつ]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. What, What!, What do you want!? (Aggressive)"}},
{"なのか", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "nanoka" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "なのか" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "七日 [なのか]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. The seventh day of the month, Seven days"}},
{"ならべる", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "naraberu" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "ならべる" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "並べる [ならべる]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. To line up, To set up"}},
{"ならぶ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "narabu" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "ならぶ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "並ぶ [ならぶ]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. To line up, To stand in a line"}},
{"ならう", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "narau" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "ならう" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "習う [ならう]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. To be taught, To learn (from a teacher)"}},
{"なつ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "natsu" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "なつ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "夏 [なつ]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Summer"}},
{"なつやすみ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "natsuyasumi" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "なつやすみ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "夏休み [なつやすみ]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Summer vacation, Summer holiday"}},
{"なぜ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "naze" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "なぜ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "何故 [なぜ] " +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Why?, For what reason?"}},
{"ねこ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "neko" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "ねこ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "猫 [ねこ]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Cat"}},
{"ねくたい", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "nekutai" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "ねくたい" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "ネクタイ [ねくたい]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Necktie, Tie"}},
{"ねる", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "neru" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "ねる" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "寝る [ねる]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. To sleep, To go to bed, To lie down"}},
{"に", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "ni" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "に" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "二 [に]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Two, 2"}},

{"にちようび", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "nichiyoubi" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "にちようび" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "日曜日 [にちようび]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Sunday, The last day of the week"}},
{"にぎやか", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "nigiyaka" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "にぎやか" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "賑やか [にぎやか]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Bustling, Busy"}},

{"にっき", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "nikki" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "にっき" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "日記 [にっき]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Diary, Journal"}},
{"にく", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "niku" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "にく" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "肉 [にく]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Meat"}},
{"にもつ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "nimotsu" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "にもつ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "荷物 [にもつ]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Luggage, Baggage"}},
{"にし", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "nishi" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "にし" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "西 [にし]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. West"}},
{"にわ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "niwa" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "にわ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "鶏 [にわ]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Garden"}},
{"のぼる", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "noboru" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "のぼる" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "登る [のぼる]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. To climb"}},
{"のみもの", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "nomimono" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "のみもの" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "飲み物 [のみもの]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. A drick, Beverage"}},
{"のむ", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "nomu" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "のむ" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "飲む [のむ]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. To drink"}},
{"のおと", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "nooto" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "のーと" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "ノート [のーと]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Notebook, Excersive book" +
    "\n \n 2. Note" +
    "\n \n 3. (Musical) Note" +
    "\n \n 4. Laptop (Computer), Notebook (Computer)"}},

{"のーと", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "nooto" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "のーと" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "ノート [のーと]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. Notebook, Excersive book" +
    "\n \n 2. Note" +
    "\n \n 3. (Musical) Note" +
    "\n \n 4. Laptop (Computer), Notebook (Computer)"}},


{"のる", new List<string>{
    MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
    MT.dictionaryInformation2[languagueSettingsUpdater] + "noru" +
    MT.dictionaryInformation3[languagueSettingsUpdater] + "のる" +
    MT.dictionaryInformation4[languagueSettingsUpdater] + "乗る [のる]" +
    MT.dictionaryInformation5[languagueSettingsUpdater] +
    "\n 1. To get on (train, plane, bus, ship, etc)"}},

            };
        }
    }
}
