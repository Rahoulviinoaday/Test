Feature: Home page 
	
Background: Pre-Condition
	When User enter login details 
	Then User is present navigate to Home page 

Scenario: Navigate to side panel
	When User click on Account link 
	Then Account page should be display
	When User click on helplink link 
	Then Help page should be display
	When User click on setting link 
	Then Setting page should be display
	When User click on About link 
	Then About page should be display
	When User click on Home link 
	Then Home page should be display

Scenario: Upload file 
	When User click on Upload link
	Then User able to select and upload the file 

Scenario: Create new workspace 
	When User click on new workspace 
	Then User should get the new form page
	When User enter the form deatils 
	And  Click on create button 
	Then New workspace should be created
	
Scenario: Add Medical Records  workspace 
	When User click on processed medical record
	Then User should get the Add Medical records pop up window
	When User select workspace from dropdown
	And User Click on Add Button 
	Then Process medical record should be added in workspace

Scenario: Delete  workspace 
	When User click on delete workspace 
	Then User should get the confirmation pop up
	When User click on Yes button 
	Then Workspace should be deleted
