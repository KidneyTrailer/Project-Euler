using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TenthProblem.Solution;

namespace Test_TenthProblem.VSTest
{
    [TestClass]
    public class TestProblemTen
    {
        readonly Answer _answer = new Answer();

        int test;
        long[] expected, result;

        [TestMethod]
        public void TestFindPrimes()
        {
            test = 10;
            expected = new long[] { 2L, 3L, 5L, 7L};
            result = _answer.FindPrimes(test);
            Assert.AreEqual(expected.Length, result.Length);
            for (int i = 0; i < expected.Length; i++)
            { Assert.AreEqual(expected[i], result[i]); }
        }

        [TestMethod]
        public void TestIsPrime()
        {
            test = 29;
            Assert.IsTrue(_answer.IsPrime(test));
            test = 28;
            Assert.IsFalse(_answer.IsPrime(test));
        }

        [TestMethod]
        public void TestSum()
        {
            long[] testL = new long[] { 4L, 10L, 6L };
            Assert.AreEqual(20L, _answer.Sum(testL));
        }
    }
}
