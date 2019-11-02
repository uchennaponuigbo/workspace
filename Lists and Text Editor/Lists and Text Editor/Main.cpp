/*  Program: Project 3: Lists and Text Editor
	Author: Uchenna Onuigbo
	Class: CSCI 220
	Date: 10/24/19
	Description: A C++ mini text editor program that uses iterators to edit strings

	I certify that the code below is my own work.

	Exception(s): N/A

*/
#include <iostream>
#include<string>
#include"Editor.h"
#include "NodeList.h"

using namespace std;

void startProgram();
void menu();

int main()
{
	startProgram();

	string edit = "";
	int option = 0;

	getline(cin, edit);
	cout << endl << "Editting document..." << endl << endl;
	Editor e(edit);
	
	//e.print();
	menu();
	cout << "Enter an option: ";
	cin >> option;

	while (true)
	{
		if (option == 1)
		{
			e.moveLeft();
			cout << endl << endl;
		}
		else if (option == 2)
		{
			e.moveRight();
			cout << endl << endl;
		}
		else if (option == 3)
		{
			char c;
			cout << "Enter a character: ";
			cin >> c;
			e.insertChar(c);
			cout << endl << endl;
		}
		else if (option == 4)
		{
			e.deleteChar();
			cout << endl << endl;
		}
		else if (option == 5)
		{
			e.getCurPos();
			cout << endl << endl;
		}
		else if (option == 6)
		{
			int position = 0;
			cout << "Enter a position: ";
			cin >> position;

			e.goToPos(position);

			cout << endl << endl;
		}
		else if (option == 7)
		{
			e.display();
			cout << endl << endl;
		}
		else if (option == 8)
		{
			e.quit();
			break;
		}
		else
		{
			cout  << "Invalid option. Enter from 1-8." << endl << endl;
		}

		cout << "Enter an option: ";
		cin >> option;
	}
	return 0;
}

void startProgram()
{
	cout << "Project III: Lists & Text Editor." << endl;
	cout << "Author: Uchenna Onuigbo\n";
	cout << "Letters of the Alphabet and Spaces are valid only.\n\n";
	cout << "Enter a starting string: ";
}

void menu()
{
	cout << "Editting menu" << endl << endl;
	cout << "1. Move Left\n" << "2. Move Right\n" << "3. Insert Character\n" <<
		"4. Delete Character\n" << "5. Get Current Position\n" << "6. Go to Position\n"
		<< "7. Display\n" << "8. Quit\n\n";
}

/*NodeList list;
	string hello = "Hello World"; //
	for (int i = 0; i < hello.length(); i++)
		list.insertFront(hello[i]);

	for (NodeList::Iterator it = list.begin(); it != list.end(); ++it)
	{
		cout << list.indexOf(*it); //outputs 0 for one string character, outputs 012345311910 for "Hello World"
	}*/