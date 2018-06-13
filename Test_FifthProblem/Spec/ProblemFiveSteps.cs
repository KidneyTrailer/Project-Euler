using FifthProblem.Solution;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace Test_FifthProblem.Spec
{
    [Binding]
    public class ProblemFiveSteps
    {
        readonly Answer _answer = new Answer();
        int rangeLim;
        long result;

        [Given(@"I have a range ending in (.*)")]
        public void GivenIHaveARangeEndingIn(int lim)
        {
            rangeLim = lim;
        }
        
        [When(@"I find the smallest number divisible by that range")]
        public void WhenIFindTheSmallestNumberDivisibleByThatRange()
        {
            result = _answer.SmallestNumDivisibleByRange(rangeLim);
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(long expected)
        {
            Assert.AreEqual(expected, result);
        }
    }
}
