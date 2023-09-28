using NUnit.Framework;

namespace SpecFlowCalculatorTests.Steps;

[Binding]
[Scope(Feature = "UsingCalculatorMTBF")]
public class AvailabilityStepDefinitions
{
    private readonly TestContext _testContext;

    public AvailabilityStepDefinitions(TestContext testContext)
    {
        _testContext = testContext;
    }

    private double _result;
    private double _aResult;

    [Given(@"I have a calculator")]
    public void GivenIHaveACalculator()
    {
        _testContext.Calculator = new Calculator();
    }
    
    [When(@"I have entered (.*) and (.*) into the calculator and press MTBF")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndPressMtbf(double p0, double p1)
    {
        _result = _testContext.Calculator.MTBF(p0, p1);

        _aResult = Math.Round(p0 / _result,2);
    }

    [Then(@"the availability result should be (.*)")]
    public void ThenTheAvailabilityResultShouldBe(double p0)
    {
        Assert.That(_aResult, Is.EqualTo(p0));
    }

    [When(@"I have entered (.*) and (.*) into the calculator and press Availability")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAvailability(int p0, int p1)
    {
        _aResult = _testContext.Calculator.Availability(p0, p1);
    }
}