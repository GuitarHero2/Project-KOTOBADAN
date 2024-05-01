using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotoba_Project
{
    internal class EnglishDictionary : JLPTClass
    {
        public Dictionary<string, List<string>> englishJisho;

        public EnglishDictionary()
        {
            Initialize();
        }
        public void Initialize()
        {
            englishJisho = new Dictionary<string, List<string>>()
            {
                {"hello", new List<string>{
                 "\n \n Translation: " +
                 "\n 1. こんにちは, ハロー, ヤッホー, よ, やあ" +
                 "\n -- A way of greeting someone politely in the afternoon." +
                 "\n 2. もしもし" +
                 "\n -- A way to answer the phone." +
                 "\n 3. ハイダイ" +
                 "\n -- Femenine way of saying Hi"}},

                {"computer", new List<string>{
                 "\n \n Translation: " +
                 "\n 1.  コンピューター" +
                 "\n -- Multipurpose machine usually used for working, gaming and studying." +
                 "\n 2. パソコン" +
                 "\n -- A　personal computer, a laptop."}},
            };

        }
    }
}
