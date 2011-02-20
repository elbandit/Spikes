Feature: Calculate Monthly repayment
	In order to know what I can afford
	As a homebuyer
	I want to calculate the monthly repayment fees for a loan

Scenario: Calculate monthly repayment
	Given I am on the loan repayment calculator page
	And that I have entered a loan amount of "200000"
	And a repayment term of "30" years
	And an interest rate of "10"%
	When I click the calculate monthly repayment button
	Then I will be shown a monthly repayment of "1767.99"