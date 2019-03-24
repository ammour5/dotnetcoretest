Feature: Withdraw from account
	In order to have cash
	As a client of the bank
	I want to withdraw money from my account
	
@mytag
Scenario: An existing client withdraws from his account
	Given an existing client account number "123456789" with 500.0 EUR in his account
	And   I have entered 80 into the calculator
	When he withdraws 50.0 EUR from is account
	Then the the new balance is 450.0 EUR

    