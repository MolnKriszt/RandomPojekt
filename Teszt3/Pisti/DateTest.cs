using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    internal class DateTest
    {


        internal void Test()
        {

            Console.WriteLine("Generált dátum:" + MyRandom.RandomDate( 3, 1, true).ToString("yyyy-MM-dd"));
            Random random = new Random();
            Console.WriteLine(random.Next(5,3));
        }
    }
}
