using System;

namespace RuthAaronPairs
{
    public class RuthAaronPair
    {
        public static bool IsValid(int v1, int v2)
        {
            if (Math.Abs(v1 - v2) != 1) return false;
            return Primes.SumDistinctPrimes(v1) == Primes.SumDistinctPrimes(v2);
        }

    }
}
