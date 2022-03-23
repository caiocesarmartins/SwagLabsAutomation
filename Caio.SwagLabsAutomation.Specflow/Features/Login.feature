Feature: Login
User should be able to login
A validation of username/password is made.
In case of invalid or empty username or password, an error must be prompted.
On succesfull login, the user must be redirected to the store page.

Background:
	Given I am in the login page

Scenario: Logging in with valid Username and Password
	Given I have filled the login form with 'standard_user' as username and 'secret_sauce' as password
	When I submit the login form
	Then I am in the Products page

Scenario: Error when trying to log in with empty Username
	Given I have filled the login form with '' as username and 'secret_sauce' as password
	When I submit the login form
	Then I am in the Login page
	And the error "Epic sadface: Username is required" is shown
