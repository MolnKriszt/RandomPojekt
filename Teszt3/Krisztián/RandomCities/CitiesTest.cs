using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    internal class CitiesTest
    {
        internal void Test()
        {
            var asd = MyRandom.RandomCity(10);
            foreach (var item in asd)
            {
                Console.WriteLine(item);
            }
        }
    }
}
