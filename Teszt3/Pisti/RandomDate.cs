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
        /// 

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
        /// Generates a random integer within a specified range.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end">hith the help of this variable, we csan determite whether the max yerar or the max month </param>
        /// <param name="useMonths">with the help of this variable, we can determine whether a random year or month is required, if true then a year is required, if false then a month</param>
        /// <returns></returns>
        public static DateTime RandomDate( int start, int end, bool useMonths = false)
        {
            if (useMonths)
            {
                int randomYear = random.Next(1900,2099 +1); 
                int randomMonth = random.Next(start, end + 1);
                int lastDayOfMonth = DateTime.DaysInMonth(randomYear, randomMonth);

                int randomDay = random.Next(1, lastDayOfMonth + 1);

                DateTime randomDate = new DateTime(randomYear, randomMonth, randomDay);

                return randomDate;
            }
            else
            {
                int randomYear = random.Next(start, end + 1);
                int randomMonth = random.Next(1, 13); // Teljesen random hónap (1-12)
                int lastDayOfMonth = DateTime.DaysInMonth(randomYear, randomMonth);

                int randomDay = random.Next(1, lastDayOfMonth + 1);

                DateTime randomDate = new DateTime(randomYear, randomMonth, randomDay);

                return randomDate;
            }
        }
    }
}
