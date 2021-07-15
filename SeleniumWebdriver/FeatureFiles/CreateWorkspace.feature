Feature: CreateWorkspace Pagination 
Background: Pre-Condition
	When User enter login details 
	Then User is present navigate to Home page 

@mytag
Scenario: Create new workspace 
	When user click on new workspace 
	Then user should get the new form page
	When user enter the form deatils 
	And Click on create button 
	Then new workspace should be created
