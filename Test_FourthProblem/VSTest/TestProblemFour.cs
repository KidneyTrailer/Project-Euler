using System;
using FourthProblem.Solution;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_FourthProblem.VSTest
{
    [TestClass]
    public class TestProblemFour
    {
        readonly Answer _answer = new Answer();

        [TestMethod]
        public void TestFlip()
        {
            int test = 91;
            int result = _answer.Flip(test);
            Assert.AreEqual(19, result);
        }

        [TestMethod]
        public void TestIsPalendrome()
        {
            int test = 909;
            int test2 = 18;
            Assert.IsTrue(_answer.IsPalandrome(test), $"{test} is supposedly not a palendrome...");
            Assert.IsFalse(_answer.IsPalandrome(test2), $"{test2} is supposedly a palendrome...");
        }

        [TestMethod]
        public void TestLargestPalendrome()
        {
            int[] test = { 99, 99 };
            int expected = 9009;
            Assert.AreEqual(expected, _answer.LargestPalendrome(test[0], test[1]));
        }
    }
}
