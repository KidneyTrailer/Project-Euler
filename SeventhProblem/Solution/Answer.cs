using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeventhProblem.Solution
{
    public class Answer
    {
        public bool IsPrime(long x)
        {
            if (x < 2) { return false; }
            else if (x == 2) { return true; }
            for (int i = 2; i < Math.Ceiling(Math.Sqrt(x)) + 1; i++)
            { if (x % i == 0) { return false; } }
            return true;
        }

        public long NthPrime(int terms)
        {
            long candidate = 0L;
            long[] primes = new long[terms];
            for(int i = 0; i < terms; i++)
            {
                while(!IsPrime(candidate)) { candidate++; }
                primes[i] = candidate;
                candidate++;
            }
            return primes[terms - 1];
        }

        public static void Main(String[] args)
        {
            int term = 10001;
            Answer answer = new Answer();
            long result = answer.NthPrime(term);

            Console.WriteLine($"The {term}th prime number is {result}");
            Console.ReadKey(true); }
    }
}
