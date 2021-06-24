Feature: CreateNewWorkspace form 
	
Background: Pre-Condition
	Given user is on Home page
	And Home page is visible

Scenario: Create a new workspace
	When user is click on Create new workspce
	Then User should see the new workspace form 
	When  User enter the details in form details
	When click on Create button 
	Then New workspace should be created
	And USer should be at Home page 