using FirstProblem.Solution;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test_FirstProblem.VSTest
{
    [TestClass]
    public class TestProblemOne
    {
        readonly Answer _answer = new Answer();
        readonly Random _random = new Random();

        [TestMethod]
        public void TestGetNaturalNums()
        {
            int lim = _random.Next(100);
            int[] result = _answer.GetNaturalNums(lim);
            Assert.AreNotEqual(lim, result[result.Length - 1]);
            Assert.AreNotEqual(0, result[0]);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestMultiplesOf()
        {
            int[] tQ = { 15, 4, 9, 10, 17, 20 };
            int[] tD = { 5, 2 };
            int[] expected = { 15, 4, 10, 20 };
            int[] result = _answer.MultiplesOf(tQ, tD);
            Assert.AreEqual(expected.Length, result.Length);
            for (int i = 0; i < expected.Length; i++) { Assert.AreEqual(expected[i], result[i]); }
        }

        [TestMethod]
        public void TestSum()
        {
            int[] test = { 1, 2, 3, 4, 5 };
            int expected = 15;
            int result = _answer.Sum(test);
            Assert.AreEqual(expected, result);
        }
    }
}
