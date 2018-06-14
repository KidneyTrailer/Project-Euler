using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeventhProblem.Solution;
using TechTalk.SpecFlow;

namespace Test_SeventhProblem.Spec
{
    [Binding]
    public class ProblemSevenSteps
    {
        readonly Answer _answer = new Answer();
        int term;
        long result;

        [Given(@"I have (.*) terms")]
        public void GivenIHaveTerms(int terms)
        {
            term = terms;
        }
        
        [Given(@"I find the last term")]
        public void GivenIFindTheLastTerm()
        {
            result = _answer.NthPrime(term);
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, result);
        }
    }
}
