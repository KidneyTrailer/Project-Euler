using SecondProblem.Solution;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_SecondProblem.VSTest
{
    [TestClass]
    public class TestProblemTwo
    {
        readonly Answer _answer = new Answer();
     
        [TestMethod]
        public void TestEvenVals()
        {
            long[] test = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            long[] expected = { 2, 4, 6, 8 };
            long[] result = _answer.EvenVals(test);
            Assert.AreEqual(expected.Length, result.Length);
            for (int i = 0; i < expected.Length;i++) { Assert.AreEqual(expected[i], result[i]); }
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestFib()
        {
            int lim = 400;
            int terms = 10;
            long[] fibs = _answer.Fib(terms);
            Assert.AreEqual(10, fibs.Length);
            fibs = _answer.Fib(0, lim);
            Assert.AreNotEqual(lim, fibs.Length);
            fibs = _answer.Fib(10, 10);
        }

        [TestMethod]
        public void TestSum()
        {
            long[] test = { 3, 6, 9 };
            int expected = 18;
            Assert.AreEqual(expected, _answer.Sum(test));
        }
    }
}
