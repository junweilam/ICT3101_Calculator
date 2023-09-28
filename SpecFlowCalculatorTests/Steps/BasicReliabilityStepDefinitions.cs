using NUnit.Framework;

namespace SpecFlowCalculatorTests.Steps;

[Binding]
[Scope(Feature = "UsingCalculatorBasicReliability")]
public class BasicReliabilityStepDefinitions
{
    private readonly TestContext _testContext;

    public BasicReliabilityStepDefinitions(TestContext testContext)
    {
        _testContext = testContext;
    }

    private double _result;

    [Given("I have a calculator")]
    public void GivenIHaveACalculator()
    {
        _testContext.Calculator = new Calculator();
    }
    
    [When(@"I have entered (.*), (.*) and (.*) into the calculator and press CFI")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndPressMusa(int p0, int p1, int p2)
    {
        _result = _testContext.Calculator.CurrentFailureIntensity(p0, p1, p2);
    }
    
    
    [When(@"I have entered (.*), (.*) and (.*) into the calculator and press failures")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndPressFailures(int p0, int p1, int p2)
    {
        _result = _testContext.Calculator.NumberOfFailures(p0, p1, p2);
    }

    [Then(@"the current failure intensity is (.*)")]
    public void ThenTheCurrentFailureIntensityIs(int p0)
    {
        Assert.That(_result, Is.EqualTo(p0));
    }



    [Then(@"the average number of expected failures is (.*)")]
    public void ThenTheAverageNumberOfExpectedFailuresIs(int p0)
    {
        Assert.That(_result, Is.EqualTo(p0));
    }

}