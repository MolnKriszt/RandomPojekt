using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    static internal partial class MyRandom
    {

        public static DateTime RandomDate()
        {
            DateTime start = new DateTime(2000,1,1);
            DateTime end = DateTime.Now;
            Random random = new Random();
            int randomDays = random.Next((end - start).Days + 1);
            DateTime randomDate = start.AddDays(randomDays);

            return randomDate;
        }
        private static Random rand = new Random();


        public static DateTime RandomDateInYear(int requestedDate)
        {
            

            if (requestedDate >= DateTime.Now.Year)
            {
                throw new ArgumentException("RequestedDate cannot be greater than or equal to the current date.");
            }

            DateTime start = new DateTime(requestedDate, 1, 1);
            DateTime end = new DateTime(requestedDate, 12, 31);

            int range = (end - start).Days;


            int randomDays = rand.Next(range + 1);

            DateTime randomDate = start.AddDays(randomDays);

            return randomDate;


        }
    }
}
