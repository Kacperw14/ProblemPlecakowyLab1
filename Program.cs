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
            
            Plecak plecak = new Plecak(10, 1);
            Console.WriteLine(plecak);
            Console.ReadLine();
        }
    }
}