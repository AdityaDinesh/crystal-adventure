#include "InputParser.h"
#include "DataAnalyzer.h"

#include <iostream>
#include <sstream>

InputParser::InputParser()
{
	action = new ActionManager();
	actions.emplace("go", &ActionManager::goAction);
	actions.emplace("pick", &ActionManager::pickAction);
	actions.emplace("look", &ActionManager::lookAction);
	actions.emplace("inventory", &ActionManager::inventoryAction);
	actions.emplace("help", &ActionManager::helpAction);
}

InputParser::~InputParser()
{
	delete action;
	action = nullptr;
}

std::string& InputParser::parseInput(std::string& input)
{
	std::istringstream iss(input);
	for (input; iss >> input; )
	{
		result.push_back(input);
	}


	try
	{
		if (result.size() >= 2)
		{
			if (result.size() == 3)
			{
				input.clear();
				input = result[1] + " " + result[2];
				output = actions[result[0]](action, input);
			}
			else
			{
				output = actions[result[0]](action, result[1]);
			}
			Data::Instance().actionUsed++;
			result.clear();
			return output;
		}
		else
		{
			output = "Enter something after the action you want to do";
			result.clear();
			return output;
		}
	}

	catch (const std::exception&)
	{
		output = "I don't quite understand what you want to do";
		result.clear();
		return output;
	}
}
