Feature: Login and create the New workspace for APS application
	
Background: Pre-Condition
	Given user is on Home page
	And Home page is visible

Scenario: Login flow of APS 
	Given user is at login page 
	When the user click on login button
	Then user is present with name window
	And user enter the email address<rahoulviinoaday@fs.co.uk>
	When the user click on Next button
	And user enter the password<Rvaishu$25>
	When the user click on Next button2
	Then user is present with confirmation screen
	When user click on yes button 
	Then User should be at home page 



Scenario: Create a new workspace
	When user is click on Create new workspce
	Then User should see the new workspace form 
	When  User enter the details in form details
	When click on Create button 
	Then New workspace should be created
	And USer should be at Home page 