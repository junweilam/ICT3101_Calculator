using ICT3101_Calculator;
using Moq;
using NUnit.Framework;

namespace ICT3101_Caculator.UnitTests;

[TestFixture]
public class AdditionalCalculatorTests
{
    private Calculator _calculator;
    private Mock<IFileReader> _mockFileReader;
    
    [SetUp]
    public void SetUp()
    {
        _mockFileReader = new Mock<IFileReader>();
        _mockFileReader.Setup(fr =>
            fr.Read("MagicNumbers.txt")).Returns(new string[4] { "3", "4", "6", "3" });
        _calculator = new Calculator();
    }
}

