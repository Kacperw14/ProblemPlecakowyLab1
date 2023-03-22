using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemPlecakowy
{
    public class Plecak
    {
        public List<Item> items;
        //public int cap;

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
                str += "x: " + i.x + " \t";
                str += "v: " + i.value + " \t";
                str += "w: " + i.weight + " \t";
                str += "p: " + i.price + " \n";
            }
            return str;
        }

        public void Sort()
        {
            items = items.OrderByDescending(it => it.price).ToList();
        }

        public void PackBackpack(int capacity)
        {
            int package = 0;
            //Plecak plecak = new Plecak(0, 0);

            Sort();
            foreach (Item i in items)
            {
                //przerwanie funkcji gdy osiagnieto cel:
                if (package == capacity) break;
                else if (package < capacity)
                {
                   if (package + i.weight <= capacity)
                   {
                        package += i.weight;
                        i.x = true;
                   }
                }
            }
        }
    }
}