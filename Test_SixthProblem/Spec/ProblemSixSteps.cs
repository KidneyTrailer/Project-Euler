using Microsoft.VisualStudio.TestTools.UnitTesting;
using SixthProblem.Solution;
using TechTalk.SpecFlow;

namespace Test_SixthProblem.Spec
{
    [Binding]
    public class ProblemSixSteps
    {
        readonly Answer _answer = new Answer();
        int range;
        long result;

        [Given(@"I have a range of the first (.*) numbers")]
        public void GivenIHaveARangeOfTheFirstNumbers(int range)
        {
            this.range = range;
        }
        
        [When(@"I get the difference")]
        public void WhenIGetTheDifference()
        {
            result = _answer.Difference(range);
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(long expected)
        {
            Assert.AreEqual(expected, result);
        }
    }
}
