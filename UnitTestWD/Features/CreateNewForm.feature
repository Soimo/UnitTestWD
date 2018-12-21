Feature: CreateNewForm
I want to create a new Form for the new Employee

Scenario: Create new Form
	Given Index page "file:///C:/Users/admin/source/repos/UnitTestWD/UnitTestWD/bin/Debug/Index.html" is opened
	And I assert button New Form is present
	When I press New Form button
	And I fill new Form
	Then Form page is filled
