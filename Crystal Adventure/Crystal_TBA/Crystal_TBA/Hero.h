#pragma once

#include <iostream>
#include <string>
#include "InputParser.h"
#include "ActionManager.h"
#include "GameEnd.h"

class Hero
{
public:
	InputParser* inputParse = nullptr;
	ActionManager* actionManager = nullptr;
	GameEnd* gameEnd = nullptr;

	bool status = true;			// Check if user wants to exit
	std::string input = "";		// Stores user inputs
	std::string output = "";	// Stores outputs to be displayed

	Hero();
	~Hero();

	void start();				// Method to start the game
};

