using FifthProblem.Solution;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_FifthProblem.VSTest
{
    [TestClass]
    public class TestProblemFive
    {
        readonly Answer _answer = new Answer();

        [TestMethod]
        public void TestIsDivisibleBy()
        {
            Assert.IsFalse(_answer.IsDivisibleBy(15, 4), "15 is supposedly divisible by 4");
            Assert.IsTrue(_answer.IsDivisibleBy(20, 5), "20 is supposedly not divisible by 5");
        }

        [TestMethod]
        public void TestIsDivisibleByRange()
        {
            Assert.IsTrue(_answer.IsDivisibleByRange(12, new long[] { 2, 3, 4, 6 }));
            Assert.IsFalse(_answer.IsDivisibleByRange(13, new long[] { 2, 3 }));
        }

        [TestMethod]
        public void TestMakeRange()
        {
            long test = 5;
            long[] expected = { 1, 2, 3, 4, 5 };
            long[] result = _answer.MakeRange(test);
            Assert.AreEqual(expected.Length, result.Length);
            for (int i = 0; i < expected.Length;i++) { Assert.AreEqual(expected[i], result[i]); }
        }

        [TestMethod]
        public void TestSmallestNumDivisibleByRange()
        {
            int test = 4;
            int expected = 12;
            Assert.AreEqual(expected, _answer.SmallestNumDivisibleByRange(test));
        }
    }
}
