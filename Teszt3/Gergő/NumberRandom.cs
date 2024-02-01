using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    static internal partial class MyRandom
    {
        static Random random = new Random();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        static public int RandomInt()
        {
            return random.Next(int.MinValue , int.MaxValue);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        static public double RandomDouble()
        {
            //double min = 1;
            //double max = 5;
            double min = Math.Pow(10, -20);//double.MinValue;
            double max = Math.Pow(10, 20);
            return min + (random.NextDouble() * (max - min));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        static public int RandomInt(int from, int to)
        {
            if (from > to)
            {
                throw new ArgumentException("'from' can't be bigger then 'to' .");
            }
            int generatedValue = random.Next(from, to + 1);
            return generatedValue;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        static double RandomDouble(double from, double to)
        {
            if (from >= to)
            {
                throw new ArgumentException("igen nem talán lyó");
            }

            double randomValue = random.NextDouble() * (to - from) + from;
            return randomValue;
        }


    }
}
