#include "ItemManager.h"

#include <iostream>

ItemManager::ItemManager()
{
	loadValues();
}

ItemManager::~ItemManager()
{
}

void ItemManager::loadValues()
{
	itemPower.emplace("punch", 20);
	itemPower.emplace("dagger", 25);
	itemPower.emplace("toxic acid", 30);
	itemPower.emplace("wind slicer", 30);
	itemPower.emplace("illumball", 30);
	itemPower.emplace("stun cross", 30);
	itemPower.emplace("topaz", 35);
	itemPower.emplace("sapphire", 35);
	itemPower.emplace("emerald", 35);
	itemPower.emplace("ruby", 35);
	itemPower.emplace("amethyst", 35);
	itemPower.emplace("diamond", 35);

	enemyWeakness.emplace("toxic acid", "zeraora");
	enemyWeakness.emplace("topaz", "dragonair");
	enemyWeakness.emplace("illumball", "ghost monster");
	enemyWeakness.emplace("wind slicer", "devil");
	enemyWeakness.emplace("stun cross", "vampire");
	enemyWeakness.emplace("wind slicer", "devil");
	enemyWeakness.emplace("sapphire", "grevile");
	enemyWeakness.emplace("emerald", "magmarock");
	enemyWeakness.emplace("ruby", "articuno");
	enemyWeakness.emplace("diamond", "lucario");
	enemyWeakness.emplace("amethyst", "arceus");

	bossItems.emplace("zeraora", "topaz");
	bossItems.emplace("dragonair", "sapphire");
	bossItems.emplace("grevile", "emerald");
	bossItems.emplace("magmarock", "ruby");
	bossItems.emplace("articuno", "diamond");
	bossItems.emplace("lucario", "amethyst");
	bossItems.emplace("bison", "bridge pass");
	bossItems.emplace("thief", "dagger");
	bossItems.emplace("devil lord", "illumball");
	bossItems.emplace("ghost monster", "stun cross");
	bossItems.emplace("arceus", "your sister Maria");
}

int& ItemManager::attackWithWeapon(std::string& weapon, std::string& enemy)
{
	try
	{
		if (itemPower.find(weapon) == itemPower.end())
		{
			return damage;
		}
		else if (weapon == itemPower.find(weapon)->first)
		{
			damage = itemPower.find(weapon)->second;
			if (enemyWeakness.find(weapon) == enemyWeakness.end())
			{
				return damage;
			}
			else
			{
				damage *= 2;
				return damage;
			}
		}
		else
		{
			return damage;
		}
	}
	catch (const std::exception&)
	{
		return damage;
	}
	// TODO: insert return statement here
}
