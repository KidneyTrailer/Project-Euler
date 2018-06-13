using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProblem.Solution
{
    public class Answer
    {
        public int[] GetNaturalNums(int lim)
        {
            int[] result = new int[lim];
            for (int i = 1; i < lim; i++) { result[i - 1] = i; }
            return result;
        }

        public int[] MultiplesOf(int[] quotients, int[] divisors)
        {
            List<int> result = new List<int>();
            foreach(int q in quotients)
            {
                foreach(int d in divisors)
                {
                    if (q % d == 0 && !result.Contains(q)) { result.Add(q); }
                }
            }
            return result.ToArray();
        }

        public int Sum(int[] nums)
        {
            int total = 0;
            foreach(int i in nums) { total += i; }
            return total;
        }

        public static void Main(String[] args)
        {
            int lim = (int)1E3;
            int[] divisors = { 3, 5 };
            Answer answer = new Answer();

            int[] nums = answer.GetNaturalNums(lim);
            nums = answer.MultiplesOf(nums, divisors);

            Console.WriteLine($"The sum of all the multiples of 3 or 5 below {lim} is {answer.Sum(nums)}");
            Console.ReadKey(true);
        }
    }
}
