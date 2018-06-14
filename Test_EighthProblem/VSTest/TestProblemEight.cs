using System;
using EighthProblem.Solution;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_EighthProblem.VSTest
{
    [TestClass]
    public class TestProblemEight
    {
        readonly Answer _answer = new Answer();

        [TestMethod]
        public void TestFindMaxProductFromString()
        {
            int input = 4;
            String expected = "5832";
            Assert.AreEqual(expected, _answer.FindMaxProductFromString(input, _answer._number));
        }
    }
}
