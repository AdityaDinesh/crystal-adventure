#include "Rooms.h"

Rooms::Rooms()
{
}

Rooms::~Rooms()
{
}

void Rooms::addRoomData(json::JSON& roomData)
{
	int i = 0;
	for (auto iter : roomData["nextLoc"].ArrayRange())
	{
		nextRoom[i] = iter.ToInt();
		i++;
	}

	isAccessible = roomData["accessible"].ToBool();
	accessCondition = roomData["accessibleCondition"].ToString();
	accessItem = roomData["accessItem"].ToString();
	description = roomData["description"].ToString();

	json::JSON enemyList = roomData["enemies"];
	enemyName = enemyList["name"].ToString();
	enemyHealth = enemyList["health"].ToInt();
	enemyDamage = enemyList["damage"].ToInt();
	enemyWeapon = enemyList["weapon"].ToString();

	json::JSON itemList = roomData["items"];
	for (auto iter : itemList.ArrayRange())
	{
		items.push_back(iter.ToString());
	}
}

int& Rooms::getNextloc(int& index)
{
	nextRoomId = nextRoom[index];
	return nextRoomId;
}

std::string& Rooms::itemsAvailable()
{
	itemList.clear();
	if (items.size() <= 0)
	{
		itemList = "None";
		return itemList;
	}
	else
	{
		for (auto it : items)
		{
			itemList += "\n ->" + it;
		}
		return itemList;
	}

}

std::string& Rooms::findItem(std::string& findItem)
{
	for (auto it : items)
	{
		if (findItem == it)
		{
			return findItem;
		}
	}
	findItem = "";
	return findItem;
	// TODO: insert return statement here
}

void Rooms::removeItem(std::string& deleteItem)
{
	items.remove(deleteItem);
}
