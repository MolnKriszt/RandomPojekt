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
        static public double RandomDouble(double from, double to)
        {
            if (from > to)
            {
                throw new ArgumentException("'from' can't be bigger then 'to' .");
            }

            double min = from;
            double max = to;
            return min + (random.NextDouble() * (max - min));

        }

        static public List<int> RandomInt(int ListCount) 
        {
            List<int> results = new List<int>();

            for (int i = 0; i < ListCount; i++)
            {
                results.Add(RandomInt());
            }
            return results;

        }

        static public List<int> RandomInt(int ListCount,int from, int to)
        {
            List<int> results = new List<int>();

            for (int i = 0; i < ListCount; i++)
            {
                results.Add(RandomInt(from, to));
            }
            return results;

        }

        static public List<int> RandomInt(int ListCount, int from, int to, bool Distinct)
        {
            List<int> results = new List<int>();

            for (int i = 0; i < ListCount; i++)
            {
                int generatedInt = RandomInt(from, to);
                if (!Distinct)
                {
                    results.Add(generatedInt);
                }
                else
                {
                    if (ListCount > to - from)
                    {
                        throw new Exception("ListCount cant be bigger that the difference between from and to");
                    }
                    else
                    {
                        if (results.Contains(generatedInt))
                        {
                            i--;
                        }
                        else
                        {
                            results.Add(generatedInt);
                        }
                    }
                }
            }
            return results;

        }

        static public List<int> RandomInt(int ListCount, bool Distinct)
        {
            List<int> results = new List<int>();

            for (int i = 0; i < ListCount; i++)
            {
               int generatedInt = RandomInt();
                if (!Distinct)
                {
                    results.Add(generatedInt);
                }
                else
                {
                    if (results.Contains(generatedInt))
                    {
                        i--;
                    }
                    else
                    {
                        results.Add(generatedInt);
                    }
                }
                
            }
            return results;
        }

        static public List<double> RandomDouble(int ListCount)
        {
            List<double> results = new List<double>();

            for (int i = 0; i < ListCount; i++)
            {
                results.Add(RandomDouble());
            }
            return results;
        }

        static public List<double> RandomDouble(int ListCount,double from, double to)
        {
            List<double> results = new List<double>();

            for (int i = 0; i < ListCount; i++)
            {
                results.Add(RandomDouble(from,to));
            }
            return results;
        }

        static public List<double> RandomDouble(int ListCount, bool Distinct)
        {
            List<double> results = new List<double>();

            for (int i = 0; i < ListCount; i++)
            {
                double generatedDouble = RandomDouble();
                if (!Distinct)
                {
                    results.Add(generatedDouble);
                }
                else
                {
                    if (results.Contains(generatedDouble))
                    {
                        i--;
                    }
                    else
                    {
                        results.Add(generatedDouble);
                    }
                }

            }
            return results;
        }

    }
}
