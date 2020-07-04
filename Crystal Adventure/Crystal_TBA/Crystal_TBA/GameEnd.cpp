#include "GameEnd.h"

std::string& GameEnd::returnFinalText()
{
	finalText = "\n After a weary fight with Arceus you finally defeat the evil for good and free your sister Maria \n Suddenly the crystals start floating away and into the sky.\n It's quite bright but you manage to see a glimpse of all crystals spreading out into different directions\n I guess they are pretty mysterious\n\n ||||| ****THE END *** |||| \n\n";
	std::cout << sizeof(finalText);
	return finalText;
}
