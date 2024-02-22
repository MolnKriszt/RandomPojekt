global using global::System;
global using global::System.Collections.Generic;
global using global::System.IO;
global using global::System.Linq;
global using global::System.Net.Http;
global using global::System.Threading;
global using global::System.Threading.Tasks;

namespace RandomLibrary
{
    static public class MyRandom
    {
        private static List<Tuple<int, string>> foodlist = new List<Tuple<int, string>>();

        private static string[] surnames;
        private static string[] femalenames;
        private static string[] malenames;

        private static string[] cities;

        private static string[] wordList;

        static Random random = new Random();
        
        internal static string lang = "hu";
        
        static MyRandom()
        {
            langChange(lang);
        }

        private static void langChange(string plang)
        {
            lang = plang;
            TextReading();
            FoodReading();
            NamesReading();
            CityReading();

        }

        private static void TextReading()
        {
            if (lang == "en")
            {
                wordList = File.ReadAllLines("enword.txt");
            }
            else if (lang == "hu")
            {
                wordList = File.ReadAllLines("huword.txt");
            }
        }

        private static void FoodReading()
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

        private static void NamesReading()
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

        private static void CityReading()
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

        //RandomDate

        /// <summary>
        /// Here we generate a random date from 1900-2099
        /// </summary>
        public static DateTime RandomDate()
        {
            DateTime start = new DateTime(1900, 1, 1);
            DateTime end = new DateTime(2099, 1, 1);
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
        public static DateTime RandomDate(int start, int end, bool useMonths = false)
        {
            if (useMonths)
            {
                int randomYear = random.Next(1900, 2099 + 1);
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

        //RandomFood

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

        //RandomNumber

        static public int RandomInt()
        {
            return random.Next(int.MinValue, int.MaxValue);
        }

        static public double RandomDouble()
        {
            //double min = 1;
            //double max = 5;
            double min = Math.Pow(10, -20);//double.MinValue;
            double max = Math.Pow(10, 20);
            return min + (random.NextDouble() * (max - min));
        }

        static public int RandomInt(int from, int to)
        {
            if (from > to)
            {
                throw new ArgumentException("'from' can't be bigger then 'to' .");
            }
            int generatedValue = random.Next(from, to + 1);
            return generatedValue;
        }

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

        static public List<int> RandomInt(int ListCount, int from, int to)
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

        static public List<double> RandomDouble(int ListCount, double from, double to)
        {
            List<double> results = new List<double>();
            for (int i = 0; i < ListCount; i++)
            {
                results.Add(RandomDouble(from, to));
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

        //RandomName

        private static string RandomSurname()
        {
            return surnames[random.Next(0, surnames.Length)];
        }

        private static string RandomFemaleFirstname()
        {
            return femalenames[random.Next(0, femalenames.Length)];
        }

        private static string RandomMaleFirstname()
        {
            return malenames[random.Next(0, malenames.Length)];
        }

        public static string RandomName()
        {
            int randomnum = random.Next(0, 2);
            return (RandomSurname() + " ") + (randomnum == 0 ? RandomFemaleFirstname() : RandomMaleFirstname());
        }

        public static string RandomName(string MaleOrFemale)
        {
            string surname = RandomSurname();
            if (MaleOrFemale == "f")
            {
                return surname + " " + RandomFemaleFirstname();
            }
            else if (MaleOrFemale == "m")
            {
                return surname + " " + RandomMaleFirstname();
            }
            else
            {
                return null;
            }
        }

        public static List<string> RandomName(int nameCount)
        {
            List<string> results = new List<string>();
            for (int i = 0; i < nameCount; i++)
            {
                results.Add(RandomName());
            }
            return results;
        }

        public static List<string> RandomName(int nameCount, bool Distinct)
        {
            List<string> results = new List<string>();
            if (!Distinct)
            {
                for (int i = 0; i < nameCount; i++)
                {
                    results.Add(RandomName());
                }
            }
            else
            {
                for (int i = 0; i < nameCount; i++)
                {
                    string generatedName = RandomName();
                    if (results.Contains(generatedName))
                    {
                        i--;
                    }
                    else
                    {
                        results.Add(generatedName);
                    }
                }
            }
            return results;
        }

        public static List<string> RandomName(int nameCount, string MaleOrFemale)
        {
            List<string> results = new List<string>();
            for (int i = 0; i < nameCount; i++)
            {
                if (MaleOrFemale == "m")
                {
                    results.Add(RandomName("m"));
                }
                else if (MaleOrFemale == "f")
                {
                    results.Add(RandomName("f"));
                }
            }
            return results;
        }

        public static List<string> RandomName(int nameCount, string MaleOrFemale, bool Distinct)
        {
            List<string> results = new List<string>();

            if (!Distinct)
            {
                for (int i = 0; i < nameCount; i++)
                {
                    if (MaleOrFemale == "m")
                    {
                        results.Add(RandomName("m"));
                    }
                    else if (MaleOrFemale == "f")
                    {
                        results.Add(RandomName("f"));
                    }
                }
            }
            else
            {
                for (int i = 0; i < nameCount; i++)
                {
                    string generatedName = "";
                    if (MaleOrFemale == "m")
                    {
                        generatedName = RandomName("m");
                    }
                    else if (MaleOrFemale == "f")
                    {
                        generatedName = RandomName("f");
                    }

                    if (results.Contains(generatedName))
                    {
                        i--;
                    }
                    else
                    {
                        results.Add(generatedName);
                    }
                }
            }
            return results;
        }

        //RandomCities

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

        //RandomText

        static public string RandomWord()
        {
            return wordList[random.Next(0, wordList.Length)];
        }

        static public List<string> RandomWord(int wordCount, bool Distinct)
        {
            List<string> result = new List<string>();
            if (!Distinct)
            {
                for (int i = 0; i < wordCount; i++)
                {
                    result.Add(wordList[random.Next(0, wordList.Length)]);
                }
            }
            else
            {
                for (int i = 0; i < wordCount; i++)
                {
                    string generatedword = wordList[random.Next(0, wordList.Length)];
                    if (result.Contains(generatedword))
                    {
                        i--;
                    }
                    else
                    {
                        result.Add(generatedword);
                    }
                }
            }
            return result;
        }

        public static string RandomSentence(int wordCount)
        {
            string sentence = wordList[random.Next(0, wordList.Length)];

            for (int i = 1; i < wordCount; i++)
            {
                sentence += ", " + wordList[random.Next(0, wordList.Length)];
            }
            return sentence;
        }

        public static string RandomParagraph(int SentenceCount, int WordperSentence)
        {
            string paragraph = "";

            for (int i = 0; i < SentenceCount; i++)
            {
                string sentence = wordList[random.Next(0, wordList.Length)];

                for (int i2 = 1; i2 < WordperSentence; i2++)
                {
                    sentence += " " + wordList[random.Next(0, wordList.Length)];
                }
                paragraph += sentence + "\n";
            }
            return paragraph;
        }
    }
}
