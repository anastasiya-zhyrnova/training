Feature: Workflow
	
	As a User,
	I want to be able to find and add product to the cart that I want to order at the shop,
	So that I can proceed with my order

Scenario: 01 Search the product
	Given I am on the 'Main' page
	When I perform search of the 'IPhone' product
	Then only items related to the 'IPhone' product are present in search results 

Scenario: 02 Add item to the cart
	Given I am on the 'Main' page
	And I perform search of the 'IPhone' product 
	#And I select 'Мобильные телефоны' category
	And I focus my search in 'Мобильные телефоны' category	
	When I add product to the cart
	Then product is added to the cart

Scenario: 03 Delete item from the cart
	Given I am on the 'Main' page
	And I perform search of the 'IPhone' product
	And I focus my search in 'Мобильные телефоны' category
	And I add product to the cart
	When I delete product from the cart
	Then product is no longer present in my cart

#Scenario: 04 Proceed to the order 
#	Given I am on the 'Main' page
#	And I perform search of the 'IPhone' product
#	And I focus my search in 'Мобильные телефоны' category	
#	And I add product to the cart
#	When I proceed to the order
#	Then I first step of order placement process is completed successfully
#	

	
