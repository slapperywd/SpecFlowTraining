Feature: ScopedScenarios
	Testing Specflow [Scope] attribute 

@Ui @scoped
Scenario: Scope attribute test
	Given I navigate to codewars homepage 
	Then home page title is Train with Programming Challenges/Kata | Codewars
