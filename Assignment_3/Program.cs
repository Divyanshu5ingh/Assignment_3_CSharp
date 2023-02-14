using System;
using System.Collections.Generic;
using System.Linq;


namespace Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary of Prime Minister using Year and details
            var PrimeMinisterdictionary = new Dictionary<int, string>()
            {             
                {1998, "Atal Bihari Vajpayee" },
                {2014, "Narendra Modi"},
                {2004,  "Manmohan Singh"}
            };

            //Finding the Prime Minister of 2004
            Console.WriteLine("Prime Minister of 2004 : {0}\n", PrimeMinisterdictionary[2004]);

            //Adding the current Prime Minister int the Dictionary
            PrimeMinisterdictionary.Add(2023, "Narendra Modi");

            //Shorting the dictionary by year
            var list = PrimeMinisterdictionary.Keys.ToList();
            list.Sort();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Printing Sorted dictionary by year");
            Console.WriteLine("-----------------------------------");           
            foreach (var key in list)
            {
                Console.WriteLine("{0}, {1}", key, PrimeMinisterdictionary[key]);                
            }
            
            Console.ReadKey();
        }
    }
}
