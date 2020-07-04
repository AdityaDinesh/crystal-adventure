#include <algorithm>

#include "Map.h"

Map::Map()
{
	std::ifstream inputStream1("../../RenderSystem.json");
	std::string str1((std::istreambuf_iterator<char>(inputStream1)), std::istreambuf_iterator<char>());
	json::JSON map = json::JSON::Load(str1);

	for (auto iter : map.ArrayRange())
	{
		mapId.emplace(iter["id"].ToInt(), iter["name"].ToString());
		rooms = new Rooms();
		roomsList.emplace(iter["id"].ToInt(), rooms);

		rooms->addRoomData(iter);
	}
}

Map::~Map()
{
	delete rooms;
	rooms = nullptr;
}

std::string& Map::getRoomName()
{
	output = mapId.find(currentId)->second;
	return output;
}

std::string& Map::getRoomDescription()
{
	rooms = roomsList.find(currentId)->second;
	return rooms->description;
}

std::string& Map::getItems()
{
	rooms = roomsList.find(currentId)->second;
	output = rooms->itemsAvailable();
	return output;
}

std::string& Map::pickItem(std::string& askItem)
{
	rooms = roomsList.find(currentId)->second;
	output = rooms->findItem(askItem);
	return output;
}

std::string& Map::checkAccess(std::string& output, std::list<std::string>& backpack, int& dir)
{
	bool isAccessible = false;

	rooms = roomsList.find(currentId)->second;
	newId = rooms->getNextloc(dir);
	if(newId == 100)
	{
		output = "You cannot go in that direction";
		return output;
	}
	rooms = roomsList.find(newId)->second;
	if (rooms->isAccessible == true && newId != 100)
	{
		currentId = newId;
		output.erase();
		return output;
	}
	if(rooms->isAccessible == false)
	{
		for (auto it : backpack)
		{
			if (it.compare(rooms->accessItem) == 0)
			{
				std::cout << "You seem to have the " + it + " needed to access this area. "
								+ "Would you like to use it ? Y/N \n";
				std::cin >> output;
				transform(output.begin(), output.end(), output.begin(), ::tolower);
				if (output == "y")
				{
					isAccessible = true;
					rooms->isAccessible = true;
					currentId = newId;
					output.erase();
					if (it != "sapphire" && it != "amethyst")
					{
						backpack.remove(it);
					}
					return output;
				}
			}
		}
		if (!isAccessible)
		{
			output = rooms->accessCondition;
			return output;
		}
	}
}

void Map::removeItem(std::string& removeItem)
{
	rooms = roomsList.find(currentId)->second;
	rooms->removeItem(removeItem);
}

bool& Map::hasEnemies()
{
	bool status = true;
	rooms = roomsList.find(currentId)->second;
	if (rooms->enemyHealth > 0)
	{
		return status;
	}
	else
	{
		status = false;
		return status;
	}
	// TODO: insert return statement here
}

Rooms* Map::getRoom()
{
	rooms = roomsList.find(currentId)->second;
	return rooms;
}
