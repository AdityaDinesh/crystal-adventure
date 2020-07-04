#include "Battle.h"
#include "DataAnalyzer.h"

#include <algorithm>
#include <sstream>

Battle::Battle()
{
	itemManager = new ItemManager();
	roomPtr = new Rooms();
	mapPtr = new Map();
}

Battle::~Battle()
{
	delete itemManager;
	delete roomPtr;
	delete mapPtr;
	itemManager = nullptr;
	roomPtr = nullptr;
	mapPtr = nullptr;
}

std::string& Battle::isFinal()
{
	return end;
}

void Battle::initialize(Rooms* rooms, Map* map, std::list<std::string>& backpack)
{
	battleOn = true;
	playerWin = true;
	playerHealth = 100;
	roomPtr = rooms;
	mapPtr = map;
	enemyName = rooms->enemyName;
	enemyWeapon = rooms->enemyWeapon;
	enemyHealth = rooms->enemyHealth;
	enemyDamage = rooms->enemyDamage;

	backpackItems = backpack;
	beginBattle();
}

void Battle::beginBattle()
{
	std::cout << " YOU HAVE ENCOUNTERED AN ENEMY !!! FIGHT IT TO PROGRESS FURTHER" << std::endl;
	std::cout << "************************ Battle Mode **************************\n" << std::endl;

	while (battleOn)
	{
		
		std::cout << enemyName + " is going to attack you. What would you like to do" << std::endl;
		std::getline(std::cin, input);
		transform(input.begin(), input.end(), input.begin(), ::tolower);
		result.clear();
		parseInput(input);
		if (playerHealth <= 0 || enemyHealth <= 0)
		{
			battleOn = false;
		}
	}
	endBattle();
	playerHealth = 100;
}

void Battle::endBattle()
{
	if (playerWin)
	{
		if (enemyName == "arceus")
		{
			end = "final";
		}
		std::cout << "\n#*#*#*#*#*#*#* Victory !!! You have defeated " << enemyName << " #*#*#*#*#*#*#*\n" << std::endl;
		if (itemManager->bossItems.find(enemyName) != itemManager->bossItems.end())
		{
			enemyItem = itemManager->bossItems.find(enemyName)->second;
			backpackItems.push_back(enemyItem);
			std::cout << "Congratulations! You have obtained <" << enemyItem << ">" << std::endl;
		}
		roomPtr->enemyName = "";
		roomPtr->enemyWeapon = "";
		roomPtr->enemyHealth = 0;
		roomPtr->enemyDamage = 0;
	}
	else
	{
		std::cout << "Oh no ! You have died !!! \n You will lose your items and go back to Home" << std::endl;
		Data::Instance().heroDeath++;
		for (auto it : backpackItems)
		{
			roomPtr->items.push_back(it);
		}
		backpackItems.clear();
		mapPtr->currentId = 0;
		roomPtr->enemyHealth = enemyHealth;
	}
}

void Battle::playerAttack(std::string& weapon)
{
		std::cout << "You attacked with " << weapon << std::endl;
		enemyHealth -= playerDamage;
		std::cout << "Enemy HP : " << enemyHealth << std::endl;
		enemyAttack();
}

void Battle::enemyAttack()
{
	if (enemyHealth > 0)
	{
		std::cout << enemyName << " attacked with " << enemyWeapon << std::endl;
		playerHealth -= enemyDamage;
		std::cout << "Your HP : " << playerHealth << std::endl;
		if (playerHealth <= 0)
		{
			playerWin = false;
		}
	}
}

void Battle::parseInput(std::string& input)
{
	std::istringstream iss(input);
	for (input; iss >> input; )
	{
		result.push_back(input);
	}

	try
	{
		if (result.size() > 1 && result.size() < 4)
		{
			if (result[0] == "attack")
			{	
				std::string concat;
				if (result.size() == 3)
				{
					concat.clear();
					concat = result[1] + " " + result[2];
				}
				else
				{
					concat.clear();
					concat = result[1];
				}
				it = std::find(backpackItems.begin(), backpackItems.end(), concat);
				if (it != backpackItems.end() || concat == "punch")
				{
						playerDamage = itemManager->attackWithWeapon(concat, enemyName);
						if (playerDamage == 0)
						{
							std::cout << "You cannot attack with " + concat + " or you don't have this item" << std::endl;
							beginBattle();
						}
						playerAttack(input);
					
				}
				else
				{
					std::cout << "You don't have this item" << std::endl;
				}
			}
			else if (result[0] == "inventory" && result[1] == "check")
			{
				if (backpackItems.size() > 0)
				{
					for (auto it : backpackItems)
					{
						std::cout << "->" + it << std::endl;
					}
				}
				else
				{
					std::cout << "There is nothing in your backpack" << std::endl;
				}
			}
			else
			{
				std::cout << "Enter either an <attack> or <inventory check> command. If you don't have any item to attack with you can always 'punch'" << std::endl;
			}
		}
		else
		{
			std::cout << "Enter either an <attack> or <inventory check> command. If you don't have any item to attack with you can always 'punch'" << std::endl;
		}
	}

	catch (const std::exception&)
	{
		std::cout << "I don't quite understand what you want to do" << std::endl;
	}
}


