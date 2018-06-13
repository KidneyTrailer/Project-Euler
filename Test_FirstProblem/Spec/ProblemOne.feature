Feature: ProblemOne
	In order to solve the first problem
	As a math enthusiast
	I want to be told the sum of multiple numbers

@Given
Scenario: Add multiples of 3 or 5 below 10
	Given I have all natural numbers less than 10
	And I have only multiples of 3 or 5
	When I find the sum
	Then the result should be 23
