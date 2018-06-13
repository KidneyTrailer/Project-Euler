using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthProblem.Solution
{
    public class Answer
    {
        public int Flip(int num)
        {
            int result = 0;
            while (num > 0)
            {
                result = (result * 10) + (num % 10);
                num /= 10;
            }
            return result;
        }

        public bool IsPalandrome(int num)
        {
            return num == Flip(num);
        }

        public int LargestPalendrome(int first, int second)
        {
            int largest = 0;
            for (int i = first; i > 0; i--)
            {
                for (int j = second; j > 0; j--)
                { if (IsPalandrome(i * j) && i * j > largest) { largest = i * j; } }
            }
            return largest;
        }

        public static void Main(String[] args)
        {
            Answer answer = new Answer();
            int[] target = { 999, 999 };
            int result = answer.LargestPalendrome(target[0], target[1]);

            Console.WriteLine($"The largest palendrome made from the product of two 3-digit numbers is {result}");
            Console.ReadKey(true);
        }
    }
}
