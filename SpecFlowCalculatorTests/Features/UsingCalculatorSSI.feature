Feature: UsingCalculatorSSI
	Simple calculator for SSI and Defect Density
	
# Epic: 
#	- Defect Density Calculator
#	- SSI Calculation for Successive Releases

#Test
	
# User Story:
#	- As a system quality engineer
#	I want to calculate the defect density of a system using the calculator
#	So that I can get the defect density of the system
@SSI
Scenario: Calculate SSI
	Given I have a calculator
	When I have entered 40, 20, 10 and 10 into the calculator and press SSI
	Then the new total number of SSI is 40

# User Story:
#	- As a system quality engineer
#	I want to calculate the new total number of SSI for successive system
#	releases using the calculator
#	So that I can get the new total number of SSI for the system
@SSI
Scenario: Calculate Defect Density
	Given I have a calculator
	When I have entered 100 and 50 into the calculator and press DD
	Then the defect density is 2

