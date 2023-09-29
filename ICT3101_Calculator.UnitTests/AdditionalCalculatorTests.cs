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
            fr.Read("MagicNumbers.txt")).Returns(new string[5] { "3", "4", "6", "3", "-2" });
        _calculator = new Calculator();
    }
    
    
    [Test]
    public void GenMagicNum_WhenGivenPositive()
    {
        // Act
        double result = _calculator.GenMagicNum(1, _mockFileReader.Object);
            
        // Assert
        Assert.That(result, Is.EqualTo(8));
    }

    [Test]
    public void GenMagicNum_WhenGivenNegative()
    {
        // Act
        double result = _calculator.GenMagicNum(-1, _mockFileReader.Object);
            
        // Assert
        Assert.That(result, Is.EqualTo(-0));
    }

    [Test]
    public void GenMagicNum_WhenGivenMoreThanTxt()
    {
        // Assert
        Assert.That(() => _calculator.GenMagicNum(6, _mockFileReader.Object), Throws.ArgumentException);
    }

    [Test]
    public void GenMagicNum_WhenGivenDecimal()
    {
        Assert.That(() => _calculator.GenMagicNum(0.5, _mockFileReader.Object), Throws.ArgumentException);
    }

    [Test]
    public void GenMagicNum_WhenMagicNegative()
    {
        // Act 
        double result = _calculator.GenMagicNum(4, _mockFileReader.Object);
        
        // Assert
        Assert.That(result, Is.EqualTo(4));
    }

    // [Test]
    // public void GenMagicNum_WhenMagicString()
    // {
    //     Assert.That(() => _calculator.GenMagicNum(5, _mockFileReader.Object), Throws.ArgumentException);
    // }
    //
    //
}

