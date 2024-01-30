using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    internal class DateTest
    {
        private DateTime requestedDate;
        private object year;

        internal void Test()
        {


            DateTime randomDate = requestedDate;

            Console.WriteLine($"Generált random dátum évvel {year}: {randomDate.ToString("yyyy-MM-dd")}");


        }
    }
}
