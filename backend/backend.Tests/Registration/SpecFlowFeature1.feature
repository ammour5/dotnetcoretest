Feature: Addition2
  In order to avoid silly mistakes
  As a math idiot
  I want to be told the sum of two numbers

  @mytag
  Scenario: Add three numbers
    Given I have 40 into the calculator
    And   I have entered 80 into the calculator
    And   I have entered 20 into the calculator
    When I press add
    Then the result should be 140 on the scre
 