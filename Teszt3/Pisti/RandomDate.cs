using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    static internal partial class MyRandom
    {
        static public void RandomDate()
        {
            DateTime randomDate = GenerateRandomDate();

            Console.WriteLine("Random date: ", randomDate.ToString("yyyy-MM-dd"));

        }

        private static DateTime GenerateRandomDate()
        {
            DateTime start = DateTime(2000, 1, 1);
            DateTime end = DateTime.Now;
            Random random = new Random();
            int randomDays = random.Next((end - start).Days + 1);
            DateTime randomDate = start.AddDays(randomDays);

            return randomDate;
        }
    }
}
