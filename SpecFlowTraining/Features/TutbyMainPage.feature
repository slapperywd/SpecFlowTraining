Feature: TutbyMainPage
	Check navigation to the main page
	Verify all components and sections are present

@mytag
Scenario: Verify all sections are present
	Given I navigate to home page
	Then I verify title is equal to 'Белорусский портал TUT.BY. Новости Беларуси и мира'

Scenario Outline: Verify all tabs on header
	Given I navigate to home page
	Then I verify there is a tab on the header with name <tabname>

Examples: 
|tabname|
|Почта|
|Работа|
|Магазины|
