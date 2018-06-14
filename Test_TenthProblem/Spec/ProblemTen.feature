Feature: ProblemTen
	In order to solve Problem 10
	As a math enthusiast
	I want to be told the sum of prime numbers below a limit

@Given
Scenario: Prime numbers below 10
	Given I have a limit of 10
	When I sum the primes
	Then the result should be 17
