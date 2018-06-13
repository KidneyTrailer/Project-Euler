using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThirdProblem.Solution;

namespace Test_ThirdProblem.VSTest
{
    [TestClass]
    public class TestProblemThree
    {
        readonly Answer _answer = new Answer();

        [TestMethod]
        public void TestFactor()
        {
            long x = 20L;
            long[] expected = { 2, 4, 5, 10 };
            long[] result = _answer.Factor(x);
            Assert.AreEqual(expected.Length, result.Length);
            for (long l = 0; l < expected.Length; l++) { Assert.AreEqual(expected[l], result[l]); }
        }

        [TestMethod]
        public void TestIsPrime()
        {
            long x = 28, y = 29;
            Assert.IsFalse(_answer.IsPrime(x), $"{x} is supposedly prime...");
            Assert.IsTrue(_answer.IsPrime(y), $"{y} is supposedly composite...");
        }

        [TestMethod]
        public void TestPrimeFacts()
        {
            long test = 30;
            long[] expected = { 2, 3, 5 };
            long[] result = _answer.PrimeFacts(test);
            Assert.AreEqual(expected.Length, result.Length);
            for (long l = 0; l < expected.Length; l++) { Assert.AreEqual(expected[l], result[l]); }
        }
    }
}
