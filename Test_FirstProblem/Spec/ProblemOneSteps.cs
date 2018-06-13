using FirstProblem.Solution;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace Test_FirstProblem.Spec
{
    [Binding]
    public class ProblemOneSteps
    {
        readonly Answer _answer = new Answer();
        int[] nums;
        int result;

        [Given(@"I have all natural numbers less than (.*)")]
        public void GivenIHaveAllNaturalNumbersLessThan(int lim)
        {
            nums = _answer.GetNaturalNums(lim);
        }
        
        [Given(@"I have only multiples of (.*) or (.*)")]
        public void GivenIHaveOnlyMultiplesOfOr(int a, int b)
        {
            nums = _answer.MultiplesOf(nums, new int[] { a, b });
        }
        
        [When(@"I find the sum")]
        public void WhenIFindTheSum()
        {
            result = _answer.Sum(nums);
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, result);
        }
    }
}
