using NUnit.Framework;

namespace ICT3101_Caculator.UnitTests
{
    public class CalculatorTests
    {
        private Calculator _calculator;
        [SetUp]
        public void Setup()
        {
            // Arrange
            _calculator = new Calculator();
        }
        [Test]
        public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Add(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(30));
        }
        [Test]
        public void Subtract_WhenSubtractingTwoNumbers_ResultEqualToSubtract()
        {
            // Act
            double result = _calculator.Subtract(20, 10);
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }
        [Test]
        public void Multiply_WhenMultiplyingTwoNumbers_ResultEqualToMultiply()
        {
            // Act
            double result = _calculator.Multiply(10, 2);
            // Assert
            Assert.That(result, Is.EqualTo(20));
        }
        [Test]
        public void Divide_WhenDividingTwoNumbers_ResultEqualToDivide()
        {
            // Act
            double result = _calculator.Divide(10, 5);
            // Assert
            Assert.That(result, Is.EqualTo(2));
        }
        // [Test]
        // [TestCase(0,0)]
        // [TestCase(10,0)]
        // [TestCase(0,10)]
        // public void Divide_WithZeroAsInputs_ResultThrowArgumentException(double a, double b)
        // {
        //     Assert.That(() => _calculator.Divide(0, 0), Throws.ArgumentException);
        // }
        [Test]
        [TestCase(-3)]
        public void Factorial_WithNegativeAsInputs_ResultThrowArgumentException(double a)
        {
            Assert.That(() => _calculator.Factorial(a), Throws.ArgumentException);
        }
        [Test]
        public void Factorial_WhenFactorialNumber1_ResultEqualToFactorialNum1()
        {
            // Act
            double result = _calculator.Factorial(4);

            // Assert
            Assert.That(result, Is.EqualTo(24));
        }
        [Test]
        public void Triangle_AreaOfTriangle_ResultEqualToTriangleArea()
        {
            // Act
            double result = _calculator.Triangle(10, 2);

            // Assert
            Assert.That(result, Is.EqualTo(10));
        }
        [Test]
        [TestCase(0,3)]
        [TestCase(3,0)]
        [TestCase(-2,3)]
        [TestCase(3,-2)]
        public void Triangle_NegativeOrZeroInputs_ResultThrowArgumentException(double a, double b)
        {
            Assert.That(() => _calculator.Triangle(a, b), Throws.ArgumentException);
        }
        [Test]
        public void Circle_AreaOfCircle_ResultEqualToCircleArea()
        {
            // Act
            double result = System.Math.Round(_calculator.Circle(5),2);

            // Assert
            Assert.That(result, Is.EqualTo(78.54));
        }
        [Test]
        public void Circle_NegativeInput_ResultThrowArgumentException()
        {
            Assert.That(() => _calculator.Circle(-5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 5);

            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 4);

            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 3);

            // Assert
            Assert.That(result, Is.EqualTo(60));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest3_ResultThrowException()
        {
            Assert.That(() => _calculator.UnknownFunctionA(4, 5), Throws.ArgumentException);
            
        }
        [Test]
        [TestCase(-5,5)]
        [TestCase(5,-5)]
        public void UnknownFunctionA_WhenNegativeInputs_ResultThrowException(double a, double b)
        {
            Assert.That(() => _calculator.UnknownFunctionA(a, b), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest0_Result()
        {
            // Act 
            double result = _calculator.UnknownFunctionB(5, 5);
            // Assert 
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest1_Result()
        {
            // Act 
            double result = _calculator.UnknownFunctionB(5, 4);
            // Assert 
            Assert.That(result, Is.EqualTo(5));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest2_Result()
        {
            // Act 
            double result = _calculator.UnknownFunctionB(5, 3);
            // Assert 
            Assert.That(result, Is.EqualTo(10));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest3_ResultThrowArgumnetException()
        {
            // Act 
            // Assert 
            Assert.That(() => _calculator.UnknownFunctionB(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest4_ResultThrowArgumnetException()
        {
            // Act 
            // Assert 
            Assert.That(() => _calculator.UnknownFunctionB(4, 5), Throws.ArgumentException);
        }
        [Test]
        public void Factorial_WhenGivenDecimal_ResultThrowException()
        {
            // Assert
            Assert.That(() => _calculator.Factorial(2.11), Throws.ArgumentException);
        }


    }
}