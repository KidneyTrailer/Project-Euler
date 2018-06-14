using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenthProblem.Solution
{
    public class Answer
    {
        public long[] FindPrimes(long lim)
        {
            List<long> result = new List<long>();
            for (long l = 0; l < lim; l++)
            { if (IsPrime(l)) { result.Add(l); } }
            return result.ToArray();
        }

        public bool IsPrime(long x)
        {
            if (x < 2) { return false; }
            if (x == 2) { return true; }
            for (int i = 2; i < Math.Ceiling(Math.Sqrt(x)) + 1; i++)
            { if (x % i == 0) { return false; } }
            return true;
        }

        public long Sum(long[] nums)
        {
            long total = 0L;
            foreach(long l in nums) { total += l; }
            return total;
        }

        public static void Main(String[] args)
        {
            int lim = 2000000;
            Answer answer = new Answer();
            long result = answer.Sum(answer.FindPrimes(lim));

            Console.WriteLine($"The sum of all the primes below {lim} is {result}");
            Console.ReadKey(true);
        }
    }
}
