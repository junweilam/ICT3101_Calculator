using NUnit.Framework;

namespace SpecFlowCalculatorTests.Steps;

[Binding]
[Scope(Feature = "UsingCalculatorFactorial")]
public class FactorialStepDefinitions
{
    private readonly TestContext _testContext;

    public FactorialStepDefinitions(TestContext testContext)
    {
        _testContext = testContext;
    }

    private double _result;

    [Given(@"I have a calculator")]
    public void GivenIHaveACalculator()
    {
        _testContext.Calculator = new Calculator();
    }
    
    [When(@"I have entered (.*) into the calculator and press factorial")]
    public void WhenIHaveEnteredIntoTheCalculatorAndPressFactorial(int p0)
    {
        _result = _testContext.Calculator.Factorial(p0);
    }

    [Then(@"the result equals (.*)")]
    public void ThenTheResultEquals(double p0)
    {
        Assert.That(_result, Is.EqualTo((p0)));
    }
}