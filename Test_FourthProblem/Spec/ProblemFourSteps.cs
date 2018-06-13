using FourthProblem.Solution;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace Test_FourthProblem.Spec
{
    [Binding]
    public class ProblemFourSteps
    {
        readonly Answer _answer = new Answer();
        int first, second, result;

        [Given(@"I have entered (.*)")]
        public void GivenIHaveEntered(int num)
        {
            first = num;
        }
        
        [Given(@"I have also entered (.*)")]
        public void GivenIHaveAlsoEntered(int num)
        {
            second = num;
        }
        
        [When(@"I get the largest palendrome")]
        public void WhenIGetTheLargestPalendrome()
        {
            result = _answer.LargestPalendrome(first, second);
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, result);
        }
    }
}
