/*  Program: Big Int Class
	Author: Uchenna Onuigbo
	Class: CSCI 140
	Date: 4/27/19
	Description: Perform addition and subtraction with an array of integers in an object oriented way

	I certify that the code below is my own work.

	Exception(s): N/A

*/
//#include "pch.h"
#include "BigInt.h"
#include <iostream>
#include<string>
using namespace std;

//const int Max_Digits = 20;
//void startProgram();

int main()
{
	//BigInt result = first.add(second);
	
	string expr1 = "";
	string expr2 = "";
	
	/*int value1[Max_Digits] = {0};
	int value2[Max_Digits] = { 0 };
	int total[Max_Digits] = { 0 };*/

	cout << "Test if values goes into class" << endl;
	cin >> expr1;
	cin >> expr2;
	BigInt first(expr1); //first, stores the variable in default constructor
	BigInt second(expr2);
	bool x = first.setValue(expr1); //with the variable stored, the constructor is stored as variable in main.
	bool y = second.setValue(expr2);

	if (x == false || y == false)
	{
		cout << "One of these values are invalid" << endl; 
	}
	else
		cout << "In the big int class, the value " 
		<< first.getValue() << " and " << second.getValue() << " has been stored in the class" << endl;

	
	/*cout << first.getValue() << " + " << second.getValue() << " = ";
	cout << first.getValue() << " - " << second.getValue() << " = ";*/
	return 0;
}

//void startProgram()
//{
//	cout << "Author: Uchenna Onuigbo\n";
//	cout << "Big Int Class\n" << endl;
//
//	cout << "This program will add and subtract values you enter.\n";
//	cout << "The expressions entered must be less than or equal to 20 digits.\n";
//	cout << "Character values are prohibited.\n";
//	cout << "To end the program, input '0 % 0'\n";
//	cout << "Enter expression in the form of '5555' +/- '67543445'. -->" << " ";
//	//cout << "Enter first expression." << endl;
//
//	//assume there is a space between each expression and operand
//	//assume the first expr is bigger than second for subraction
//}