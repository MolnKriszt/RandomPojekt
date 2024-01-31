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
        static public int RandomInt()
        {
            return random.Next(int.MinValue , int.MaxValue);
        }

        static public double RandomDouble()
        {
            //double min = 1;
            //double max = 5;
            double min = Math.Pow(10, -20);//double.MinValue;
            double max = Math.Pow(10, 20);
            return min + (random.NextDouble() * (max - min));
        }

        static public void RandomInt(int from, int to)
        {
            if (from > to)
            {
                return;
            }
            int generatedValue = random.Next(from, to + 1);

        }
    }
}
