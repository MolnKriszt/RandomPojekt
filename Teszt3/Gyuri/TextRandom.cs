using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teszt3;

namespace Test3
{
    static internal partial class MyRandom 

    {
        internal static string[] wordList;
         static MyRandom()
        {
           langChange(lang);
        }

        internal static void langChange(string plang) {
            lang = plang;
            beolvasGyuri();
            beolvasKrisztian();
        }

        private static void beolvasKrisztian()
        {
            throw new NotImplementedException();
        }

        private static void beolvasGyuri()
        {
            if (lang == "en")
            {
                wordList = File.ReadAllLines("word.txt");
            }
            else if (lang == "hu")
            {
                wordList = File.ReadAllLines("word.txt");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        static public void randomText()
        {
            Console.WriteLine("RandomText");

            int maxWords = 10;


            string[] wordList = ReadWordListFromFile("word.txt", maxWords);

            if (wordList.Length > 0)
            {
                Console.WriteLine("Szólista:  " + string.Join(", ", wordList));
            }
        }

        static string[] ReadWordListFromFile(string word,int maxWords)
        {
            string[] sorok = File.ReadAllLines(word);

            var words = new List<string>();

            var random = new Random();
            sorok = sorok.OrderBy(x => random.Next()).ToArray();

            for (int i = 0; i < sorok.Length && i < maxWords; i++)
            {
                words.Add(sorok[i]);
            }
           
            return words.ToArray();
        }
    }   
}
