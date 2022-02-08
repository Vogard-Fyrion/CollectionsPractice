using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            string[] names = {"Tim", "Martin", "Nikki", "Sara"};
            bool[] booleans = {true, false, true, false, true, false, true, false, true, false};

            List<string> flavors = new List<string>();

            flavors.Add("Chocolate Chip");
            flavors.Add("Vanilla");
            flavors.Add("Chocolate");
            flavors.Add("Neopolitan");
            flavors.Add("Rocky Road");

            Console.WriteLine(flavors.Count);
            Console.WriteLine(flavors[2]);

            flavors.RemoveAt(2);

            Console.WriteLine(flavors.Count);

            Dictionary<string, string> favorites = new Dictionary<string, string>();

            Random rand = new Random();
            for(int x = 0; x < names.Length; x++)
            {
            favorites.Add(names[x], flavors[rand.Next(0, 4)]);
            }
            foreach(KeyValuePair<string, string> entry in favorites)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }
        }
    }
}
