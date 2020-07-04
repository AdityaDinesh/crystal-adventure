#pragma once

#include <iostream>
#include "sqlite3.h"

class Data
{
public:
	 int actionUsed = 0;	// How many times a user used an action
	 int itemPicked = 0;	// How many times an item was picked
	 int userPlayed = 0;	// How many times user played the game
	 int heroDeath = 0;		// How many times hero died

	 Data();
	 ~Data();

	 inline static Data& Instance()		// Creating this class as a Singleton as there should only be one instance
	 {
		 static Data instance;
		 return instance;
	 }

	void writeToDatabase(sqlite3*);		// Method to write data to the database
};