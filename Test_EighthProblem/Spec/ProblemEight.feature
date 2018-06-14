Feature: ProblemEight
	In order to solve Problem 8
	As a math enthusiast
	I want to be told the greatest product among adjacencies

@Given
Scenario: Four adjacent numbers
	Given I have a thousand digit long number 
	And I have 4 adjacencies
	When I find the largest product
	Then the result should be 5832
