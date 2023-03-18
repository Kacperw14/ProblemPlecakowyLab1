using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemPlecakowy
{
    internal class Plecak
    {
        List<Item> items;

        public Plecak(int N, int seed)
        {
            items = new List<Item>();
            Random random = new Random(seed);

            Console.WriteLine("\n");

            for (int i = 0; i < N; i++)
            {
                Item item = new Item(random.Next(1, 9), random.Next(1, 9));
                items.Add(item);
            }
        }

        public override string ToString()
        {
            string str = "";
            foreach (Item i in items)
            {
                str += "v: " + i.value + " \t";
                str += "w: " + i.weight + " \t";
                str += "p: " + i.price + " \n";
            }
            return str;
        }

        public void Sort()
        {
            Plecak plecak;
            items = items.OrderBy(it => it.price).ToList();
            //items = items.OrderByDescending(it => it.price).ToList();
            
            /*
            foreach (var i in items)
            {
               Console.WriteLine(i.price);
            }
            */
        }
    }

}
