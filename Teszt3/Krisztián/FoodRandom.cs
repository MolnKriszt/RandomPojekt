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
        internal static string lang = "hu";

        public static List<Tuple<int, string>> foodlist { get; } = new List<Tuple<int, string>>();
        internal static void FoodReading()
        {
            if (lang == "en")
            {
                string[] lines = File.ReadAllLines("etelek.txt");
                foreach (var line in lines)
                {
                    string[] columns = line.Split(';');
                    int type = int.Parse(columns[0]);
                    string food = columns[1];
                    foodlist.Add(new Tuple<int,string>(type, food));
                }
            }
            else if (lang == "hu")
            {
                string[] lines = File.ReadAllLines("etelek.txt");
                foreach (var line in lines)
                {
                    string[] columns = line.Split(';');
                    int type = int.Parse(columns[0]);
                    string food = columns[1];
                    foodlist.Add(new Tuple<int, string>(type, food));
                }
            }
        }

        static public void RandomFood()
        {
            
        }
    }
}
