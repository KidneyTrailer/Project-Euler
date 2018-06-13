using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProblem.Solution
{
    public class Answer
    {
        public long[] EvenVals(long[] nums)
        {
            List<long> result = new List<long>();
            foreach (long i in nums)
            {
                if (i % 2 == 0) { result.Add(i); }
            }
            return result.ToArray();
        }

        public long[] Fib(int terms = 0, int lim = 0)
        {
            if (terms > 0 && lim > 0) { throw new Exception("Only one arguement can be greater than 0."); }
            else if (terms == 0 && lim == 0) { throw new Exception("Both arguements cannot be 0."); }
            List<long> result = new List<long>();

            long a = 1L, b = 2L, c = 0L;
            result.Add(a);
            result.Add(b);

            while (true)
            {
                c = a + b;
                if (lim > 0 && c > lim) { break; }
                result.Add(c);
                if (terms > 0 && result.Count >= terms) { break; }
                a = b;
                b = c;
            }
            return result.ToArray();
        }

        public int Sum(long[] nums)
        {
            int total = 0;
            foreach(long l in nums) { total += (int)l; }
            return total;
        }

        public static void Main(String[] args)
        {
            int lim = 4000000;
            long[] fib;
            int result;
            Answer answer = new Answer();

            fib = answer.Fib(0, lim);
            fib = answer.EvenVals(fib);
            result = answer.Sum(fib);

            Console.WriteLine($"The sum of even-valued Fibonacci terms whose values do not exceed {lim} is {result}");
            Console.ReadKey(true);
        }
    }
}
