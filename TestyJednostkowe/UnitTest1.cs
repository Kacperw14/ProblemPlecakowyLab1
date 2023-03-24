using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using ProblemPlecakowy;

namespace TestyJednostkowe
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CzyZwracaJedenElementGdySieMiesciPrzynajmniejJeden()
        {
            int N = 10;
            int seed = 1;
            //Plecak P = new Plecak(N, seed);
            for (int capacity = 0; capacity < 20; capacity++)
            {
                Plecak P = new Plecak(N, seed, capacity);
                P.PackBackpack(); //sprawdzamy to
                Item min = P.items.OrderBy(it => it.weight).ToList()[0];
                if (capacity >= min.weight)
                    Assert.IsTrue(min.x);
            }
        }

        [TestMethod]
        public void CzyZwracaPustyGdyNieMiesciSieNawetJeden()
        {
            int N = 10;
            int seed = 1;
            //Plecak P = new Plecak(N, seed);

            for (int capacity = 0; capacity < 20; capacity++)
            {
                Plecak P = new Plecak(N, seed, capacity);
                P.PackBackpack(); //sprawdzamy to
                Item min = P.items.OrderBy(it => it.weight).ToList()[0];
                if (capacity < min.weight)
                    Assert.IsFalse(min.x);
            }
        }

        [TestMethod]
        public void Test3()
        {
            int N = 10;
            int seed = 1;
            int capacity = 10;
            Plecak P = new Plecak(N, seed, capacity);

        }
    }

}
