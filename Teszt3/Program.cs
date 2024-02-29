using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test3;

namespace Test3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyRandom.lang = "en";
            MyRandom.langChange(MyRandom.lang);

            Console.WriteLine("\tRandomNumber");
            Console.WriteLine("Random egész szám: {0}", MyRandom.RandomInt());
            Console.WriteLine("Random nem egész szám: {0}", MyRandom.RandomDouble());
            Console.WriteLine("\n");
            Console.WriteLine("Random egész szám, két szám között: {0}", MyRandom.RandomInt(1,5));
            Console.WriteLine("Random nem egész szám két szám között: {0}",MyRandom.RandomDouble(1,3.5));
            Console.WriteLine("\n");
            Console.WriteLine("Random egész számokból álló lista: {0}",string.Join(", " ,MyRandom.RandomInt(5)));
            Console.WriteLine("Random nem egész számokból álló lista: {0}",string.Join(", ", MyRandom.RandomDouble(5)));
            Console.WriteLine("\n");
            Console.WriteLine("Random egész számokból álló lista, két szám között generálja a számokat: {0}",string.Join(", ",MyRandom.RandomInt(5, 1,4)));
            Console.WriteLine("Random nem egész számokból álló lista, két szám között generálja a számokat: {0}",string.Join(", ",MyRandom.RandomDouble(5, 1,2.5)));
            Console.WriteLine("\n");
            Console.WriteLine("Random egész számokból álló lista, két szám között generálja a számokat, nem ismétlődhetnek az elemek: {0}",string.Join(", ",MyRandom.RandomInt(5, 1,5, true)));
            Console.WriteLine("\n\tTextRandom");
            Console.WriteLine("Random szó: {0}",MyRandom.RandomWord());
            Console.WriteLine("Random szó lista: {0}", string.Join(", " ,MyRandom.RandomWord(5,false)));
            Console.WriteLine("Random mondat: {0}", MyRandom.RandomSentence(5));
            Console.WriteLine("Random bekezdés: \n{0}",MyRandom.RandomParagraph(3,5));



            Console.ReadLine();
        }
    }
}
