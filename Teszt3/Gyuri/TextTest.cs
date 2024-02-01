using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    internal class TextTest
    {
        internal void Test()
        {



            //List<string> words = MyRandom.RandomWord(9,true);
            //foreach (string i in words)
            //{
            //    Console.WriteLine("{0}",i);
            //}


            int SentenceCount = 2;
            int WordperSentence = 7;
            Console.WriteLine(MyRandom.RandomParagraph(SentenceCount, WordperSentence));

        }
    }
}
