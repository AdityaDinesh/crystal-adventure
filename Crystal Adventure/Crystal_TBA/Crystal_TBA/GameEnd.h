#pragma once

#include <iostream>
#include <string>

class GameEnd
{
public:	
	std::string finalText;				// The final text to be displayed at the end of game
		
	std::string& returnFinalText();		// Method to return the final text
};

