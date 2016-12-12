Feature: SpecFlowFeature1
	login and logout on mail-service yandex.ru

@specRun
Scenario Outline: login
	Given I have entered <login> into login field
	And I Have entered <passwd> into the password field
	When I press enter into a password field
	Then the result sould display post list
	
Examples: 
| login           | passwd       |
| super.bizmartek | nfhfyhb87KGD |
| test            | test         |
	



