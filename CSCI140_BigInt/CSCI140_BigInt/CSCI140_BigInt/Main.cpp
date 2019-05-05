/*  Program: Big Int Class
	Author: Uchenna Onuigbo
	Class: CSCI 140
	Date: 4/27/19
	Description: Perform addition and subtraction with an array of integers in an object oriented way

	I certify that the code below is my own work.

	Exception(s): N/A

*/
#include "BigInt.h"
#include <iostream>
#include <string>
using namespace std;

int main()
{
	string term1 = "";
	string term2 = "";
	string operand = "";
	string expression;
	int validOperations = 0;
	bool isRunning = true;
	BigInt computedValue;

	while (isRunning)
	{
		cout << "Enter an expression --> ";
		cin >> term1;
		cin >> operand;
		cin >> term2;

		BigInt value1(term1);
		BigInt value2(term2);

		if (!value1.isValid())
		{
			cout << "Invalid operation (" << value1.getInvalidReason() << ")." << endl;
			continue;
		}

		if (!value2.isValid())
		{
			cout << "Invalid operation (" << value2.getInvalidReason() << ")." << endl;
			continue;
		}

		if (value1.getValue() == "0" && value2.getValue() == "0" && operand == "%")
		{
			isRunning = false;
			continue;
		}

		if (operand == "+" || operand == "-" || operand == "*")
		{
			if (operand == "+")
			{
				computedValue = value1.add(value2);
			}
			else if (operand == "-")
			{
				computedValue = value1.sub(value2);
			}
			else if (operand == "*")
			{
				computedValue = value1.mul(value2);
			}

			if (!computedValue.isValid())
			{
				cout << "Integer overflow." << endl;
				continue;
			}

			value1.print();
			cout << " " << operand << " ";
			value2.print();
			cout << " = ";
			computedValue.print();
			cout << endl;
			cout << endl;
			validOperations++;
		}
		else
		{
			cout << "Invalid operation (invalid operation between numbers)." << endl;
			continue;
		}
	}

	if (validOperations == 1)
	{
		cout << "There is one valid operation." << endl;
	}
	else
	{
		cout << "There are " << validOperations << " valid operations." << endl;
	}

	cout << "Thanks for using my program. Good bye!";
	return 0;
}