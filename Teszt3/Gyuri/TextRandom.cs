﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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


        static public void RandomWord(int wordCount)
        {
            Console.WriteLine("RandomText");

            string[] szavak = ReadWordListFromFile(lang + "word.txt", wordCount);

            if (szavak.Length > 0)
            {
                Console.WriteLine("Szólista:  " + string.Join(", ", szavak));
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
