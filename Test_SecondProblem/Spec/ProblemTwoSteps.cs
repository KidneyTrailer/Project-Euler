using Microsoft.VisualStudio.TestTools.UnitTesting;
using SecondProblem.Solution;
using System;
using TechTalk.SpecFlow;

namespace Test_SecondProblem.Spec
{
    [Binding]
    public class ProblemTwoSteps
    {
        readonly Answer _answer = new Answer();
        long[] fibs;

        [Given(@"I have the first (.*) Fibonacci terms")]
        public void GivenIHaveTheFirstFibonacciTerms(int terms)
        {
            fibs = _answer.Fib(terms);
        }
        
        [Given(@"I have Fibonacci terms less than (.*)")]
        public void GivenIHaveFibonacciTermsLessThan(int lim)
        {
            fibs = _answer.Fib(0, lim);
        }
        
        [Then(@"the result should have (.*) as the last term")]
        public void ThenTheResultShouldHaveAsTheLastTerm(int expected)
        {
            Assert.AreEqual(expected, fibs[fibs.Length - 1]);
        }
    }
}
