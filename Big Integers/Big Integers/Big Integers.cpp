/*  Program: Big Integers
	Author: Uchenna Onuigbo
	Class: CSCI 140
	Date: 4-1-19
	Description: A program that performs addition and subtraction operations with large integers up to 20 digits in length
	I certify that the code below is my own work.
	Exception(s): N/A
*/
//#include "pch.h"
#include <iostream>
#include <string>

using namespace std;

constexpr int Max_Digits = 20;
void startProgram();
bool toIntArray(string convert, int intConvert[]); //convert operand as string to an int arrary
void addArray(int add1[], int add2[], int sum[]); //add (two big integers as two int arrays) 
void subtractArray(int sub1[], int sub2[], int diff[]); //subtract (two big integers as two int arrays) 
//output one big integer (one int array)
int main()
{
	
	//bool continueS = true;
	//string cancel = "0 % 0";
	startProgram();

	string expr1 = "";
	string expr2 = "";
	string operand = "";
	//int validOperations = 0;

	//Notes to self:
	//I plan to check for valid operand first, then call conversion methods
	//Remember to format inputs by the examples on the project sheet
	//When the logic works, remember to code in the while loop

	//Obtained error message "Stack around the variable value1 was corrupted" so I added the static keyword
	static int value1[Max_Digits] = { 0 };
	static int value2[Max_Digits] = { 0 };
	static int totalValue[Max_Digits] = { 0 };
	
	//while(continueS)
	cin >> expr1;
	cout << endl << "Entered string: " << expr1 << endl;
	
	bool x = toIntArray(expr1, value1); //change bool name later
	//if(x == false) break loop

	cout << "Enter second expression." << endl;
	cin >> expr2;
	cout << endl << "Entered string: " << expr2 << endl;
	bool y = toIntArray(expr2, value2); //change bool name later
	//if(y== false) break loop
	
	cout << "Enter the operand. -->" << " ";
	cin >> operand;
	if (operand == "+")
	{
		cout << expr1 << " + " << expr2 << " = ";
		//call add function
		addArray(value1, value2, totalValue); //outputs wrong values. will fix later
	}
	//else if (operand == "-")
	//{
	//cout << expr1 << " - " << expr2 << " = ";
	//	//call subtract function
	//}
	else
	{
		cout << "Invalid operand. Please try again. -->" << " ";
		cin >> operand;
		//continue;
	}
	
	return 0;	
}

void startProgram()
{
	cout << "Author: Uchenna Onuigbo\n";
	cout << "Big Integers\n" << endl;

	cout << "This program will add and subtract values you enter.\n";
	cout << "The expressions entered must be less than or equal to 20 digits.\n";
	cout << "Character values are prohibited.\n";
	//cout << "Enter expression in the form of '5555' +/- '67543445'." << endl;
	cout << "Enter first expression." << endl;

	//assume there is a space between each expression and operand
	//assume the first expr is bigger than second for subraction
}

bool toIntArray(string convert, int intConvert[])
{
	//int numDigits = 0;
	intConvert[Max_Digits] = { 0 };
	int strLen = convert.length();
	for (int i = 0; convert[i] != '\0'; i++)
	{
		 //Checks if there's a nonnumeric value in array
		char currentChar = convert.at(i);
		if(currentChar<(char)'0' || currentChar>(char)'9')
		{	
			cout << "Error! Invalid Characters!" << endl;
			break;
			return false;
		}
		else
		{
			intConvert[Max_Digits - (strLen - i)] = convert[i] - '0';
			return true;
		}
	}

	//cout << "The ints:   ";
	for (int i = 0; i < Max_Digits; i++)
	{
		cout << intConvert[i];
		
	}
	cout << endl;
	//cout << numDigits << endl;	
}

void addArray(int add1[], int add2[], int sum[])
{
	int carry = 0;
	int digit = 0;
	add1[Max_Digits];
	add2[Max_Digits];
    sum[Max_Digits];


	for (int i = 0; i < Max_Digits; i++)
	{
		digit = add1[i] + add2[i] + carry;
		if (digit >= 10)
		{
			carry = 1;
			digit = digit - 10;
		}
		else
			carry = 0;

		sum[i] = digit;
	}

	for (int j = Max_Digits - 1; j >= 0; j--)
	{
		cout << sum[j];
	}
	cout << endl;
}

void subtractArray(int sub1[], int sub2[], int diff[])
{
	int borrow = 0;
	int digit = 0;
	sub1[Max_Digits];
	sub2[Max_Digits];
	diff[Max_Digits];
}