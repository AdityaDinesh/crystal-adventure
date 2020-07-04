#include "Hero.h"

#include <algorithm>

Hero::Hero()
{
	inputParse = new InputParser();
	actionManager = new ActionManager();
	gameEnd = new GameEnd();
}

Hero::~Hero()
{
	delete inputParse;
	delete actionManager;
	delete gameEnd;
	inputParse = nullptr;
	actionManager = nullptr;
	gameEnd = nullptr;
}

void Hero::start()
{
	std::cout << "\nHello There Traveller !!! Welcome to the World of Crystal" << std::endl;
	std::cout << "The evil creature Arceus has captured your sister Maria. You need the power of the Elemental Crystals to defeat him." << std::endl;
	std::cout << "So let's not waste any time and get moving !!!" << std::endl;
	std::cout << "|-------------------------------------------------------|" << std::endl;
	std::cout << "For knowing the commands you can enter 'help me' to retrieve the list of commands" << std::endl;
	std::cout << "You are currently in Area : Home" << std::endl;
	std::cout << "The direction in which you can go is : South" << std::endl;

	while (status)
	{
		std::getline(std::cin, input);
		transform(input.begin(), input.end(), input.begin(), ::tolower);
		if (input != "exit")
		{
			output.clear();
			output = inputParse->parseInput(input);
			if (output == "")
			{
				std::cout << "You sure about that ? Might wanna rephrase that" << std::endl;
			}
			else if (output == "final")
			{
				status = false;
				output.clear();
				output = gameEnd->returnFinalText();
				std::cout << output;
			}
			else
			{
				std::cout << output << std::endl;
			}
		}
		else
		{
			status = false;
		}

		std::cout << "/**********/********/********/******/****/" << std::endl;
	}
}
