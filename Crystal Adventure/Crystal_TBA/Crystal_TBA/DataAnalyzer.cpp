#include "DataAnalyzer.h"

Data::Data()
{
}

Data::~Data()
{
}

void Data::writeToDatabase(sqlite3* db)
{
	sqlite3_stmt* stmt;
	int result;

	// Create statment
	result = sqlite3_prepare_v2(db, "INSERT INTO Analytics(actionsUsed, itemPicked, userPlayed, heroDeath) values (?, ?, ?, ?)", -1, &stmt, 0);
	if (result != SQLITE_OK)
	{
		std::cout << sqlite3_errmsg(db);
		printf("\nCould not prepare statement.");
		return;
	}

	// Bind parameter count
	sqlite3_bind_parameter_count(stmt);

	// Bind the name
	result = sqlite3_bind_int(stmt, 1, actionUsed);
	if (result != SQLITE_OK)
	{
		std::cout << sqlite3_errmsg(db);
		return;
	}

	result = sqlite3_bind_int(stmt, 2, itemPicked);
	if (result != SQLITE_OK)
	{
		std::cout << sqlite3_errmsg(db);
		return;
	}

	result = sqlite3_bind_int(stmt, 3, userPlayed);
	if (result != SQLITE_OK)
	{
		std::cout << sqlite3_errmsg(db);
		return;
	}

	result = sqlite3_bind_int(stmt, 4, heroDeath);
	if (result != SQLITE_OK)
	{
		std::cout << sqlite3_errmsg(db);
		return;
	}

	result = sqlite3_step(stmt);
	if (result != SQLITE_DONE)
	{
		std::cout << sqlite3_errmsg(db);
		return;
	}
}
