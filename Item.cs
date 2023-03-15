using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemPlecakowy
{
    class Item
    {
        public int value;
        public int weight;
        public float price;
        public Item(int v, int w)
        {
            value = v;
            weight = w;
            price = v/w;
        } 
        //niepotrzebne
        public float GetPrice()
        {
            return price;
        }

    }
}
