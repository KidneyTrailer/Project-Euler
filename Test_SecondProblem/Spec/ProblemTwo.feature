Feature: ProblemTwo
	In order to solve Problem 2
	As a math enthusiast
	I want to be told the sum Fibonacci numbers

@Given
Scenario: Get the first ten
	Given I have the first 10 Fibonacci terms
	Then the result should have 89 as the last term

@Limit
Scenario: Get the first ten using limit
	Given I have Fibonacci terms less than 90
	Then the result should have 89 as the last term
