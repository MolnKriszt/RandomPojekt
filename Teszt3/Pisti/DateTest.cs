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


            int valami = 2000;

            Console.WriteLine($"Generált random dátum évvel {valami}: {MyRandom.RandomDateInYear(valami).ToString("yyyy-MM-dd")}");


        }
    }
}
