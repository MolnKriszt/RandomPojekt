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

        public static string RandomFemalename()
        {
            return femalenames[random.Next(0, femalenames.Length)];
        }

        public static string RandomMalename()
        {
            return malenames[random.Next(0, malenames.Length)];
        }

        public static string RandomName()
        {
            int randomnum = random.Next(0, 2);
            return (RandomSurname() + " ") + (randomnum == 0 ? RandomFemalename() : RandomMalename());
        }

        public static string RandomName(int MaleOrFemale)
        {
            string surname = RandomSurname();
            if (MaleOrFemale == 0)
            {
                return surname + " " + RandomFemalename();
            }
            else if (MaleOrFemale == 1)
            {
                return surname + " " + RandomMalename();
            }
            else
            {
                return null;
            }
        }

    }
}
