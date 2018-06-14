using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthProblem.Solution
{
    public class Answer
    {
        public long Difference(int lim)
        { return Math.Abs(SumOfSquares(lim) - SquareOfSum(lim)); }

        public long SquareOfSum(int lim)
        {
            long result = 0L;
            for (long i = 0; i <= lim; i++)
            { result += i; }
            return result * result;
        }

        public long SumOfSquares(int lim)
        {
            long result = 0L;
            for (long i = 0; i <= lim; i++)
            { result += i * i; }
            return result;
        }

        public static void Main(String[] args)
        {
            int lim = 100;
            Answer answer = new Answer();
            long result = answer.Difference(lim);

            Console.WriteLine($"The difference between the sum of the squares of the first {lim} " +
                $"natural numbers and the square of the sum is {result}");
            Console.ReadKey(true);
        }
    }
}
