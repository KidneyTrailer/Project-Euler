Feature: ProblemNine
	In order to solve Problem 9
	As a math enthusiast
	I want to be told the sum of a Pythagorean triplet

@mytag
Scenario: Add two numbers
	Given I have a pyTriple from [3, 2]
	When I sum it
	Then the result should be 30
