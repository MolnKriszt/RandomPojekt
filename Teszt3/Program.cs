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
            Console.ForegroundColor = ConsoleColor.Yellow;


            Console.WriteLine("Angol:");
            MyRandom.lang = "en";
            MyRandom.langChange(MyRandom.lang);
            Console.WriteLine(MyRandom.RandomWord());

            Console.WriteLine("Magyar:");
            MyRandom.lang = "hu";
            MyRandom.langChange(MyRandom.lang);
            Console.WriteLine(MyRandom.RandomWord());

            

            //MyRandom.lang = "hu";
            //MyRandom.langChange(MyRandom.lang);
            //Console.WriteLine("\tRandomNumber");
            //Console.WriteLine("Random egész szám: {0}", MyRandom.RandomInt());
            //Console.WriteLine("Random nem egész szám: {0}", MyRandom.RandomDouble());
            //Console.WriteLine("\n");
            //Console.WriteLine("Random egész szám, két szám között: {0}", MyRandom.RandomInt(1, 5));
            //Console.WriteLine("Random nem egész szám két szám között: {0}", MyRandom.RandomDouble(1, 3.5));
            //Console.WriteLine("\n");
            //Console.WriteLine("Random egész számokból álló lista: {0}", string.Join(", ", MyRandom.RandomInt(5)));
            //Console.WriteLine("Random nem egész számokból álló lista: {0}", string.Join(", ", MyRandom.RandomDouble(5)));
            //Console.WriteLine("\n");
            //Console.WriteLine("Random egész számokból álló lista, két szám között generálja a számokat: {0}", string.Join(", ", MyRandom.RandomInt(5, 1, 4)));
            //Console.WriteLine("Random nem egész számokból álló lista, két szám között generálja a számokat: {0}", string.Join(", ", MyRandom.RandomDouble(5, 1, 2.5)));
            //Console.WriteLine("\n");
            //Console.WriteLine("Random egész számokból álló lista, két szám között generálja a számokat, nem ismétlődhetnek az elemek: {0}", string.Join(", ", MyRandom.RandomInt(5, 1, 5, true)));
            //Console.WriteLine("\n\tTextRandom");
            //Console.WriteLine("Random szó: {0}", MyRandom.RandomWord());
            //Console.WriteLine("\n");
            //Console.WriteLine("Random szó lista: {0}", string.Join(", ", MyRandom.RandomWord(5, false)));
            //Console.WriteLine("\n");
            //Console.WriteLine("Random mondat: {0}", MyRandom.RandomSentence(5));
            //Console.WriteLine("\n");
            //Console.WriteLine("Random bekezdés: \n{0}", MyRandom.RandomParagraph(3, 5));
            //Console.WriteLine("\n\tRandomCities");
            //Console.WriteLine("Random város: {0}", MyRandom.RandomCity());
            //Console.WriteLine("\n");
            //Console.WriteLine("Random város lista: {0}", string.Join(", ", MyRandom.RandomCity(5)));
            //Console.WriteLine("\n\tRandomFood");
            //Console.WriteLine("Random étel/ital: {0}", MyRandom.RandomFood());
            //Console.WriteLine("\n");
            //Console.WriteLine("Random konkrét fajta étel/ital: {0}", MyRandom.RandomFood(2));
            //Console.WriteLine("\n\tRandomName");
            //Console.WriteLine("Random név: {0}", MyRandom.RandomName());
            //Console.WriteLine("\n");
            //Console.WriteLine("Random név: {0} , {1}", MyRandom.RandomName("f"), MyRandom.RandomName("m"));
            //Console.WriteLine("\n");
            //Console.WriteLine("Random név lista: {0}", string.Join(", ", MyRandom.RandomName(5)));
            //Console.WriteLine("\n");
            //Console.WriteLine("Random név lista: {0}", string.Join(", ", MyRandom.RandomName(5, true)));
            //Console.WriteLine("\n");
            //Console.WriteLine("Random név lista: {0}", string.Join(", ", MyRandom.RandomName(5, "f", true)));
            //Console.WriteLine("\n\tRandomDate");
            //Console.WriteLine("Random dátum: {0}", MyRandom.RandomDate());
            //Console.WriteLine("\n");
            //Console.WriteLine("Random dátum konkrét év: {0}", MyRandom.RandomDate(2000));
            //Console.WriteLine("\n");
            //Console.WriteLine("Random dátum két év vagy hónap között: {0}", MyRandom.RandomDate(2000, 2002, false));



            Console.ReadLine();
        }
    }
}
