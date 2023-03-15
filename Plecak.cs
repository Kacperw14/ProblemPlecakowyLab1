using System;
using System.Collections.Generic;

namespace ProblemPlecakowy
{
    internal class Plecak
    {
        List<Item> items;

        public Plecak(int N, int seed)
        {
            items = new List<Item>();
            Random random = new Random(seed);

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
                str += "v: " + i.value + " \n";
                str += "w: " + i.weight + " \n\n";
            }
            return str;
        }

        public void Sort()
        {
            Plecak plecak;
            //zmiana this 
            //List<float> prices = new List<float>();
            foreach (Item i in items)
            {
                
                //prices.Add(i.GetPrice());
            }
            
            //items.ordedby
        }
    }

}
