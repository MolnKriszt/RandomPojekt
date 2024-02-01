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

            Console.WriteLine("Generált dátum:" + MyRandom.RandomDate( 4, 6, false).ToString("yyyy-MM-dd"));
        }
    }
}
