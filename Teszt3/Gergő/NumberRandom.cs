using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    static internal partial class MyRandom
    {
        static public void RandomNumber()
        {
            Random random = new Random();

            var randomNumbers = Enumerable.Range(1, 10)
                                          .Select(_ => random.Next(1, 101));

            Console.WriteLine("Véletlen számok:");
            foreach (var number in randomNumbers)
            {
                Console.Write(number + " ");
            }


            var randomDecimals = Enumerable.Range(1, 2)
                .Select(_ => random.NextDouble())
                .ToArray();

            Console.WriteLine("\nVéletlenszerű tizedes számok:");
            foreach (var number in randomDecimals)
            {
                Console.WriteLine(number.ToString("0.00"));
            }

            Console.ReadLine();
            
        }
    }
}
