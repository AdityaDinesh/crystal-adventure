#pragma once
#ifndef _ROOMS_H
#define _ROOMS_H

#include "json.hpp"
#include <list>
#include <string>

class Rooms
{
public:
	int nextRoom[4];	// Stores ids of the next Rooms
	int nextRoomId = 0;	// Stores the id of the room the player wants to go to
	std::string description;	// Stores the description of the room
	bool isAccessible = false;	// checks if room is accessible
	std::string accessCondition;	// Stores condition to access the room
	std::string accessItem;	// Stores the item required to open this room
	std::list <std::string> items;	// Stores the items available in the room
	std::string enemyName;	// Stores name of enemy in the room
	std::string enemyWeapon;  // Stores name of enemy weapon in the room
	int enemyHealth = 0; // Stores health of enemy in the room
	int enemyDamage = 0; // Stores damage power of enemy in the room
	std::string itemList;	// String to return the item picked by player

	Rooms();
	~Rooms();

	void addRoomData(json::JSON&);	// Loads the data of the room
	int& getNextloc(int&);			// Method to return next room id
	std::string& itemsAvailable();	// Method to check the items available in the room
	std::string& findItem(std::string&);	// Method which finds the item the player wants to pick
	void removeItem(std::string&);	// Method to remove items picked by the plpayer
};

#endif // !_ROOMS_H
