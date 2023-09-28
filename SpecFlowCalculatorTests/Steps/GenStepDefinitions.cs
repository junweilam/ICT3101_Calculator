using ICT3101_Calculator;
using NUnit.Framework;

namespace SpecFlowCalculatorTests.Steps;

[Binding]
[Scope(Feature = "UsingCalculatorMagic")]
public class GenStepDefinitions
{
    private readonly TestContext _testContext;

    public GenStepDefinitions(TestContext testContext)
    {
        _testContext = testContext;
    }

    private double result;

    [Given(@"I have a calculator")]
    public void GivenIHaveACalculator()
    {
        _testContext.Calculator = new Calculator();
    }
    
    [When(@"I have entered (.*) into the calculator and press Gen")]
    public void WhenIHaveEnteredIntoTheCalculatorAndPressGen(int p0)
    {
        result = _testContext.Calculator.GenMagicNum(p0, new FileReader());
    }

    [Then(@"the Gen result is (.*)")]
    public void ThenTheGenResultIs(int p0)
    {
        Assert.That(result, Is.EqualTo(p0));
    }

    [Then(@"the user is presented with an error message")]
    public void ThenTheUserIsPresentedWithAnErrorMessage()
    {
        Assert.IsInstanceOf<ArgumentException>("Input is larger than txt");
    }
}