Feature: ProblemThree
	In order to solve Problem 3
	As a math enthusiast
	I want to be told the prime factors numbers

@Given
Scenario: Prime Factors of 13195
	Given I have entered 13195
	When I find the prime factors
	Then the result should be [5, 7, 13, 29]

@Desired
Scenario:  Largest Prime Factors
	Given I have entered 13195
	When I find the largest prime factor
	Then the result should be 29