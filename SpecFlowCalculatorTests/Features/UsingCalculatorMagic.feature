Feature: UsingCalculatorMagic
	In order to get the result from the magic generator
	I need to input a number

@Magic
Scenario: Positive Input
	Given I have a calculator
	When I have entered 1 into the calculator and press Gen
	Then the Gen result is 8

@Magic
Scenario: Negative Input
	Given I have a calculator
	When I have entered -1 into the calculator and press Gen
	Then the Gen result is -0

#@Magic
#Scenario: Exception Input
#	Given I have a calculator
#	When I have entered 5 into the calculator and press Gen
#	Then the user is presented with an error message