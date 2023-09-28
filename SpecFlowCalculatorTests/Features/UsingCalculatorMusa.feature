Feature: UsingCalculatorMusa
	In Order to get the failure intensity and expected failures of the systems
	I need to calculate them
	
# Epic:
# - Musa Logarithmic Model Integration

# User Story:
# 	As a system quality engineer
#	I want to use the Musa Logarithmic model calculations to calculate 
#	failure intensity using the calculator
#	with one command
#	So that I can get the failure intensity of the system

@MusaLog
Scenario: Calculating CFI
	Given I have a calculator
	When I have entered 10, 0.02, 50 and 10 into the calculator and press musa
	Then the CFI result is 3.68

# User Story:
#	As a system quality engineer
#	I want to use the Musa Logarithmic model calculations to calculate	
#	the  expected failures of the system
#	So that I can get the expected failures of the system
@MusaLog
Scenario: Calculating expected failures
	Given I have a calculator
	When I have entered 10, 0.02, 50 and 10 into the calculator and press musa
	Then the expected failures result is 55