using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotoba_Project
{

    // Dictionary for alternative forms of the same word.
    internal class ExtendedSearch : JLPTClass
    {
        public Dictionary<string, List<string>> extraJisho;

        MenuTranslations MT = new MenuTranslations();

        public int languagueSettingsUpdater;

        public ExtendedSearch()
        {
            Initialize();
        }
        public void Initialize()
        {
            extraJisho = new Dictionary<string, List<string>>()
            {
                {"konnichiha", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "Kon'nichiwa" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "こんにちは" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "今日は [こんにちは] (Obsolete), こんにちわ, こんちは, こんちわ" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Hello, Good day, Good Afternoon" +
                 "\n -- A way of greeting someone politely in the afternoon."}},

                {"今日は", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "Kon'nichiwa" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "こんにちは" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "今日は [こんにちは] (Obsolete), こんにちわ, こんちは, こんちわ" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Hello, Good day, Good Afternoon" +
                 "\n -- A way of greeting someone politely in the afternoon."}},

                {"konnichiwa", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "Kon'nichiwa" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "こんにちは" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "今日は [こんにちは] (Obsolete), こんにちわ, こんちは, こんちわ" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Hello, Good day, Good Afternoon" +
                 "\n -- A way of greeting someone politely in the afternoon."}},

                {"konpyuutaa", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5]+
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "Kon'piuu taa" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "こんぴゅーたー" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "コンピューター [こんぴゅーたー]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [From English] Computer, Desktop, PC" +
                 "\n -- Multipurpose machine usually used for working, gaming and studying."}},

                {"こんぴゅうたあ", new List<string>{
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

                {"こんぴゅうたー", new List<string>{
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

                {"benkyou", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Ben kyoo" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "べんきょう" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "べんきょう (Also writen in Hiragana)" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To study, Diligence" +
                 "\n -- The act of acquiring knowledge by investigating and learning from a source like a book or any related material about a certain topic."}},

                {"benkyo", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Ben kyoo" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "べんきょう" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "べんきょう (Also writen in Hiragana), 勉強 [べんきょう]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To study, Diligence" +
                 "\n -- The act of acquiring knowledge by investigating and learning from a source like a book or any related material about a certain topic."}},

                {"karui", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5]+
                MT.dictionaryInformation2[languagueSettingsUpdater] + "karui" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "かるい" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "軽い [かろい]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Light, Light feeling, Efforless, Agile, easy" +
                 "\n -- (い-Adjective) Something easy to move, lift or/and easy to do." +
                 "\n 2. Non-serious, Unimportant, Trivial" +
                 "\n -- (い-Adjective) Something you don't give the sufficient attention or you think it's not worthy to worry about."}},

                {"abiru", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "a biru " +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あびる" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "浴びる [あびる]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To bathe, To shower" +
                 "\n \n 2. To be covered in, To be flooded with"}},

                {"abunai", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "abu nai " +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あぶない" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "危ない [あぶない]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Dangerous, Risky, Hazardous, Perilous, Precarious" +
                 "\n \n 2. Look out!, Watch out!, Be careful!, That's Dangerous!"}},

                {"acchi", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Acchi " +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あっち" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "彼方 [あっち] (Rarely used with Kanji), 彼方 [あち] (Obsolete), 彼方 [あちら] (Rarely used with Kanji), あっち" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. That way (over there), There" +
                 "\n -- Usually written using kana alone"}},

                {"ageru", new List<string>{
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

                {"aka", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "aka " +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あか" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "赤 [あか]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. (Color) [Noun] Red, Crimson, Scarlet"}},

                {"akai", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "akai " +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あかい" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "赤い [あかい]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. (Color) [Adjective] Red, Crimson, Scarlet"}},

                {"akarui", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Akarui " +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あかるい" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "明るい [あかるい]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Light, Bright" +
                 "\n -- High intensity of luminity." +
                 "\n 2. Happy, Cheerful, Bright, Sunny"}},

                {"akeru", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "akeru " +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あける" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "開ける [あける], 空ける [あける], 明ける [あける]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To open (e.g a door, etc), To unlock, To unwrap, To open (a business)" +
                 "\n \n 2. To empty, To remove, To make space, To leave (one's schedule) open, To make time (for something / someone)"}},

                {"aki", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "aki " +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あき" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "秋 [あき]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Autumn, Fall"}},

                {"aku", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "aku " +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "空く [あく], 明く [あく]< 開く [あく] (Standard)" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To open (e.g doors, business, etc)"}},

                {"amai", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "amai " +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あまい" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "甘い [あまい] (Standard)" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Sugary, Naive, Sweet, sweet-tasting, indulgent" +
                 "\n -- Something with a lot of sugar of a very sweet taste (can be either an object or words)"}},

                {"ame", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "ame " +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あめ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "雨 [あめ]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [雨] Rain" +
                 "\n -- The third step of the the water cycle." +
                 "\n 2. [飴] Candy, Sweet, Caramel"}},

                {"anata", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "anata " +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あなた" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "貴方 [あなた], 貴女 [あなた], 貴男 [あなた]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. You, Dear, Honey" +
                 "\n -- Polite but also considered rude and direct"}},

                {"ane", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "ane " +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あね" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "姉 [ねえ] (Casual), 姉 [し] (Honorific), 姐 [あね], 姉 [あね] (Standard)" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Older sister, Elder sister, [姉さん] Young lady, Miss, Ma'am" +
                 "\n -- A young woman" +
                 "\n 2. Honorific suffix used after the name of a woman of equal or higher status"}},

                {"ani", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "ani " +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あに" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "兄 [けい], 兄 [あに] (Standard)" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Older brother, Elder brother, Young Boy" +
                 "\n -- A young man"}},

                {"ano", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Ano " +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あの" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "彼の [あの] (Rarely used kanji form), あん, あの (Standard)" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. That (thing, place, etc) over there" +
                 "\n -- Something far from both the speaker and the listener."}},

                {"ao", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "ao " +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あお" +
                 "\n \n Alternative forms:　蒼 [あお], 碧 [あお], 青 [あお] (Standard)" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. (Color) [Noun] Blue, Azure, Immature, young, green (like a plant that haven't grown up yet)"}},

                {"aoi", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "aoi " +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あおい" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "蒼い [あおい], 碧い [あおい], 青い [あおい] (Standard)" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. (Color) [Adjective] Blue, Azure, Unexperienced (Only applies to 蒼い and 青い)"}},

                {"apaato", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "apaato " +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あぱーと" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "アパート [あぱーと]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [From English] Apartment building, Apartment block, Apartment house, Apartment, House" +
                 "\n -- A building where more than one house is combined into a big house and is divided by level or floors"}},

                {"arau", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Arau " +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あらう" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "洗う [あらう]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To wash, To cleanse, To rinse, To purify (One's heart)" +
                 "\n -- Action of taking of the dirty parts of something."}},

                {"are", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "are" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あれ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "彼 [あれ], 彼れ [あれ] (Rarely kanji usage), あれ (Standard)" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. That (thing) over there" +
                 "\n -- Something far from both the speaker and the listener." +
                 "\n 2. Huh?, Eh?, What?" +
                 "\n -- Exclamation of confusion"}},

                {"aru", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "aru" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "ある" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "有る [ある], 在る [ある], ある" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To exist, To be, To live (For unanimated things)" +
                 "\n \n 2. To have" +
                 "\n -- To possess something" +
                 "\n 3. To be located"}},

                {"aruku", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "aruku" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あるく" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "歩く [あるく]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To walk" +
                 "\n -- The action of moving your legs towards a direction"}},

                {"asa", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "asa" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あさ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "朝 [あさ]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. morning" +
                 "\n -- State of time where it is between 06:00 AM and 11:59 AM."}},

                {"asagohan", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "asa gohan" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あさごはん" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "朝ご飯 [あさごはん], 朝ごはん [あさごはん]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Breakfast" +
                 "\n -- The first meal of the day"}},

                {"asatte", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "asatte" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あさって" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "あさって [みょうごにち], 明後日 [あさって]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. The day after tomorrow" +
                 "\n -- Two days after the current day (E.g 05/10, 明後日 would be 07/10)" +
                 "\n 2. Wrong (E.g Direction) [Only applies to あさって]"}},

                {"ashi", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "ashi" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あし" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "脚 [あし], 肢 [あし], 足 [あし] (Standard)" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Foot, leg, paw, arm"}},

                {"ashita", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "ashita" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あした" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "明日 [あす], 明日 [みょうにち], 明日 [あした]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Tomorrow, Near Future [Only applies to あす]" +
                 "\n -- The day after the current day."}},

                {"asobu", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "asobu" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あそぶ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "遊ぶ [あすぶ], あすぶ [Obsolete], 遊ぶ [あそぶ]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To play (Games, sports), To hang out, To have a good time, To meet up"}},

                {"asoko", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "asoko" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あそこ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "彼処 [あそこ], 彼処 [かしこ], 彼所 [あそこ] (Rarely used with Kanji), あそこ" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Over there, There, That place" +
                 "\n -- A place far from both the speaker and the listener" +
                 "\n 2. That far, That much, That point (Usually written with kana only)"}},

                {"atama", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "atama" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あたま" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "頭 [かしら], 頭 [あたま] (Standard)" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Head, Top" +
                 "\n -- The upper part of any body."}},

                {"atarashii", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "atarashii" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あたらしい" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "新らしい [あたらしい], 新しい [あたらしい]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. New, Novel, Fresh, Recent, Latest"}},

                {"atatakai", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "atatakai" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あたたかい" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "暖かい [あたたかい], 温かい [あたたかい], 温かい [あったかい]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Warm, mild, (pleasantly) hot" +
                 "\n -- Of or at a fairly or comfortably high temperature." +
                 "\n 2. Considerate, Kind, Genial"}},

                {"ato", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "ato" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あと" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "後 [あと]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Behind, rear (position)" +
                 "\n \n 2. After, Later, More(e.g minutes), left (Time)"}},

                {"atsui", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "atsui" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あつい" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "暑い [あつい], 熱い [あつい], 厚い [あつい]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [厚い] Thick, Deep, Heavy" +
                 "\n -- Density level" +
                 "\n 2. [熱い] Hot (to the touch), passionate, Hot (topic)" +
                 "\n \n 3. Hot, Warm, Heated (Temperature)"}},

                {"au", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "au" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "あう" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "逢う [あい], 遭う [あう], 遇う [あう], 会う [あう] (Standard Kanji Form)" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To meet, To encounter, To see, To have an accident" +
                 "\n -- To meet something (Like an accident) or someone"}},

                {"bangohan", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "ban gohan" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "ばんごはん" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "晩御飯 [ばんごはん], 晩ご飯 [ばんごはん], ばんごはん" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Dinner, evening meal" +
                 "\n -- The last meal of the day"}},

                {"bangou", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "bangoo" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "ばんごう" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "番号 [ばんごう]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. a number"}},

                {"basu", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "basu | bas" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "ばす" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "バス [ばす]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [From English] Bus" +
                 "\n -- Big and (not necessarily) large car that is used to transport people from one place to another "}},

                {"bataa", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "bataa" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "ばたあ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "バター [ばたー]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [From English] Butter"}},

                {"beddo", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Beddo" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "べっど" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "ベッド [べっど]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [From English] Bed" +
                 "\n -- Thing one uses to sleep into, usually, this word is used for big beds and not floor beds (futons)."}},

                {"benri", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "ben ri" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "べんり" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "便利 [べんり]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [な-Adjective] Convenient, Handy, Useful" +
                 "\n -- Something one can use to take advantage of or to help in the current situation."}},

                {"boorupen", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "booru pen" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "ぼおるぺん" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "ボールペン [ぼーるぺん]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [From English] Pen, Ball-point pen"}},

                {"botan", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Botan" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "ぼたん" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "ボタン [ぼたん]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [From English] Button"}},

                {"boushi", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "booshi" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "ぼうし" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "帽子 [ぼうし] (Usually written in Kana only), ぼうし" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Hat, Cap"}},

                {"butaniku", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Buta niku" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "ぶたにく" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "ぶた肉 [ぶたにく], 豚肉 [とんにく], 豚肉 [ぶたにく]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Pork (meat)"}},

                {"byouin", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Byoo in" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "びょういん" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "病院 [びょういん]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Hospital, Health Center" +
                 "\n -- Place where sick people usually go."}},

                {"byouki", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "byoo ki" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "びょうき" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "病気 [びょうき]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Illness, disease, sickness"}},

                {"chairo", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Cha iro" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "ちゃいろ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "茶色 [ちゃいろ]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Brown" +
                 "\n -- Combination of the colors red and green, yellow and purple or blue and orange"}},

                {"chawan", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Cha wan" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "ちゃわん" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "茶碗 [ちゃわん]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Rice bowl, Tea cup, Teacup"}},

                {"chichi", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Chichi" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "ちち" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "父 [ちゃん] [Obsolete kanji usage], 父 [ちち]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Father" +
                 "\n -- Your paternal guardian"}},

                {"chigau", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Chiga u" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "ちがう" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "違う [ちがう]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To differ, To not be the way someone say, To be wrong, incorrect or mistaken" +
                 "\n \n 2. Isn't it?, Wasn't it? (Kansai dialect)"}},

                {"chiisai", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Chii sai" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "ちいさい" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "ちいさい, 小さい [ちいさい]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [い-Adjective] Small, Little, Tiny" +
                 "\n -- Not big"}},

                {"chiisana", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Chii sa na" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "ちいさな" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "ちいさな, 小さな [ちいさな]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [な-Adjective] [Pre-noun adjectival] Small, Little, Tiny" +
                 "\n -- Not big"}},

                {"chikai", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Chikai" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "ちかい" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "ちかい, 近い [ちかい]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Near, Close"}},

                {"chikatetsu", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "chikate tsu" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "ちかてつ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "ちかてつ, 地下鉄 [ちかてつ]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Subway, Metro, Underground railway" +
                 "\n -- A place where people go to go into a train and be transported to another (marked) place"}},

                {"chizu", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Chizu" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "ちず" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "地図 [ちず]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Map, Atlas, Chart" +
                 "\n -- Piece of paper use for orientation"}},

                {"chotto", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Chotto" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "ちょっと" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "一寸 [ちょっと] (Rarely kanji usage), ちょっと" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. A little" +
                 "\n \n 2. Wait!" +
                 "\n -- Abbreviation of ちょっと待って"}},

                {"choudo", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "choodo" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "ちょうど" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "丁度 [ちょうど], ちょうど" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1.Exactly, Precisely, Just, Right" +
                 "\n -- The point something usually prefer or is looking for at some moment."}},

                {"daidokoro", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Dai dokoro" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "だいどころ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "台所 [だいどころ]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Kitchen" +
                 "\n -- Place where food is made and (in some places) also is eaten."}},

                {"daigaku", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Dai gaku" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "だいがく" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "大学 [だいがく]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. University, College"}},

                {"daijoubu", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "Dai jou bu" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "だいじょうぶ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "だいじょうぶ, 大丈夫 [だいじょうぶ]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Okay, Good, OK, Alright, Problem free"}},

                {"daisuki", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Dai suki | Dai ski" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "だいすき" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "大好き [だいすき]" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. To love, To like, To like very much, To Adore"

                }},
                {"dandan", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Dan dan" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "だんだん" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "段々 [だんだん], 段段 [だんだん], だんだん" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Gradually, By degrees, Little by little, More and more, Increasingly" +
                "\n \n 2. [Onomatopeia] Steps, Stairs"
                }},

                {"dare", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Dare" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "だれ" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "誰 [だあれ], 誰 [たれ] (Obsolete), 誰 [た] (Obsolete), 誰 [だれ] (Standard)" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Who"
                }},

                {"dareka", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "dare ka" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "だれか" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "誰か [だれか]" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Someone, Somebody"
                }},

                {"dasu", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Dasu" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "だす" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "出す [だす]" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. To take out, To get out, To put out, To reveal, To show, To submit, To publish, To send" +
                "\n \n 2. To produce (a sound), To let a sound escape" +
                "\n \n 3. To start... (doing something suddenly), To begin... (doing something suddenly)"
                }},

                {"deguchi", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "de guchi" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "でぐち" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "出口 [でぐち]" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Exit, Gateway, Way out" +
                "\n \n 2. Outlet, Vent, Leak"
                }},

                {"dekakeru", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Dekakeru" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "でかける" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "出かける [でかける]" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. To depart, To go out (e.g on an excursion or outing), To leave"
                }},

                {"denki", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Den ki" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "でんき" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "電気 [でんき]" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Electricity" +
                "\n \n 2. (Electric) Light" +
                "\n \n 3. (As a science) Electricity"
                }},

                {"densha", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Densha" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "でんしゃ" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "電車 [でんしゃ]" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Train, Electric train"
                }},

                {"denwa", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Denwa" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "でんわ" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "電話 [でんわ]" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Telephone call, Phone call" +
                "\n \n 2. Telephone (device), Phone" +
                "\n \n 3. (In telecommunications) Telephony"
                }},

                {"depaato", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Depaato" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "でぱーと" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "デパート [でぱーと］" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Department Store"
                }},

                {"deru", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "deru" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "でる" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "出る [でる]" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. To exit, To leave, To go out,"
                }},

                {"doa", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Doa" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "どあ" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "ドアー [どあー], ドア [どあ]" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. [From English] Door (Western-style, car, etc)"
                }},

                {"docchi", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Docchi" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "どっち" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "何方 [どっち] (Rarely used with Kanji), どっち (Standard)" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Which, Which one"
                }},

                {"dochira", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Do chira" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "どちら" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "何方 [どちら] (Rarely used with Kanji), どちら (Standard)" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Which one (of two), Which way, Which direction"
                }},

                {"doko", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "doko" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "どこ" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "何処 [どこ], どこ (Standard)" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Where, What place"
                }},

                {"donata", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Donata" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "どなた" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "何方 [どなた], どなた (Standard)" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Who (Polite)"
                }},

                {"dono", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Dono" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "どの" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "何の [どの] (Rarely used with Kanji), どの (Standard)" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Which (of two or more things of the same name, like for example a car)"
                }},
                {"dore", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Dore" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "どれ" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "何れ [どれ] (Rarely used with Kanji), どれ (Standard)" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Which (of three or more things)" +
                "\n \n 2. Let's see... (When used two times [どれどれ])"
                }},

                {"dou", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Doo" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "どう" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "如何 [どう] (Rarely used Kanji form), どう (Standard)" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. How, In what way, How about"
                }},

                {"doubutsu", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Doo butsu" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "どうぶつ" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "動物 [どうぶつ]" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Animal"
                }},

                {"doumo", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Doomo" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "どうも" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "どうも (Standard)" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Thanks, Thank you" +
                "\n \n 2. Much (Thanks), Very (Sorry), Quite (Regret)" +
                "\n \n 3. Greetings, Hello, Goodbye"
                }},

                {"douzo", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Doozo" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "どうぞ" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "どうぞ" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Please (Go ahead), Go ahead"
                }},

                {"doyoubi", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Doyoobi" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "どようび" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "土曜日 [どようび]" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Saturday"
                }},

                {"e", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "E" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "え" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "画 [え], 画 [が], 絵 [え] (Standard)" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Picture, Drawing, Painting, Sketch" +
                "\n \n 2. Image (TV, film, etc), Picture, Footage"
                }},

                {"ee", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "EE" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "ええ" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "ええ" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Yes, Affirmative, That is correct, Right"
                }},

                {"eiga", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Eega" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "えいが" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "映画 [えいが]" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Movie, Film, Motion picture"
                }},

                {"eigakan", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Eega kan" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "えいがかん" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "映画館 [えいがかん]" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Movie theater, Cinema"
                }},

                {"eigo", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Eego" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "えいご" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "英語 [えいご]" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. English (Language)"
                }},

                {"eki", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Eki" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "えき" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "驛 [えき], 駅 [えき]" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Railway station, Train station" +
                "\n \n 2. Counter for railway stations and bus stations"
                }},

                {"enpitsu", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Enpitsu" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "えんぴつ" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "エンピツ [えんぴつ], 鉛筆 [えんぴつ]" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Pencil"
                }},

                {"erebeetaa", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[5] +
               MT.dictionaryInformation2[languagueSettingsUpdater] + "Erebee taa" +
               MT.dictionaryInformation3[languagueSettingsUpdater] + "えれべーたー" +
               MT.dictionaryInformation4[languagueSettingsUpdater] + "エレベーター [えれべーたー]" +
               MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. [From English] Elevator, lift"
                }},

                {"firumu", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "firumu" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ふぃるむ" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "フィルム" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Film"}},

                {"fooku", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "fooku" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ふぉーく" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "フォーク" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Fork"}},

                {"fuku", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "fuku" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ふく" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [服] Clothes" +
                 "\n 2. [吹く] To blow (of the wind)"}},

                {"furu", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "furu" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ふる" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "降る [ふる]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To rain, To fall (from the sky)"}},

                {"furui", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "furui" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ふるい" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "古い [ふるい]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Old (for things)"}},

                {"futari", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "futari" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ふたり" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "二人 [ふたり]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Two people, Together (with you)"}},

                {"futatsu", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "futatsu" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ふたつ" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "二つ [ふたつ]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Two (things)"}},

                {"futoi", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "futoi" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ふとい" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "太い [ふとい]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Thick, Fat"}},

                {"futsuka", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "futsuka" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ふつか" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "二日 [ふつか]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Two days, The second day of the month"}},

                {"fuutou", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "fuutou" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ふうとう" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "封筒 [ふうとう]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Envelope"}},

                {"fuyu", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "fuyu" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ふゆ" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "冬 [ふゆ]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Winter"}},

                {"gaikoku", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "gaikoku" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "がいこく" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "外国 [がいこく]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Foreign Country"}},

                {"gaikokujin", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "gaikokujin" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "がいこくじん" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "外国人 [がいこくじん]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Foreigner, Foreign citizen, Foreign national, Non-Japanese person"}},

                {"gakkou", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "gakkou" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "がっこう" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "学校 [がっくう]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. School"}},

                {"gakusei", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "gakusei" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "がくせい" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "学生 [がくせい]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Student"}},

                {"genkan", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "genkan" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "げんかん" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "玄関 [げんかん]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Entrance"}},

                {"genki", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "genki" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "げんき" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "元気 [げんき]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Lively, full of spirit, energetic, healthy"}},

                {"getsuyoubi", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "getsuyoubi" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "げつようび" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "月曜日 [げつようび]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Monday, The day of the moon"}},

                {"ginkou", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "ginkou" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ぎんこう" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "銀行 [ぎんこう]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Bank"}},

                {"gitaa", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "gita-" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ぎたー" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "ギター [ぎたー]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Guitar"}},

                {"gita", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "gita-" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ぎたー" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "ギター [ぎたー]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Guitar"}},

                {"go", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "go" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ご" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "五 [ご]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Five, Number five"}},

                {"gogo", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "gogo" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ごご" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "午後 [ごご]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Afternoon, P.M"}},

                {"gohan", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "gohan" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ごはん" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "ご飯 [ごはん]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Rice, Lunch"}},

                {"gozen", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "gozen" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ごぜん" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "午前 [ごぜん]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Morning, A.M"}},

                {"guramu", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "guramu" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ぐらむ" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "グラム [ぐらむ]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. A gram"}},

                {"gyuuniku", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "gyuuniku" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ぎゅうにく" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "牛肉 [ぎゅうにく]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Cow meat, Beef"}},

                {"gyuunyuu", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "gyuunyuu" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ぎゅうにゅう" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "牛乳 [ぎゅうにゅう]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. (Cow's) Milk"}},

                {"ha", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "ha" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "は" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "歯 [は]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Tooth"}},

                {"hachi", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hachi" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はち" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "八 [はち]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Eight, Number eight"}},

                {"hagaki", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hagaki" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はがき" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "葉書 [はがき]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Podcast"}},

                {"haha", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "haha" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はは" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "母 [はは]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Mother"}},

                {"hai", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hai" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はい" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Yes, That is correct"}},

                {"hairu", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hairu" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はいる" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "入る [はいる], 入る [いる]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To enter, To go in"}},

                {"haizara", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "haizara" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はいざら" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "灰皿 [はいざら]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Ashtray"}},

                {"hajimaru", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hajimaru" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はじまる" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "始まる [はじまる]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To begin, To start"}},

                {"hajimete", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hajimete" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はじめて" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "初めて [はじめて]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. For the first time"}},

                {"hako", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hako" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はこ" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "箱 [はこ]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Box, Crate"}},

                {"haku", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "haku" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はく" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "履く [はく]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To wear, To put on trousers"}},

                {"han", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "han" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はん" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "半 [はん]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Half, Semi-, Half-past"}},

                {"hana", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hana" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はな" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [花] Flower" +
                 "\n 2. [鼻] Nose"}},

                {"hanashi", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hana" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はな" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "話 [はなし]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Conversation, Talk, Speech, Chat"}},

                {"hanasu", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hana" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はな" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "話す [はなす]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To talk, To speak, To convense"}},

                {"hanbun", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hanbun" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はんぶん" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "半分 [はんぶん]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Half"}},

                {"hankachi", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hankachi" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はんかち" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "ハンカチ [はんかち]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Handkerchief"}},

                {"hare", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hare" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はれ" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "晴れ [はれ]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Clear weather, Sunny"}},

                {"hareru", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hareru" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はれる" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "晴れる [はれる]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To be sunny"}},

                {"haru", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "haru" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はる" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [貼る] To stick, To paste" +
                 "\n 2. [春] Spring, Springtime"}},

                {"hashi", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hashi" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はし" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [箸] Chopsticks" +
                 "\n 2. [橋] Bridge"}},

                {"hashiru", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hashiru" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はしる" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "走る [はしる]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To run"}},

                {"hatachi", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hatachi" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はたち" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "二十歳 [はたち]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. 20 years old, Twenty years old"}},

                {"hataraku", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hataraku" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はたらく" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "働く [はたらく]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To work"}},

                {"hatsuka", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hatsuka" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はつか" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "二十日 [はつか]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Twentieth day of the month, 20 days"}},

                {"hayai", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hayai" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "はやい" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [早い] Fast, Early" +
                 "\n 2. [速い] Fast, Quick, Hasty, Brisk"}},

                {"hen", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hen" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "へん" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [辺] Area" +
                 "\n 2. [変] Strange, Weird, Odd"}},

                {"heta", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "heta" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "へた" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "下手 [下手]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Unskillful, Poor (in skills), awkwark"}},

                {"heya", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "heya" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "へや" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "部屋 [へや]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Room"}},

                {"hidari", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hidari" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ひだり" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "左 [ひだり]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Left, Left hand side"}},

                {"higashi", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "higashi" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ひがし" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "東 [ひがし]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. East"}},

                {"hikouki", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hikouki" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ひこうき" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "飛行機 [ひこうき]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Airplane, Aircraft"}},

                {"hiku", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hiku" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ひく" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [引く] To pull" +
                 "\n 2. [弾く] To play (an instrument)"}},

                {"hikui", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hikui" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ひくい" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "低い [ひくい]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Short, Low"}},

                {"hima", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hima" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ひま" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "暇 [ひま]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Free time"}},

                {"hiroi", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hiroi" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ひろい" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "広い [ひろい]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Spacious, Vast, Wide"}},

                {"hiru", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hiru" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ひる" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "昼 [ひる]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Noon, Midday, Daytime, Lunch"}},

                {"hirugohan", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hirugohan" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ひるごはん" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "昼ご飯 [ひるごはん]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Lunch"}},

                {"hito", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hito" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ひと" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "人 [ひと]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Person, Human"}},

                {"hitori", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hitori" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ひとり" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "一人 [ひとり]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. One person, Alone, Single"}},

                {"hitotsu", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hitotsu" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ひとつ" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "一つ [ひとつ]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. One thing, Only (one thing)"}},

                {"hoka", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hoka" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ほか" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "他 [ほか]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Other (place, thing, person), The rest"}},

                {"hon", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hon" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ほん" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "本 [ほん]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Book, Volume, Script"}},

                {"hondana", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hondana" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ほんだな" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "本棚 [ほんだな]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Bookshelf, Bookcase"}},

                {"hontou", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hontou" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ほんとう" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "本当 [ほんとう]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Truth, Reality, Actuality, Fact" +
                 "\n 2. Really, Not lying"}},

                {"hoshii", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hoshii" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ほしい" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "欲しい [ほしい]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Want"}},

                {"hosoi", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hosoi" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ほそい" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "細い [ほそい]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Thin, Slender"}},

                {"hoteru", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hoteru" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ほてる" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "ホテル [ほてる]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Hotel"}},

                {"hyaku", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "hyaku" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "ひゃく" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "百 [ひゃく]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. 100, Hundred"}},

                {"ichi", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "ichi" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いち" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "一 [いち]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. One, Number one, Best, Foremost"}},

                {"ichiban", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "ichiban" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いちばん" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "一番 [いちばん]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Number one, First, 1st, First Place, Best, Most"}},

                {"ichinichi", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "ichinichi" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いちにち" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "一日 [いちにち], 一日 [ついたち]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. One day, all day" +
                 "\n 2. The first day of the month"}},

                {"tsuitachi", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "ichinichi" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いちにち" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "一日 [いちにち], 一日 [ついたち]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. One day, all day" +
                 "\n 2. The first day of the month"}},

                {"ie", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "ie" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いえ" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "家 [いえ]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. House, Residence, Family"}},

                {"ikaga", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "ikaga" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いかが" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. How, In what day, How about"}},

                {"ike", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "ike" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いけ" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "池 [いけ]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Pond"}},

                {"iku", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "iku" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いく" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "行く [いく], 行く [やく]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To go, To move"}},

                {"ikura", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "ikura" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いくら" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. How much?, How many?"}},

                {"ikutsu", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "ikutsu" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いくつ" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. How many?, How old?"}},

                {"ima", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "ima" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いま" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "今 [いま]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Now, The present time"}},

                {"imi", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "imi" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いみ" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "意味 [いみ]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Meaning, Significance, Sense"}},

                {"imouto", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "imouto" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いもうと" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "妹 [いもうと]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Younger Sister"}},

                {"inu", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "inu" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いぬ" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "犬 [いぬ]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Dog"}},

                {"ireru", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "ireru" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いれる" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "入れる [いれる]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. To put in, To let in, To take in, To bring in, To insert, To install"}},

                {"iriguchi", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "iriguchi" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いりぐち" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "入口 [いりぐち]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Entrance, Entry, Gate"}},

                {"iro", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "iro" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いろ" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "色 [いろ]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Colour, Color"}},

                {"iroiro", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "iroiro" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いろいろ" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "色々 [いろいろ]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. Various"}},

                {"iru", new List<string>{
                 MT.dictionaryInformation1[languagueSettingsUpdater] + jlptLevel[3] +
                 MT.dictionaryInformation2[languagueSettingsUpdater] + "iru" +
                 MT.dictionaryInformation3[languagueSettingsUpdater] + "いる" +
                 MT.dictionaryInformation4[languagueSettingsUpdater] + "いる, 居る [いる]" +
                 MT.dictionaryInformation5[languagueSettingsUpdater] +
                 "\n 1. [居る] To be (Animated things), To have" +
                 "\n \n 2. [要る] To be needed, To be necessary, To be required, To be wanted, To need, To want"}},

                {"isha", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "isha" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "いしゃ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "お医者さん [おいしゃさん] (Polite), 医者 [いしゃ]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Doctor, Physician"}},

                {"isogashii", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "isogashii" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "いそがしい" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "忙がしい [いそがしい］(Irregular), 忙しい [いそがしい]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Busy, Occupied, Hectic" +
                "\n \n 2. Restless, Hurried, Fidgety"}},

                {"issho", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "issho" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "いっしょ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "一緒 [いっしょ]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. (Doing something) Together" +
                "\n \n 2. (at) The same time"}},

                {"isu", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "isu" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "いす" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "倚子 [いす] (Rarely used kanji form), イス [いす], 椅子 [いす]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Chair, Seat, Stool, Bench" +
                "\n \n 2. Position, Seat, Office"}},

                {"itai", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "itai" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "いたい" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "甚い [いたい] (Rarely used kanji form), いたい (kana only), 痛い [いたい]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Painful, Sore" +
                "\n \n 2. (Colloquial) Cringy, Embarrassing"}},

                {"itsu", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "itsu" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "いつ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "何時 [いつ] (rarely used kanji form, usually written using kana alone)" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. When, At what time, How soon"}},

                {"itsuka", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "itsuka" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "いつか" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "5日 [ごにち] (Irregular kana usage, 5 can be replaced with 五), 五日 [いつか] (Standard form)" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. 5th day of the month" +
                "\n \n 2. Five days"}},

                {"itsutsu", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "itsutsu" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "いつつ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "五つ" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. 5 (things)"}},

                {"iu", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "iu" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "いう" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "言う [いう], 言う [ゆう], 云う [いう], 云う [ゆう], 謂う [いう], 謂う [ゆう]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. To say, To utter, To declare" +
                "\n \n 2. To name, To call (someone or something by its name)" +
                "\n \n 3. To make a noise"}},

                {"iya", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "iya" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "いや" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Disliking, Not Wanting, Unwilling (to do), Reluctant, To not like"}},

                {"jaa", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "jaa" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "じゃあ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "じゃ" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Then, Well, So, Well then"}},

                {"jibiki", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "jibiki" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "じびき" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "字引き [じびき]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Dictionary (Not very common nowadays, but still used in phrases like '生き字引'.)"}},

                {"jibun", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "jibun" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "じぶん" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Myself, Yourself, Oneself, Himself, Herself" +
                "\n \n 2. I, Me" +
                "\n \n 3. (Kansai dialect) You"}},

                {"jidousha", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "jidousha" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "じどうしゃ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Automobile, Car, Motorcar, Motor Vehicle, Auto"}},

                {"jikan", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "jikan" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "じかん" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Time" +
                "\n \n 2. Hour" +
                "\n \n 3. Period, Class, Lesson"}},

                {"jisho", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "jisho" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "じしょ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Dictionary, Lexicon"}},

                {"jitensha", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "jitensha" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "じてんしゃ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "自転車 [じでんしゃ]" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Bicycle, Bike"}},

                {"joubu", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "joubu" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "じょうぶ" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Healthy, Robust, Strong, Solid, Durable"}},

                {"jouzu", new List<string>{
                MT.dictionaryInformation1[languagueSettingsUpdater] + "N5" +
                MT.dictionaryInformation2[languagueSettingsUpdater] + "jouzu" +
                MT.dictionaryInformation3[languagueSettingsUpdater] + "じょうず" +
                MT.dictionaryInformation4[languagueSettingsUpdater] + "" +
                MT.dictionaryInformation5[languagueSettingsUpdater] +
                "\n 1. Skillful, Skilled, Proficient, Good (at something), Adept, Clever"}},



            };

        }

    }
}
