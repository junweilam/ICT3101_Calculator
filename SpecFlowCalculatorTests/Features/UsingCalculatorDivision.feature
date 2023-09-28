Feature: UsingCalculatorDivision
	Simple calculator for dividing two numbers

@Division
Scenario: Dividing two numbers
	Given I have a calculator
	When I have entered 1 and 2 into the calculator and press divide
	Then the result should be 0.5

@Division
Scenario: Dividing zero by a number
	Given I have a calculator
	When I have entered 0 and 15 into the calculator and press divide
	Then the result should be 0
	
@Divisions
Scenario: Dividing by zeros
	Given I have a calculator
	When I have entered 15 and 0 into the calculator and press divide
	Then the result equals positive_infinity
	
@Divisions
Scenario: Dividing by zero by zero
	Given I have a calculator
	When I have entered 0 and 0 into the calculator and press divide
	Then the result should be 1