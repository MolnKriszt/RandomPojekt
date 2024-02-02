using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    internal class NameTest
    {
        internal void Test()
        {

            //Console.WriteLine($"Random surname: {MyRandom.RandomName(1,"f")}");
            int count = 1;
            foreach (var i in MyRandom.RandomName(16, true))
            {
                Console.WriteLine($"{count}    {i}");
                count++;
            }
        }
    }
}