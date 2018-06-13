using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthProblem.Solution
{
    public class Answer
    {

        public bool IsDivisibleBy(long num, long divisor)
        { return num % divisor == 0; }

        public bool IsDivisibleByRange(long num, long[] divisors)
        {
            foreach (long divisor in divisors)
            { if (num % divisor != 0) { return false; } }
            return true;
        }

        public long[] MakeRange(long lim)
        {
            long[] result = new long[lim];
            for (long i = 0; i < lim; i++)
            { result[i] = i + 1; }
            return result;
        }

        public long SmallestNumDivisibleByRange(long rangeLim)
        {
            long candidate = rangeLim;
            long[] range = MakeRange(rangeLim);
            while (true)
            {
                if (IsDivisibleByRange(candidate, range)) { break; }
                candidate += rangeLim;
            }
            return candidate;
        }

        public static void Main(String[] args)
        {
            long lim = 20L;
            Answer answer = new Answer();
            long result = answer.SmallestNumDivisibleByRange(lim);

            Console.WriteLine($"The smallest positive number that is evenly divisible by all numbers " +
                $"from 1 to 20 is {result}");
            Console.ReadKey(true); }
    }
}
