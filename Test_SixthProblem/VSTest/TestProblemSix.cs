using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SixthProblem.Solution;

namespace Test_SixthProblem.VSTest
{
    [TestClass]
    public class TestProblemSix
    {
        readonly Answer _answer = new Answer();
        int lim = 10;

        [TestMethod]
        public void TestDifference()
        {
            long expected = 2640L;
            long result = _answer.Difference(lim);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestSquareOfSum()
        {
            long expected = 3025L;
            long result = _answer.SquareOfSum(lim);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestSumOfSquares()
        {
            long expected = 385L;
            long result = _answer.SumOfSquares(lim);
            Assert.AreEqual(expected, result);
        }
    }
}
