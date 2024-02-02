using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
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
            NamesReading();
            CityReading();

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

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        static public string RandomWord()
        {
            return wordList[random.Next(0, wordList.Length)];
        }
        /// <summary>
        /// ghgfhgfhgf
        /// </summary>
        /// <param name="wordCount"></param>
        /// <param name="Distinct"></param>
        /// <returns></returns>
        static public List<string> RandomWord(int wordCount, bool Distinct)
        {
            List<string> result = new List<string>();
            if (!Distinct)
            {
                for (int i = 0; i < wordCount; i++)
                {
                    result.Add(wordList[random.Next(0, wordList.Length)]);
                }
            }
            else
            {
                for (int i = 0; i < wordCount; i++)
                {
                    string generatedword = wordList[random.Next(0, wordList.Length)];
                    if (result.Contains(generatedword))
                    {
                        i--;
                    }
                    else
                    {
                        result.Add(generatedword);
                    }
                }
            }
            return result;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="wordCount"></param>
        /// <returns></returns>
        public static string RandomSentence(int wordCount)
        {
            string sentence = wordList[random.Next(0, wordList.Length)];

            for (int i = 1; i < wordCount; i++)
            {
                sentence += ", " + wordList[random.Next(0, wordList.Length)];
            }
            return sentence;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="SentenceCount"></param>
        /// <param name="WordperSentence"></param>
        /// <returns></returns>
        public static string RandomParagraph(int SentenceCount, int WordperSentence)
        {
            string paragraph = "";

            for (int i = 0; i < SentenceCount; i++)
            {
                string sentence = wordList[random.Next(0, wordList.Length)];

                for (int i2 = 1; i2 < WordperSentence; i2++)
                {
                    sentence += " " + wordList[random.Next(0, wordList.Length)];
                }
                paragraph += sentence + "\n";
            }
            return paragraph;
        }
    }
}
