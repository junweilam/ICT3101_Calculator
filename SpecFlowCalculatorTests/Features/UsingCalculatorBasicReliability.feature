Feature: UsingCalculatorBasicReliability
	In order to calculate the Basic Musa model's failures/intensities

@Musa
Scenario: Calculate Current Failure Intensity
	Given I have a calculator
	When I have entered 10, 50 and 100 into the calculator and press CFI
	Then the current failure intensity is 5
	
@Musa
Scenario: Calculate Average Number of expected failures
	Given I have a calculator
	When I have entered 10, 100 and 10 into the calculator and press failures
	Then the average number of expected failures is 63
	
