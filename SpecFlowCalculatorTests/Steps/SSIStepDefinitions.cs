using NUnit.Framework;

namespace SpecFlowCalculatorTests.Steps;

[Binding]
[Scope(Feature = "UsingCalculatorSSI")]
public class SSIStepDefinitions
{
    public readonly TestContext _testContext;

    public SSIStepDefinitions(TestContext testContext)
    {
        _testContext = testContext;
    }

    private double _result;

    [Given(@"I have a calculator")]
    public void GivenIHaveACalculator()
    {
        _testContext.Calculator = new Calculator();
    }
    
    [When(@"I have entered (.*), (.*), (.*) and (.*) into the calculator and press SSI")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndPressSsi(int p0, int p1, int p2, int p3)
    {
        _result = _testContext.Calculator.SSI(p0, p1, p2, p3);
    }

    [Then(@"the new total number of SSI is (.*)")]
    public void ThenTheNewTotalNumberOfSsiIs(int p0)
    {
        Assert.That(_result, Is.EqualTo(p0));
    }

    [When(@"I have entered (.*) and (.*) into the calculator and press DD")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDd(int p0, int p1)
    {
        _result = _testContext.Calculator.DefectDensity(p0, p1);
    }

    [Then(@"the defect density is (.*)")]
    public void ThenTheDefectDensityIs(int p0)
    {
        Assert.That(_result, Is.EqualTo(p0));
    }
}