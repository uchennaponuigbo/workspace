#include "Editor.h"
#include "NodeList.h"
#include<string>
#include<iostream>

using namespace std;

Editor::Editor(string w)
{	
	this->cursor = '>';
	setEdittingWord(w);	
	it = list.end();
}

/*private*/ void Editor::setEdittingWord(string w)
{
	for (int i = 0; i < w.length(); i++)
	{
		list.insertBack(w[i]);
	}	
}

void Editor::moveLeft() //1
{
	if (it == list.begin())
	{
		cout << "Cursor is at the beginning."; 
		return;
	}
	
	--it;
	cout << "Moved cursor left.";
}

void Editor::moveRight() //2
{
	if (it == list.end())
	{
		cout << "Cursor is at the end.";
		return;
	}
	
	++it;
	cout << "Moved cursor right.";
}

void Editor::insertChar(char c) //3
{
	list.insert(it, c);
	cout << "Inserted the Character " << c;	
}

void Editor::deleteChar() //4
{
	if (it == list.begin()) //*it > list.size() 
	{
		cout << "Unable to delete character.";
		return;
	}
	--it;
	list.erase(it);
	cout << "Deleted one character.";	
}


void Editor::getCurPos() //5
{
	cout << "Current position: " << list.indexOf(*it);
}

void Editor::goToPos(int i) //6
{
	if (!(i >= 0 && i <= list.size()))
	{
		cout << "Invalid Position.";
		return;
	}
		
	for (/*NodeList::Iterator it2*/ it = list.begin(); it != list.end(); ++it) 
	{
		if (i == list.indexOf(*it))
		{
			//list.atIndex(*it);
			cout << "Moved to Position " << i;
			break;
		}
			
	}
}

void Editor::display() //7
{
	cout << "String: "; print(); 
	cout << endl;
	cout << "Length: " << list.size();
}

void Editor::quit() //8
{
	cout << "End of Program." << endl;
}

void Editor::print() 
{	
	for (NodeList::Iterator it2 = list.begin(); it2 != list.end(); ++it2)
	{	
		if (*it2 == *it)
			cout << cursor;
		cout << *it2;
		 	
	}

	if (it == list.end())
		cout << cursor;
}

Editor::~Editor()
{
}
