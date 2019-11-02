#pragma once
#include<string>
#include "NodeList.h"
class Editor
{
private:
	//std::string word;
	char cursor;
	
	//int wordLength;
	NodeList list;
	NodeList::Iterator it = list.end();

	void setEdittingWord(std::string);
public:
	Editor(std::string);

	void moveLeft(); //move cursor left one character (do nothing if at beginning)
	void moveRight(); //move cursor right one character (do nothing if at the end)

	void insertChar(char); //insert the character c just before the cursor
	void deleteChar(); //delete the character just at the cursor (if not at end)

	void getCurPos(); //provide current position i of the cursor (0 <= i <= n-1)
	void goToPos(int); //go to position i if i is a valid position (0 <= i <= n - 1)

	void display(); //display string and number of characters(including space and cursor)
	void quit(); //stop the program

	void print();
	~Editor();
};

