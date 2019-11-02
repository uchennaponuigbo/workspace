#include "Editor.h"
#include "NodeList.h"
#include<string>
#include<iostream>

using namespace std;

Editor::Editor(string w)
{	
	this->cursor = '>';
	setEdittingWord(w);
	list.insertBack(cursor);
	//it = list.end();
	
}

/*private*/ void Editor::setEdittingWord(string w)
{
	//this->word = w;
	//this->wordLength = w.length();
	for (int i = 0; i < w.length(); i++)
	{
		list.insertBack(w[i]);
	}
	
}

/*NodeList list;
	list.insertFront('a');
	cout << list.atIndex(0) << " " << list.indexOf('a'); //outputs a 0*/

void Editor::moveLeft() //1
{
	if (*it == 0) //list.begin()
	{
		cout << "Cursor is at the beginning." << endl; 
		return;
	}
	
	--it;
	cout << list.indexOf(cursor); //= *it;
	cout << "Moved cursor left." << endl;
}

void Editor::moveRight() //2
{
	if (*it == list.size()) //list.end()
	{
		cout << "Cursor is at the end." << endl;
		return;
	}
	
	++it;
	cout << "Moved cursor right." << endl;
}

void Editor::insertChar(char c) //3
{
	//wordLength++;
	list.insert(--it, c);
	cout << "Inserted the Character " << c << endl;	
}

void Editor::deleteChar() //4
{
	--it;
	list.erase(--it);
	//wordLength--;
	cout << "Deleted one character." << endl;	
}


void Editor::getCurPos() //5
{
	//if >hello world, index of h would be 0;
	//return list.indexOf(0);
	
	cout << "Current position: " << *it;
}

void Editor::goToPos(int i) //6
{
	if (!(i >= 0 && i <= list.size())) //wordLength
		return;
	for (/*NodeList::Iterator it2*/ it = list.begin(); it != list.end(); ++it) 
	{
		if (i == list.indexOf(cursor))
		{
			//list.atIndex(*it);
			//code that moves the cursor there
			cout << "Moved to Position " << i << endl;
			break;
		}
			
	}
}

void Editor::display() //7
{
	cout << "String: "; print(); // "/"/ with the cursor on char representing the position of the list
	cout << endl;
	cout << "Length: " << list.size();
}

void Editor::quit() //8
{
	cout << "End of Program." << endl;
}

void Editor::print() 
{
	int prevPos = *it;
	for (/*NodeList::Iterator it2*/ it = list.begin(); it != list.end(); ++it)
	{
		/*if(list.atIndex(*it) == cursor)*/
		cout << *it;
	}
	*it = prevPos;
}

Editor::~Editor()
{
}
