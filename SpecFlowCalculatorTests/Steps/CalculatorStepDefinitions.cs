using NUnit.Framework;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class UsingCalculatorStepDefinitions
    {
        private Calculator _calculator;
        private double _result;
        private string _sResult;

        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            _calculator = new Calculator();
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press add")]
        public void WhenIHaveEnteredAndIntoCalculator(double p0, double p1)
        {
            _result = _calculator.Add(p0, p1);
        }

        // [When(@"I have entered (.*) and (.*) into the calculator and press divide")]
        // public void WhenIHaveEnteredDivideIntoCalculator(double p0, double p1)
        // {
        //     if (p0 != 0 && p1 == 0)
        //     {
        //         _sResult = _calculator.Divide(p0,p1);
        //     }
        //     else
        //     {
        //         _result = _calculator.Divide(p0, p1);
        //     }
        // }

        // [When(@"I have entered (.*) and (.*) into the calculator and press subtract")]
        // public void WhenIHaveEnteredSubtractIntoCalculator(double p0, double p1)
        // {
        //     _result = _calculator.Subtract(p0, p1);
        // }

        // [When(@"I have entered (.*) and (.*) into the calculator and press multiply")]
        // public void WhenIHaveEnteredMultiplyIntoCalculator(double p0, double p1)
        // {
        //     _result = _calculator.Multiply(p0, p1);
        // }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBeOnTheScreen(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        // [Then(@"the result equals (.*)")]
        // public void ThenTheResultReturnString(string p0)
        // {
        //     Assert.That(_sResult, Is.EqualTo(p0));
        // }
        
    }
}