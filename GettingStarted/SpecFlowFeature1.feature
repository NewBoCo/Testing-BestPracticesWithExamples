Feature: Check to see if the store is open
	As a potential customer
	I want to know if your store is open
	So I don't waste my time driving there if it isn't

@mytag
Scenario: Check if store is open at 12/11/2019 5:00PM
	Given It is currently 12/11/2019 at 5:00PM
	Then The store is open

Scenario: Check if store is open at 12/15/2019 11:00PM
	Given It is currently 12/15/2019 at 11:00PM
	Then The store is closed