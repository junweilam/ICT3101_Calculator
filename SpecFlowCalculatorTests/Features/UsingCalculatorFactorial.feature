Feature: UsingCalculatorFactorial
	Simple calculator for adding two numbers

@Factorial
Scenario: Factorial of a number
	Given I have a calculator
	When I have entered 4 into the calculator and press factorial
	Then the result equals 24
	
@Factorial
Scenario: Factorial of the number zero
	Given I have a calculator
	When I have entered 0 into the calculator and press factorial
	Then the result equals 1