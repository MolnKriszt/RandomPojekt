using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
            TextReading();
            
        }



        public static void TextReading()
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


        static public void RandomWord(int wordCount)
        {
            Console.WriteLine("RandomText");

           


            string[] wordList = ReadWordListFromFile("word.txt", wordCount);

            if (wordList.Length > 0)
            {
                Console.WriteLine("Szólista:  " + string.Join(", ", wordList));
            }
        }

        static string[] ReadWordListFromFile(string word,int wordCount)
        {
            string[] sorok = File.ReadAllLines(word);

            var words = new List<string>();

            var random = new Random();
            sorok = sorok.OrderBy(x => random.Next()).ToArray();

            for (int i = 0; i < sorok.Length && i < wordCount; i++)
            {
                words.Add(sorok[i]);
            }
           
            return words.ToArray();
        }

         
    }   
}
