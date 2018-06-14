using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NinthProblem.Solution;

namespace Test_NinthProblem.VSTest
{
    [TestClass]
    public class TestProblemNine
    {
        readonly Answer _answer = new Answer();

        [TestMethod]
        public void TestFindPyTriple()
        {
            int test = 12;
            int[] expected = { 3, 4, 5 };
            int[] result = _answer.FindPyTriple(test);
            Assert.AreEqual(expected.Length, result.Length);
            for (int i = 0; i < expected.Length;i++)
            { Assert.AreEqual(expected[i], result[i]); }
        }

        [TestMethod]
        public void TestGenPyTriple()
        {
            int testM = 4, testN = 3;
            int[] expected = { 7, 24, 25 };
            int[] result = _answer.GenPyTriple(testM, testN);
            Assert.AreEqual(expected.Length, result.Length);
            for (int i = 0; i < expected.Length; i++) { Assert.AreEqual(expected[i], result[i]); }
        }

        [TestMethod]
        public void TestSum()
        {
            int[] test = { 3, 4, 5 };
            int expected = 12;
            Assert.AreEqual(expected, _answer.SumPyTriple(test));
        }
    }
}
