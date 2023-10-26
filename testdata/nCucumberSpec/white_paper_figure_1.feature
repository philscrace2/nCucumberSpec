Feature: Model Based Testing I

  Scenario Outline: Test1
    Given I start on "S1":
    When I "A1"
	Then I should be on  "S2"
  Scenario Outline: Test 2
    Given I am on "s1"
	When 1"A2"
	Then I should be on^{\prime\prime}S3^{\prime\prime}
  Scenario: Test 3
	Given I am on "S2"
	When 1"A3"
	Then I should be on "$1"
  Scenario: Test 4
    Given I am on "S3" 
	When 1"A4"
	Then I should be on "S3"