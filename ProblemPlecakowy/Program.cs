﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemPlecakowy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe przedmiotow");
            int n = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Podaj seed");
            int seed = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj pojemność plecaka");
            int C = int.Parse(Console.ReadLine());

            Plecak plecak = new Plecak(n, seed, C);
            Console.WriteLine(plecak);
            plecak.PackBackpack();
            Console.WriteLine(plecak);
            Console.ReadLine();
        }
    }
}
