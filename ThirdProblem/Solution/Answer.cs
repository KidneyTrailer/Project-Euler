using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdProblem.Solution
{
    public class Answer
    {
        public long[] Factor(long num)
        {
            List<long> result = new List<long>();
            double mid = Math.Ceiling(Math.Sqrt(num));
            for (long l = 2; l < mid; l++)
            {
                if (num % l == 0)
                {
                    result.Add(l);
                    result.Add(num / l);
                }
            }
            result.Sort();
            return result.ToArray();
        }

        public bool IsPrime(long l)
        {
            if (l < 2) return false;
            if (l == 2) return true;
            double mid = Math.Ceiling(Math.Sqrt(l));
            for (int i = 2; i < mid; i++)
            { if (l % i == 0) { return false; } }
            return true;
        }

        public long[] PrimeFacts(long l)
        {
            long[] facts = Factor(l);
            List<long> result = new List<long>();
            foreach (long f in facts)
            { if (IsPrime(f)) { result.Add(f); } }
            return result.ToArray();
        }

        public static void Main(String[] args)
        {
            long target = 600851475143;
            Answer answer = new Answer();
            long[] primeFacts = answer.PrimeFacts(target);
            long result = primeFacts[primeFacts.Length - 1];

            Console.WriteLine($"The largest prime factor of the number {target} is {result}");
            Console.ReadKey(true);
        }
    }
}
