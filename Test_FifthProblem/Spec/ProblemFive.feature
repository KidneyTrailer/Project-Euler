Feature: ProblemFive
	In order to solve Problem 5
	As a math enthusiast
	I want to be told the smallest number divisible by a range of numbers

@Given
Scenario: 1 to 10
	Given I have a range ending in 10
	When I find the smallest number divisible by that range
	Then the result should be 2520
