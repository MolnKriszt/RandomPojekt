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
        /// <summary>
        /// Generates a random surname
        /// </summary>
        /// <returns></returns>
        public static string RandomSurname()
        {
            return surnames[random.Next(0, surnames.Length)];
        }

        public static string RandomFemaleFirstname()
        {
            return femalenames[random.Next(0, femalenames.Length)];
        }

        public static string RandomMaleFirstname()
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

        public static List<string> RandomName(int nameCount,bool Distinct)
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

        public static List<string> RandomName(int nameCount,string MaleOrFemale)
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

    }
}
