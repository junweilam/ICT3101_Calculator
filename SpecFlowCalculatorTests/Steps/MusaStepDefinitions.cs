using NUnit.Framework;

namespace SpecFlowCalculatorTests.Steps;

[Binding]
[Scope(Feature = "UsingCalculatorMusa")]
public class MusaStepDefinitions
{
    private readonly TestContext _testContext;
    
    public MusaStepDefinitions(TestContext testContext)
    {
        _testContext = testContext;
    }

    private double _cfiResult;
    private double _fResult;

    [Given(@"I have a calculator")]
    public void GivenIHaveACalculator()
    {
        _testContext.Calculator = new Calculator();
    }
    [When(@"I have entered (.*), (.*), (.*) and (.*) into the calculator and press musa")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndPressMusa(double p0, double p1, double p2, double p3)
    {
        _cfiResult = _testContext.Calculator.LogModelFailureDensity(p0, p1, p2);
        _fResult = _testContext.Calculator.LogModelFailures(p0, p1, p3);
    }

    [Then(@"the CFI result is (.*)")]
    public void ThenTheCfiResultIs(double p0)
    {
        Assert.That(_cfiResult, Is.EqualTo(p0));
    }

    [Then(@"the expected failures result is (.*)")]
    public void ThenTheExpectedFailuresResultIs(double p0)
    {
        Assert.That(_fResult, Is.EqualTo(p0));
    }
}