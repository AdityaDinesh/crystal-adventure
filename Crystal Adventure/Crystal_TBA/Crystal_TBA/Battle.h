#pragma once

#include<string>
#include<map>
#include<list>
#include<vector>

#include "Map.h"
#include "Rooms.h"
#include "ItemManager.h"

class Battle
{
public:
	Battle();
	~Battle();

	ItemManager* itemManager = nullptr;
	Rooms* roomPtr = nullptr;
	Map* mapPtr = nullptr;

	std::string enemyName;			// Stores enemy name
	std::string enemyWeapon;		// Stores enemy weapon name
	std::string enemyItem;			// Stores the item that the enemy has in possession
	int enemyHealth = 0;			// Stores enemy health
	int enemyDamage = 0;			// Stores enemy damage power

	int playerHealth = 100;			// Stores player health
	int playerDamage = 0;			// Stores player damage power

	bool battleOn = true;			// Checks if battle has ended
	bool playerWin = true;			// Checks if player has won
	std::string end = "";			// Checks if the final boss has been defeated
	std::string input;				// Stores input from user
	std::string output;				// Displays output

	std::vector<std::string> result;	// Seperates the strings based on white spaces so as to parse the string easily
	std::list<std::string> backpackItems;	// Stores inventory items
	std::list<std::string>::iterator it;	// An iterator which is used to check if user is using an item from the backpack

	void initialize(Rooms*, Map*, std::list<std::string>&);	// initializes variables needed before battle
	void beginBattle();		// start the battle
	void endBattle();		// end the battle
	void playerAttack(std::string&);	//method for player attack
	void enemyAttack();		// method for enemy attack
	void parseInput(std::string&);	// methos to parse the user input
	std::string& isFinal();	// method whic returns a string to check if final boss has been defeated
};