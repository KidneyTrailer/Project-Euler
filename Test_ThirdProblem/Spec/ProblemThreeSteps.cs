using ThirdProblem.Solution;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_ThirdProblem.Spec
{
    [Binding]
    public class ProblemThreeSteps
    {
        readonly Answer _answer = new Answer();
        int findFactorsOf;
        long[] primeFacts;
        long result;

        [Given(@"I have entered (.*)")]
        public void GivenIHaveEntered(int num)
        {
            findFactorsOf = num;
        }
        
        [When(@"I find the prime factors")]
        public void WhenIFindThePrimeFactors()
        {
            primeFacts = _answer.PrimeFacts((long)findFactorsOf);
        }
        
        [When(@"I find the largest prime factor")]
        public void WhenIFindTheLargestPrimeFactor()
        {
            primeFacts = _answer.PrimeFacts((long)findFactorsOf);
            result = primeFacts[primeFacts.Length - 1];
        }
        
        [Then(@"the result should be \[(.*), (.*), (.*), (.*)]")]
        public void ThenTheResultShouldBe(int fir, int sec, int thir, int four)
        {
            long[] sol = { fir, sec, thir, four };
            Assert.AreEqual(sol.Length, primeFacts.Length);
            for (int i = 0; i < sol.Length;i++) { Assert.AreEqual(sol[i], primeFacts[i]); }
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, primeFacts[primeFacts.Length - 1]);
        }
    }
}
