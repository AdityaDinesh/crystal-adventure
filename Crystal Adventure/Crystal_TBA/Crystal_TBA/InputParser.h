#pragma once
#ifndef _INPUT_PARSER_H
#define _INPUT_PARSER_H

#include<string>
#include<vector>
#include<functional>

#include "ActionManager.h"

class InputParser
{
public:
	ActionManager* action = nullptr;

	std::map<std::string, std::function<std::string& (ActionManager*, std::string&)>> actions;	// A map of sction acton strings and the function pointers that do those actions
	std::vector<std::string> result;	// A vector to seperate the string based on white spaces for ease of parsing the string
	std::string output = "";	// Stores an output which determines what to be diplayed
	std::string input;	// Store User input

	InputParser();
	~InputParser();

	std::string& parseInput(std::string&);	// Method to parse user input
};

#endif // !_INPUT_PARSER_H
