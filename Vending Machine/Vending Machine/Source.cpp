/*  Program: Vending Machine
	Author: Uchenna Onuigbo
	Class: CSCI 140
	Date: 3-7-19
	Description: Create a vending machine that accepts quarters, nickels, dimes

	I certify that the code below is my own work.

	Exception(s): N/A
*/
#include <iostream>
#include<iomanip>
using namespace std;

struct Coin
{
	int quarter, dime, nickel;
};

int main()
{
	cout << "Author: Uchenna Onuigbo\n";
	cout << "Vending Machine Version 1" << endl;
	
	int purchaseAmount = 0;
	cout << "Fill up machine with changes. Please wait... \n";
	cout << "Enter the # of quarters, dimes and nickels in this order." << endl;
	//makeChanges(purchaseAmount,)
	return 0;
}

bool isDivisable(int number1, int number2)
{
	bool valid = true;
		if(number1 % number2 != 0)
		{
			valid = false;
			return valid;
		}
	return valid;
}

bool isWithinRange(int max, int min, int value)
{
	bool valid = true;
	if (value > max || value < min)
	{
		valid = false;
		return valid;
	}
	return valid;
}

bool makeChanges(int amount, Coin &machine, Coin &back)
{
	//I could also make the function void, and add makeChanges as a parameter

	// amount - change amount to give back
	// machine - current quarters, dimes, and nickels in machine
	//back - quarters, dimes, and nickels to give back
	//return true for sufficient changes else return false otherwise

	int userCoins = 0; //might use for switch statement to calculate total
	int numberOfTransactions = 0;
	float machineBalance = 0;
	cin >> machine.quarter;
	cin >> machine.dime;
	cin >> machine.nickel;

	cout << fixed << showpoint << setprecision(2);
	float quarterValue = machine.quarter * 0.25;
	float dimeValue = machine.dime * 0.10;
	float nickelValue = machine.nickel * 0.05;
	machineBalance = quarterValue + dimeValue + nickelValue;

	cout << "You have entered " << machine.quarter << " quarter(s),"
		<< machine.dime << " dime(s), " << "and " << machine.nickel << " nickels.\n";
	cout << "The balance in the machine is " << machineBalance << endl;
	cout << "Only a purchase amount from 0-100 in multiples of 5 will be accepted.\n";
	cout << "For purchase, only a One Dollar bill or coins will be accepted.\n";
	cout << "Enter 0 to stop the program. The machine is ready to operate." << endl;

	cout << "Enter the purchase amount from 0-100 cents" << endl;
	//amount represents the change to give back. change this variable
	cin >> amount;
	
	bool divide = isDivisable(amount, 5);
	bool range = isWithinRange(100, 0, amount);

	while (!(divide))
	{
		cout << "This value is not divisble by five. Please enter from 0-100 in multiples of 5." << endl;
		cin >> amount;
	}
	while (!(range))
	{
		cout << "That is not valid. Please enter from 0-100 in multiples of 5." << endl;
		cin >> amount;
	}

	while (amount != 0)
	{
		cout << "You have entered " << amount << endl;
		//maybe use a switch statement for the dollar bill and coins option.
		cout << "Select an option, 1 for dollar bill, 2 for coins" << endl;
		//might need to do a nested while loop for this transaction
		/*int coinsBill;
		cin >> coinsBill;*/
		switch (amount)
		{
		case 1:
		{
			//cout << fixed << showpoint << setprecision(2);
			//The program will insert 4 coin choices and output the total. Then the program will check if
			//the machine can give sufficent change or not. Must make sure that the change can be given back
			//can't give back change that doesn't exist
			// int x = back.quarter
		}
		case 2:
		{
			//cout << fixed << showpoint << setprecision(2);
			//The programm will insert a dollar bill (1.00 float value), then determine if it can give sufficent change or not
		}
		default: cout << "Please enter the right option. Dollar Bill (1) or Coins (2)." << endl;
			numberOfTransactions++;
		}

		if (amount == 0) // generates final report
		{
			cout << "Here is the final report.\n";
			//cout << "There are " << (variable here) << " transactions.\n";
			//cout << "Dollars: " << (variable here) << endl;
			cout << "Quarters: " << machine.quarter << endl;
			cout << "Dimes: " << machine.dime << endl;
			cout << "Nickels: " << machine.nickel << endl;
			//cout << "Machine Balance: " << (machineBalance) << endl;
			cout << "Thank you for using. Initiating shut down..." << endl;
		}
	}
	return false;
}