#pragma once
#ifndef MAP_H
#define MAP_H

#include "Rooms.h"

#include <iostream>
#include<fstream>
#include<string>
#include <map>
#include <list>

class Map
{
public:
	Rooms* rooms = nullptr;

	int currentId = 0;		// Stores current room Id
	int newId = 0;			// Stores the next room Id in whic the player wants to go
	std::string output;		// Stores output to be displayed to the user

	std::map <int, std::string> mapId;		// Map which stores RoomId as key and RoomName as value
	std::map <int, Rooms*> roomsList;		// Map which stores RoomId as key and the pointer to the Room Class where the details of the room are stored

	Map();
	~Map();

	std::string& getRoomName();			// Gets Current room name
	std::string& getRoomDescription();	// Gets current room description
	std::string& getItems();	// Gets items in the current room
	std::string& pickItem(std::string&);	// Methos to return and set the picked item
	std::string& checkAccess(std::string&, std::list<std::string>&, int&);	// Checks if room is accessible or needs an item to get through
	void removeItem(std::string&);	// removes the item from the room after it has been picked by the user
	bool& hasEnemies();	// Method to check if the room has enemies

	Rooms* getRoom();	// Method to return the pointer of the current Room Class
};
#endif // !MAP_H
