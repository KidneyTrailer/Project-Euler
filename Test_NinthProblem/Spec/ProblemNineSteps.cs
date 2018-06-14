using Microsoft.VisualStudio.TestTools.UnitTesting;
using NinthProblem.Solution;
using System;
using TechTalk.SpecFlow;

namespace Test_NinthProblem.Spec
{
    [Binding]
    public class ProblemNineSteps
    {
        readonly Answer _answer = new Answer();
        int[] triple;
        int result;

        [Given(@"I have a pyTriple from \[(.*), (.*)]")]
        public void GivenIHaveAPyTripleFrom(int m, int n)
        {
            triple = _answer.GenPyTriple(m, n);
        }
        
        [When(@"I sum it")]
        public void WhenISumIt()
        {
            result = _answer.SumPyTriple(triple);
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, result);
        }
    }
}
