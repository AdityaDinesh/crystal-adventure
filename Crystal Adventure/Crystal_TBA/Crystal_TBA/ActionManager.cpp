#include "ActionManager.h"
#include "DataAnalyzer.h"

#include <iostream>

ActionManager::ActionManager()
{
	map = new Map();
	battle = new Battle();
	room = new Rooms();
}

ActionManager::~ActionManager()
{
	delete map;
	delete battle;
	delete room;
	map = nullptr;
	battle = nullptr;
	room = nullptr;
}

std::string& ActionManager::goAction(std::string& direction)
{
	bool status = false;
	int i = 0;
	for (i = 0; i < 4; i++)
	{
		if (direction.compare(direc[i]) == 0)
		{
			status = true;
			output = map->checkAccess(output, backpack,i);
			if (output == "")
			{
				roomName = map->getRoomName();
				description = map->getRoomDescription();
				items = map->getItems();
				hasEnemy = map->hasEnemies();
				if (hasEnemy)
				{
					room = map->getRoom();
					output = engageBattle(room);
					hasEnemy = false;
					return output;
				}
				else
				{
					output = "You are currently in area : " + roomName + "\n" + description + "\n\n" +
						"Items available in this area : " + items;
					return output;
				}
			}
			else
			{
				return output;
			}
			
		}
	}
	if (!status)
	{
		output = "Enter a Valid Direction !! North/West/East/South";
		return output;
	}
	output.clear();
	return output;
}

std::string& ActionManager::pickAction(std::string& pickUpItem)
{
	output = map->pickItem(pickUpItem);
	if (output == "")
	{
		output = "There is no item named " + pickUpItem + "in this area";
		return output;
	}
	else
	{
		backpack.push_back(output);
		map->removeItem(pickUpItem);
		output = "Picked Item :" + output;
		Data::Instance().itemPicked++;
		return output;
	}
}

std::string& ActionManager::lookAction(std::string& text)
{
	if (text.compare("around") == 0)
	{
		roomName = map->getRoomName();
		description = map->getRoomDescription();
		items = map->getItems();
		output = "You are currently in area : " + roomName + "\n" + description + "\n\n" +
			"Items available in this area : " + items;
		return output;
	}
	else
	{
		output = "";
		return output;
	}
}

std::string& ActionManager::inventoryAction(std::string& text)
{
	output.erase();
	if (text.compare("check") == 0)
	{
		if (backpack.size() > 0)
		{
			for (auto it : backpack)
			{
				output += "\n->" + it;
			}
			return output;
		}
		else
		{
			output = "There is nothing in your backpack";
			return output;
		}
	}
	else
	{
		output = "";
		return output;
	}
}

std::string& ActionManager::helpAction(std::string& text)
{
	if (text.compare("me") == 0)
	{
		output = "Hey There Following is the List of Actions you can do :- ";
		output += "\n 1. go <direction>";
		output += "\n 2. look around";
		output += "\n 3. pick <item>";
		output += "\n 4. inventory check";
		output += "\n 5. help me";
		return output;
	}
	else
	{
		output = "";
		return output;
	}
}

std::string& ActionManager::engageBattle(Rooms* room)
{
	battle->initialize(room, map, backpack);
	output = battle->isFinal();
	if (output == "")
	{
		backpack = battle->backpackItems;
		output = ".... XXXX .... XXXX ...";
	}
	return output;
}