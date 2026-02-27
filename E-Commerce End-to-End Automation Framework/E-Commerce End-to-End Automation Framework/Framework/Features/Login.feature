Feature: Login
I am user and I want to log in to application with correct credentials, incorrect credentials, locked credentials and empty fields.


Scenario: Successful log in
	Given I input username
	And I input password
	When I click log in button
	Then I am on products page

Scenario: Locked User Login
	Given I input locked user username
	And I input locked user password
	When I click log in button
	Then I verify locked user error message

Scenario: Invalid Login
	Given I input invalid user usename
	And I input invalid user password
	When I click log in button
	Then I verify invalid user error message

Scenario: Empty Fields Validation
	Given I click log in button
	Then I verify empty user error message