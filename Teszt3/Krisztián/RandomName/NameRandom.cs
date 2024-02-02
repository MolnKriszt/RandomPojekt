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
        public static string[] surnames;
        public static string[] femalenames;
        public static string[] malenames;

        public static void NamesReading()
        {
            if (lang == "en")
            {
                surnames = File.ReadAllLines("ensurnames.txt");
                femalenames = File.ReadAllLines("enfemalenames.txt");
                malenames = File.ReadAllLines("enmalenames.txt");
            }
            else if (lang == "hu")
            {
                surnames = File.ReadAllLines("husurnames.txt");
                femalenames = File.ReadAllLines("hufemalenames.txt");
                malenames = File.ReadAllLines("humalenames.txt");
            }
        }

    }
}
