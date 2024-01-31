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
            DateTime start = new DateTime(1900,1,1);
            DateTime end = new DateTime(2099, 1, 1);
            Random random = new Random();
            int randomDays = random.Next((end - start).Days + 1);
            DateTime randomDate = start.AddDays(randomDays);

            return randomDate;
        }
        private static Random rand = new Random();


        public static DateTime RandomDate(int year)
        {
            

            if (year >= DateTime.Now.Year)
            {
                throw new ArgumentException("RequestedDate cannot be greater than or equal to the current date.");
            }

            DateTime start = new DateTime(year, 1, 1);
            DateTime end = new DateTime(year, 12, 31);

            int range = (end - start).Days;


            int randomDays = rand.Next(range + 1);

            DateTime randomDate = start.AddDays(randomDays);

            return randomDate;

            
        }


        public static DateTime RandomDate(int start, int end, bool useMonths = false)
        {
            if (useMonths)
            {
                Random random = new Random();
                int range = (end - start);

                int randomMonth = rand.Next(range);

                DateTime startDate = new DateTime(start, 1, 1);
                DateTime randomDate = startDate.AddDays(randomMonth);

                return randomDate;
            }
            else
            {
                Random random = new Random();
                int range = (end - start) * 365;

                int randomDays = rand.Next(range);

                DateTime startDate = new DateTime(start, 1, 1);
                DateTime randomDate = startDate.AddDays(randomDays);

                return randomDate;
            }
           
        }
    }
}
