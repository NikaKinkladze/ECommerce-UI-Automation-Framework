Feature: Edge case scenarios

A short summary of the feature

@SpecialUrl
Scenario: Direct URL Access Without Login
	Given I open inventory page
	Then I verify need to login error message

Scenario: Refresh During Checkout
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
	When I refresh the page
	Then I verify URL is correct
	And cart is not empty