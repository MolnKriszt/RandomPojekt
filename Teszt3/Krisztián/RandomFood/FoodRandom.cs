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

        public static List<Tuple<int, string>> foodlist = new List<Tuple<int, string>>();
        internal static void FoodReading()
        {
            if (lang == "en")
            {
                string[] lines = File.ReadAllLines("enfoods.txt");
                foreach (var line in lines)
                {
                    string[] columns = line.Split(';');
                    int type = int.Parse(columns[0]);
                    string food = columns[1];
                    foodlist.Add(new Tuple<int, string>(type, food));
                }
            }
            else if (lang == "hu")
            {
                string[] lines = File.ReadAllLines("hufoods.txt");
                foreach (var line in lines)
                {
                    string[] columns = line.Split(';');
                    int type = int.Parse(columns[0]);
                    string food = columns[1];
                    foodlist.Add(new Tuple<int, string>(type, food));
                }
            }
        }

        /// <summary>
        /// Generates a random food or drink item from the 'foodlist' and returns it as a Tuple.
        /// If the 'foodlist' is empty, returns null.
        /// </summary>
        /// <returns>A Tuple representing a randomly selected food or drink item. The first element is the type ID, 
        /// and the second element is the name of the item.</returns>
        static public Tuple<int, string> RandomFood()
        {
            if (foodlist.Count == 0)
            {
                return null;
            }
            int randomIndex = random.Next(0, foodlist.Count);
            return foodlist.ElementAt(randomIndex);
        }

        /// <summary>
        /// Generates a random food item based on the specified type and returns its name.
        /// </summary>
        /// <param name="type">The type of food to generate:
        /// 1 - Soup, 2 - Main Course, 3 - Dessert, 4 - Drink.</param>
        /// <returns>The name of a randomly selected food item of the specified type.
        /// Returns an empty string if the specified type is invalid or if the 'foodlist' is empty.</returns>
        static public string RandomFood(int type)
        {
            var specificType = foodlist
                .Where(item => item.Item1 == type)
                .ToList();

            if (specificType.Count == 0)
            {
                return string.Empty;
            }

            int randomIndex = random.Next(0, specificType.Count);
            return specificType.ElementAt(randomIndex).Item2;
        }
    }
}
