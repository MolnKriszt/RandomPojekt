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
        /// <summary>
        /// Here we generate a random date from 1900-2099
        /// </summary>
        public static DateTime RandomDate()
        {
            DateTime start = new DateTime(1900,1,1);
            DateTime end = new DateTime(2099, 1, 1);
            Random random = new Random();
            int randomDays = random.Next((end - start).Days + 1);
            DateTime randomDate = start.AddDays(randomDays);

            return randomDate;
        }


        /// <summary>
        /// Here we generate a random date from a specified year
        /// </summary>
        public static DateTime RandomDate(int year)
        {
            

            DateTime start = new DateTime(year, 1, 1);
            DateTime end = new DateTime(year, 12, 31);

            int range = (end - start).Days;


            int randomDays = random.Next(range + 1);

            DateTime randomDate = start.AddDays(randomDays);

            return randomDate;

            
        }

        /// <summary>
        /// Here we generate a random date between two specified months or years
        /// </summary>
        public static DateTime RandomDate(int start, int end, bool useMonths = false)
        {
            if (useMonths)
            {
                int range = (end - start + 1);
                int randomMonth = random.Next(range);

                DateTime startDate = new DateTime(start, 1, 1);
                DateTime randomDate = startDate.AddMonths(randomMonth - 1);

                return randomDate;
            }
            else
            {

                int range = (end - start) * 365;

                int randomDays = random.Next(range);

                DateTime startDate = new DateTime(start, 1, 1);
                DateTime randomDate = startDate.AddDays(randomDays);

                return randomDate;
            }
           
        }
    }
}
