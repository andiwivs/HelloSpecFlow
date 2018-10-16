﻿Feature: PlayerCharacter
	In order to play the game
	As a human player
	I want my character attributes to be correctly represented

Scenario: Taking no damage when hit doesn't affect health
	Given I'm a new player
	When I take 0 damage
	Then My health should be 100
