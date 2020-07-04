#pragma once

#include <string>
#include <map>

class ItemManager
{
public:
	ItemManager();
	~ItemManager();

	std::map<std::string, int> itemPower;			// Map which stores item name as a key and damage power as a value
	std::map<std::string, std::string> bossItems;	// Map which stores boss name as a key and the items they possess as a value
	std::map<std::string, std::string>enemyWeakness; // Map which stores item name as key and enemy that are weak against them as a value

	int damage = 0;		// Stores damage power of the item that is used by the user to attack

	void loadValues();	// Loads all above maps
	int& attackWithWeapon(std::string&, std::string&);	// method to set the damage value

};

