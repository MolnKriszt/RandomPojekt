using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    internal class NumberTest
    {
        internal void Test()
        {
            var asked = MyRandom.RandomDouble(10, true);

            foreach (var item in asked)
            {
                Console.WriteLine(item);
            }
        }
    }
}
