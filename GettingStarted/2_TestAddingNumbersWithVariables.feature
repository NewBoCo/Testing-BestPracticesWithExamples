Feature: TestAddingNumbersWithVariables
	In order to avoid writing a lot of extra testing code
	I want to be able to use variables in my SpecFlow tests

@mytag
Scenario: Add 1 and 2
	Given I have the numbers 1 and 2
	When I add them together
	Then they should add up to 3

Scenario: Add 3 and 4
	Given I have the numbers 3 and 4
	When I add them together
	Then they should add up to 7

Scenario: Add 101 and 1332
	Given I have the numbers 101 and 1332
	When I add them together
	Then they should add up to 1433