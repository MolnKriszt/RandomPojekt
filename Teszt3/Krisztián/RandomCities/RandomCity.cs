using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    static internal partial class MyRandom
    {
        static string[] cities;
        internal static void CityReading()
        {
            if (lang == "en")
            {
                cities = File.ReadAllLines("encities.txt");
            }
            else if (lang == "hu")
            {
                cities = File.ReadAllLines("hucities.txt");
            }
        }

        public static string RandomCity()
        {
            return cities[random.Next(0, cities.Length)];
        }

        public static List<string> RandomCity(int citiesCount)
        {
            List<string> results = new List<string>();
            for (int i = 0; i < citiesCount; i++)
            {
                string generatedCity = RandomCity();
                if (results.Contains(generatedCity))
                {
                    i--;
                }
                else
                {
                    results.Add(generatedCity);
                }
            }

            return results;
        }
    }
}
