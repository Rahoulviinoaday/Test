﻿Feature: Login to APS application
	
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