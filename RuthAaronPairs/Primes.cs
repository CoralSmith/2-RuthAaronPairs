using System.Collections.Generic;
using System.Linq;

namespace RuthAaronPairs
{
    public class Primes
    {
        public static List<int> GetPrimes(int n)
        {
            var result = new List<int>();
            for (int i = 2; i <= n; i++)
            {
                while (n % i == 0)
                {
                    result.Add(i);
                    n = n / i;
                }
            }           

            return result;
        }

        public static int SumDistinctPrimes(int n)
        {
            return GetPrimes(n).Distinct().Sum();
        }
    }
}
