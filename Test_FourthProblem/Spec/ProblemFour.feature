Feature: ProblemFour
	In order to solve Problem 4
	As a math enthusiast
	I want to be told if a number is a palendrome

@Given
Scenario: Largest palendrome from a product of 2 numbers
	Given I have entered 99
	And I have also entered 99
	When I get the largest palendrome
	Then the result should be 9009
