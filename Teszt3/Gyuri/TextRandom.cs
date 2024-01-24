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
