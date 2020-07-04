#pragma once
#ifndef _ACTION_MANGER_H
#define _ACTION_MANGER_H
#include "Map.h"
#include "Battle.h"
#include "Rooms.h"

#include <string>

class ActionManager
{
public:
	Map* map = nullptr;
	Battle* battle = nullptr;
	Rooms* room = nullptr;

	bool hasEnemy;					// Value to check existence of enemy in the room
	std::string roomName;			// Store name of Room					
	std::string description;		// Store the room description
	std::string output;				// Store the output to be displayed
	std::string items;				// Stores the picked up item
	std::string direc[4] = { "north","west","east","south" };	// Reference for directions popssible

	std::list<std::string> backpack;	//list to store inventory items

	ActionManager();
	~ActionManager();

	std::string& goAction(std::string&);	// Go towards a direction
	std::string& pickAction(std::string&);	// Pick an item
	std::string& lookAction(std::string&);	// Display current room details
	std::string& inventoryAction(std::string&);	 // Check your inventory
	std::string& helpAction(std::string&);	// Displays available commands for the user to use

	std::string& engageBattle(Rooms*);	// Begin a battle with enemy
};

#endif // !_ACTION_MANGER_H
