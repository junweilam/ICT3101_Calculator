Feature: UsingCalculatorMTBF
	In order to calculate MTBF and Availability
	
@Availability
Scenario: Calculating MTBF
	Given I have a calculator
	When I have entered 200 and 10 into the calculator and press MTBF
	Then the availability result should be 0.95
	
@Availability
Scenario: Calculating Availability
	Given I have a calculator
	When I have entered 200 and 10 into the calculator and press Availability
	Then the availability result should be 0.95