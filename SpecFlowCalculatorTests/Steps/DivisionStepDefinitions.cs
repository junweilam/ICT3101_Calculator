using NUnit.Framework;

namespace SpecFlowCalculatorTests.Steps
{

    [Binding]
    [Scope(Feature = "UsingCalculatorDivision")]
    public class DivisionStepDefinitions
    {
        private readonly TestContext _testContext;

        public DivisionStepDefinitions(TestContext testContext)
        {
            _testContext = testContext;
        }

        private double _result;
        private string _sResult;

        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            _testContext.Calculator = new Calculator();
        }
        

        [When(@"I have entered (.*) and (.*) into the calculator and press divide")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDivide(int p0, int p1)
        {
            if (p0 != 0 && p1 == 0)
            {
                _sResult = _testContext.Calculator.Divide(p0, p1);
            }
            else
            {
                _result = _testContext.Calculator.Divide(p0, p1);
            }
            
        }

        [Then(@"the result equals (.*)")]
        public void ThenTheResultEqualsPositiveInfinity(string p0)
        {
            Assert.That(_sResult, Is.EqualTo(p0));
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBeDivision(double p0)
        {
            Assert.That(_result,Is.EqualTo(p0));
        }
    }
}
