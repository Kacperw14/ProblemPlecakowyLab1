using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemPlecakowy;
using System.Linq;

namespace TestyJednostkowe
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CzyPakujeJedenElementGdySieMiesciPrzynajmniejJeden()
        {
            int N = 100;
            for (int seed = 0; seed < 10; seed++)
            {
                for (int capacity = 0; capacity < 100; capacity += 10)
                {
                    Plecak P = new Plecak(N, seed, capacity);
                    P.PackBackpack();
                    Item min = P.items.OrderBy(it => it.weight).ToList()[0];
                    if (capacity >= min.weight)
                        Assert.IsTrue(min.x);
                }
            }
        }

        [TestMethod]
        public void CzyZwracaPustyGdyNieMiesciSieNawetJeden()
        {
            int N = 100;
            for (int seed = 0; seed < 10; seed++)
            {
                for (int capacity = 0; capacity < 100; capacity += 10)
                {
                    Plecak P = new Plecak(N, seed, capacity);
                    P.PackBackpack();
                    Item min = P.items.OrderBy(it => it.weight).ToList()[0];
                    if (capacity < min.weight)
                        Assert.IsFalse(min.x);
                }
            }
        }

        [TestMethod]
        public void CzyTworzySieOdpowiedniaLiczbaPrzedmiotow()
        {
            int N = 100;
            for (int seed = 0; seed < 10; seed++)
            {
                for (int capacity = 0; capacity < 100; capacity += 10)
                {
                    Plecak P = new Plecak(N, seed, capacity);
                    Assert.IsTrue(N == P.items.Count);
                }
            }
        }

        [TestMethod]
        public void CzyDobrzePakuje()
        {
            int N = 100;
            for (int seed = 0; seed < 10; seed++)
            {
                for (int capacity = 0; capacity < 100; capacity += 10)
                {
                    Plecak P = new Plecak(N, seed, capacity);
                    P.PackBackpack();
                    Assert.IsTrue(capacity >= P.package);
                }
            }
        }
    }

}
