using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    internal class FoodTest
    {
        internal void Test()
        {
            Console.WriteLine($"Random food: {MyRandom.RandomFood().Item2}");
        }
    }
}