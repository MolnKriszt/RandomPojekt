using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace Test3
{
    static internal partial class MyRandom 

    {
        public static string[] wordList;

        
        static MyRandom()
        {
           langChange(lang);
        }

        internal static void langChange(string plang)
        {
            lang = plang;
            TextReading();
            FoodReading();


        }



        public static void TextReading()
        {
            if (lang == "en")
            {
                wordList = File.ReadAllLines("enword.txt");
            }
            else if (lang == "hu")
            {
                wordList = File.ReadAllLines("huword.txt");
            }
        }


        static public string RandomWord()
        {
            Random random = new Random();
            return wordList[random.Next(0,wordList.Length)];
        }

        static public List<string> RandomWord(int wordCount)
        {
            Random random = new Random();
            List<string> result = new List<string>();
            for (int i = 0; i < wordCount; i++)
            {
                result.Add(wordList[random.Next(0, wordList.Length)]);
            }
            return result;
        }



        public static string RandomSentence(int wordCount)
        {
            Random random = new Random();
            string sentence = wordList[random.Next(0, wordList.Length)];

            for (int i = 1 ; i < wordCount; i++)
            {
                sentence += " " + wordList[random.Next(0, wordList.Length)];
            }
            return sentence;
        }

        //public static void RandomParagraph(int sentenceCount, int wordsPerSentence)
        //{


        //    for (int i = 0; i < sentenceCount; i++)
        //    {
        //        RandomSentence(wordsPerSentence);
        //    }
        //}



    }
}
