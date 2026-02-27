Feature: Product Module


Scenario: Sort Products Low to High
	Given I input username
	And I input password
	When I click log in button
	And Choose Price (low to high) from filter dropdown
	Then I verify products are sorted from Price (low to high)

Scenario: Add Multiple Products to Cart
	Given I input username
	And I input password
	When I click log in button
	And I add 3 products to cart
	Then Cart should contain 3 products

Scenario: Remove Product From Cart
	Given I input username
	And I input password
	When I click log in button
	And I add 3 products to cart
	And I click on cart icon
	And I remove random item from cart
	Then Cart should contain 2 products