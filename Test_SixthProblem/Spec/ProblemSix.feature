Feature: ProblemSix
	In order to solve Problem 6
	As a math enthusiast
	I want to be told the difference between the sum of squares and the square of the sum

@Given
Scenario: Add two numbers
	Given I have a range of the first 10 numbers
	When I get the difference
	Then the result should be 2640
