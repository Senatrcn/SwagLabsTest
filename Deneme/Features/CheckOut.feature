Feature: CheckOut
This feature provides to check the Checkout functionality

Background: Navigate homepage
Given User navigates to login page
When User enters credentials 'standard_user' and 'secret_sauce'
And User clicks the login button
	Then User sees the products
	When User clicks the add to cart button	1 times
	And User sees the correct number 1 on the shopping cart item
	And User goes to cart page
	When User clicks the checkout button
	Then User sees personal information page
	When User add following details
		| Firstname     | Lastname		 | Postalcode |
		| Sena  		| Tercan         | 06060      |
	When User clicks the continue button
	Then User sees add information overview


Scenario: User should be able to navigate complete page
	When User clicks the finish button
	Then User navigate to complete page

Scenario: User should be able to cancel checkout process
	When User clicks the cancel button
	Then User sees the products
