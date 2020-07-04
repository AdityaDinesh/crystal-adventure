#include "Hero.h"

#include <iostream>
#include "sqlite3.h"
#include "DataAnalyzer.h"

int main()
{
	int choice;
	bool played = false;
	Hero hero;

	std::cout << "*********** WELCOME TO CRYSTAL ADVENTURE *************" << std::endl;
	std::cout << "What would you like to \n";
	std::cout << "1. New Game \n2. Load Game\n3. Exit\n";
	std::cout << "Choice :: ";
	std::cin >> choice;

	switch (choice)
	{
	case 1 : hero.start();
			 played = true;
			 break;

	case 2: std::cout << "Under Development";
		    played = true;
			break;

	case 3: std::cout << "Good Bye! Hope to see you soon!";
			break;	
	}
	
    #pragma region DataAnalytics

	if (played)
	{
		Data::Instance().userPlayed++;

		sqlite3* db;
		char* zErrMsg = 0;
		int rc;

		rc = sqlite3_open("../../Data/crystal.db", &db);

		if (rc)
		{
			fprintf(stderr, "Can't open database: %s\n", sqlite3_errmsg(db));
			return(0);
		}

		Data::Instance().writeToDatabase(db);

		sqlite3_close(db);
	}
#pragma endregion
}