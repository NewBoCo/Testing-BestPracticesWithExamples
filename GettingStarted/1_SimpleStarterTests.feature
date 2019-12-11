Feature: Add Two Numbers Together
	As someone who likes adding numbers together
	When I add two numbers together
	I get the correct results

@mytag
Scenario: Add two numbers - no variables
	Given I have entered the numbers 1 and 2
	When I add 1 and 2 together
	Then the result should be 3