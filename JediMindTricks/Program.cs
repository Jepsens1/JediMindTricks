using System;
using System.Collections.Generic;
using System.Linq;

namespace JediMindTricks
{
    class Program
    {
        static void Main(string[] args)
        {
            //OPG 1
            Dictionary<string, int> people = new Dictionary<string, int>();
            people.Add("Luke", 25);
            people.Add("Leia", 25);
            people.Add("Han", 45);
            people.Add("Yoday", 125);
            people.Add("Chewbacca", 50);
            //OPG 2
            people["Phillip"] = 20;
            people.Add("Kenneth", 19);
            Console.WriteLine(people.ElementAt(0));
            //Opg 3
            people.Remove("Han");

            foreach (var item in people)
            {
                Console.WriteLine(item.Value);
            }
            Console.ReadKey();
        }
    }
}
