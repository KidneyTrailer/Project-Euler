using EighthProblem.Solution;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace Test_EighthProblem.Spec
{
    [Binding]
    public class ProblemEightSteps
    {
        readonly Answer _answer = new Answer();
        string desiredString;
        int adjacencies;
        String result;

        [Given(@"I have a thousand digit long number")]
        public void GivenIHaveAThousandDigitLongNumber()
        {
            desiredString = _answer._number;
        }
        
        [Given(@"I have (.*) adjacencies")]
        public void GivenIHaveAdjacencies(int adj)
        {
            adjacencies = adj;
        }
        
        [When(@"I find the largest product")]
        public void WhenIFindTheLargestProduct()
        {
            result = _answer.FindMaxProductFromString(adjacencies, desiredString);
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(String expected)
        {
            Assert.AreEqual(expected, result);
        }
    }
}
