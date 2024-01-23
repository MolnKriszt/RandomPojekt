using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    static internal partial class MyRandom

    {
        static Random random = new Random();
        static public void randomText()
        {
            Console.WriteLine("RandomText");

            int wordCount = 10;
            //int sentenceCount = 5;
            //int wordsPerSentenceMin = 3;
            //int wordsPerSentenceMax = 8;
            //int paragraphCount = 3;

            string randomWordList = GenerateRandomWordList(wordCount);
            //string randomSentence = GenerateRandomSentence(sentenceCount, wordsPerSentenceMin, wordsPerSentenceMax);
            //string randomParagraph = GenerateRandomParagraph(paragraphCount,sentenceCount,wordsPerSentenceMin,wordsPerSentenceMax);

            Console.WriteLine("Véletlen szólista: " + randomWordList);
            //Console.WriteLine("Véletlen mondat: " + randomSentence);
            //Console.WriteLine("Véletlen bekezdés: " + randomParagraph);
        }

        static string GenerateRandomWordList(int wordCount)
        {

            string[] wordList = {
                "a", "az", "és", "is", "nem", "olyan", "mint", "vagy", "de", "ha",
                "egy", "ez", "itt", "még", "most", "is", "el", "van", "hogy", "lesz",
                "legyen", "már", "minden", "akkor", "mindig", "volna", "lesz", "neki", "ő", "mi",
                "ti", "ők", "én", "te", "meg", "pedig", "majd", "csak", "sok", "hány",
                "szó", "mond", "jó", "jól", "se", "tehát", "ilyen", "arra", "rész", "miért",
                "itt", "ott", "most", "olyan", "kell", "két", "kicsit", "sokat", "nagyon", "nagy",
                "azért", "ezért", "szerint", "ezzel", "azzal", "ennek", "annak", "is", "isn't", "kellene",
                "kellett", "lehet", "lehetett", "legyen", "lett", "lesz", "leszünk", "leszel", "lehet", "nem",
                "nem", "volt", "vagyunk", "vagyok", "van", "volt", "volna", "volnék", "mind", "mindenki"
};
            string[] randomWords = new string[wordCount];

            for (int i = 0; i < wordCount; i++)
            {
                randomWords[i] = wordList[random.Next(wordList.Length)];
            }

            return string.Join(" ", randomWords);
        }
    }   
}
