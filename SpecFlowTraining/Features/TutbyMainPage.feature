Feature: TutbyMainPage
	Check navigation to the main page
	Verify all components and sections are present

@mytag
Scenario: Verify all sections are present
	Given I navigate to home page
	Then I verify title is equal to 'Белорусский портал TUT.BY. Новости Беларуси и мира'
