Feature: Create account
	In order to manage my money
	As a visitor
	I want to create a account
	
@mytag
Scenario: Create an account with balance 0.0
	Given ...
	And  ...
	When he registrat
	Then the initial balance is 0.0


	Feature: Create client
  As a person
  I want to become client
  In order to have access to the bank services

  Scenario: Create a new client in the system
    Given "diego" born on "Feb 5, 1986"
    When he becomes a client
    Then the following information should be stored in the system:
      | username | birthday    |
      | diego    | Feb 5, 1986 |