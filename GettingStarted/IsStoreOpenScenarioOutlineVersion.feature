Feature: Check to see if the store is open - outline version
	As a potential customer
	I want to know if your store is open
	So I don't waste my time driving there if it isn't
	Store Hours:
	M-Th 8-10
	Fri 8-11
	Sat 10-8
	Sun 10-6

Scenario Outline: Testing multiple dates and times
	Given it is a certain <date> and <time>
	Then The store <isornot> open at that time

	Examples:
		| date       | time     | isornot |
		| 12/20/2019 | 12:00 PM | is      |
		| 12/12/2019 | 9:00 AM  | is      |
		| 01/03/2019 | 6:00 AM  | isnot   |
		| 12/12/2019 | 11:00 PM | isnot   |
		| 12/14/2019 | 9:00 AM  | isnot   |
		| 12/14/2019 | 11:00 AM | is      |
		| 12/12/2019 | 8:00 AM  | is      |
		| 12/12/2019 | 10:00 PM | isnot   |