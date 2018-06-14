using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;
using TenthProblem.Solution;

namespace Test_TenthProblem.Spec
{
    [Binding]
    public class ProblemTenSteps
    {
        readonly Answer _answer = new Answer();
        int limit;
        long sum;

        [Given(@"I have a limit of (.*)")]
        public void GivenIHaveALimitOf(int lim)
        {
            limit = lim;
        }
        
        [When(@"I sum the primes")]
        public void WhenISumThePrimes()
        {
            sum = _answer.Sum(_answer.FindPrimes(limit));
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(long expected)
        {
            Assert.AreEqual(expected, sum);
        }
    }
}
