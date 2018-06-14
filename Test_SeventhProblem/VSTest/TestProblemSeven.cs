using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeventhProblem.Solution;

namespace Test_SeventhProblem.VSTest
{
    [TestClass]
    public class TestProblemSeven
    {
        readonly Answer _answer = new Answer();

        [TestMethod]
        public void TestIsPrime()
        {
            Assert.IsFalse(_answer.IsPrime(28));
            Assert.IsTrue(_answer.IsPrime(29));
        }

        [TestMethod]
        public void TestNthPrime()
        {
            int term = 5;
            long expected = 11L;
            long result = _answer.NthPrime(term);
            Assert.AreEqual(expected, result);
            term = 6;
            expected = 13;
            result = _answer.NthPrime(term);
            Assert.AreEqual(expected, result);
        }
    }
}
