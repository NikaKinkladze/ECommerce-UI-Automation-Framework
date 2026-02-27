Feature: Checkout Module


Scenario: Checkout Validation Errors
	Given I input username
	And I input password
	When I click log in button
	And I add 1 products to cart
	And I click on cart icon
	And I click on checkout button
	And I click on continue button
	Then I verify error message is displayed

Scenario: Complete Order Successfully
	Given I input username
	And I input password
	When I click log in button
	And I add 1 products to cart
	And I click on cart icon
	And I click on checkout button
	And I input first name
	And I input last name
	And I input postal code
	And I click on continue button
	And I click on finish button
	Then I verify order is completed successfully