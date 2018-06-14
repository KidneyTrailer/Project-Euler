using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinthProblem.Solution
{
    public class Answer
    {
        public int[] FindPyTriple(int target)
        {
            for (int m = 2; m < target; m++)
            {
                for (int n = 1; n < m; n++)
                {
                    int[] candidate = GenPyTriple(m, n);
                    if (SumPyTriple(candidate) == target)
                    { return candidate; }
                }
            }

            return null;
        }

        public int[] GenPyTriple(int m, int n)
        {
            if (m < n) { throw new Exception("M must be greater than N."); }
            int[] result = new int[3];
            result[0] = m * m - n * n;
            result[1] = 2 * m * n;
            result[2] = m * m + n * n;
            return result;
        }

        public int SumPyTriple(int[] nums)
        {
            int sum = -1;
            if (Math.Pow(nums[0], 2) + Math.Pow(nums[1], 2) == Math.Pow(nums[2], 2))
            {
                sum =  nums[0] + nums[1] + nums[2];
            }
            return sum;
        }

        public static void Main(String[] args)
        {
            int target = 1000;
            Answer answer = new Answer();
            int[] sol = answer.FindPyTriple(target);
            int product = sol[0] * sol[1] * sol[2];

            Console.WriteLine($"The only Pythagorean Triple for which a + b + c = {target} " +
                $"is [{sol[0]}, {sol[1]}, {sol[2]}], its product is {product}");
            Console.ReadKey(true);
        }
    }
}
