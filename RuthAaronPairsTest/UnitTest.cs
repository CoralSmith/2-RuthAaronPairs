using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RuthAaronPairs;
using System.Collections;
using System.Collections.Generic;

namespace RuthAaronPairsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenValidPairReturnsTrue()
        {
            Assert.IsTrue(RuthAaronPair.IsValid(714, 715));
            Assert.IsTrue(RuthAaronPair.IsValid(77, 78));
            Assert.IsFalse(RuthAaronPair.IsValid(20, 21));
            Assert.IsTrue(RuthAaronPair.IsValid(5,6));
            Assert.IsTrue(RuthAaronPair.IsValid(2107,2108));
            Assert.IsTrue(RuthAaronPair.IsValid(492,493));
            Assert.IsFalse(RuthAaronPair.IsValid(128,129));
        }

        [TestMethod]
        public void GivenNonconsecutivePairReturnsFalse()
        {
            Assert.IsFalse(RuthAaronPair.IsValid(12, 14));
        }

        [TestMethod]
        public void Given2ReturnsIEnumerable2()
        {
            AssertContainsAll(new List<int> { 2 }, Primes.GetPrimes(2));
        }

        [TestMethod]
        public void Given3ReturnsIEnumerable3()
        {
            AssertContainsAll(new List<int> { 3 }, Primes.GetPrimes(3));
        }

        [TestMethod]
        public void Given4ReturnsIEnumerable2()
        {
            AssertContainsAll(new List<int> { 2, 2 }, Primes.GetPrimes(4));
        }

        [TestMethod]
        public void Given5ReturnsIEnumerable5()
        {
            AssertContainsAll(new List<int> { 5 }, Primes.GetPrimes(5));
        }

        [TestMethod]
        public void GivenNReturnsIEnumerablePrimes()
        {
            AssertContainsAll(new List<int> { 2, 3 }, Primes.GetPrimes(6));
            AssertContainsAll(new List<int> { 7 }, Primes.GetPrimes(7));
            AssertContainsAll(new List<int> { 2, 2, 2 }, Primes.GetPrimes(8));
            AssertContainsAll(new List<int> { 3, 3 }, Primes.GetPrimes(9));
            AssertContainsAll(new List<int> { 2, 5 }, Primes.GetPrimes(10));
            AssertContainsAll(new List<int> { 11 }, Primes.GetPrimes(11));
            AssertContainsAll(new List<int> { 3, 2, 2 }, Primes.GetPrimes(12));
            AssertContainsAll(new List<int> { 13 }, Primes.GetPrimes(13));
            AssertContainsAll(new List<int> { 2, 7 }, Primes.GetPrimes(14));
            AssertContainsAll(new List<int> { 5, 3 }, Primes.GetPrimes(15));
            AssertContainsAll(new List<int> { 2, 2, 2, 2 }, Primes.GetPrimes(16));
            AssertContainsAll(new List<int> { 5, 5 }, Primes.GetPrimes(25));
            AssertContainsAll(new List<int> { 2, 3, 7, 17 }, Primes.GetPrimes(714).Distinct());
            AssertContainsAll(new List<int> { 5, 11, 13 }, Primes.GetPrimes(715).Distinct());
        }

        public void AssertContainsAll(IEnumerable<int> expected, IEnumerable<int> actual)
        {
            int n1 = expected.Distinct().Count();
            int n2 = actual.Distinct().Count();

            Assert.AreEqual(n1, n2);
            Assert.AreEqual(n1, expected.Intersect(actual).Count());
            Assert.AreEqual(n1, actual.Intersect(expected).Count());
        }
    }
}
