/*  Program: Vending Machine
	Author: Uchenna Onuigbo
	Class: CSCI 140
	Date: 3-7-19
	Description: Create a vending machine that accepts quarters, nickels, dimes

	I certify that the code below is my own work.

	Exception(s): N/A
*/
#include <iostream>
#include <iomanip>
#include <string>
using namespace std;

struct Coin
{
	int quarter, dime, nickel;
};

struct Amount
{
	int dollar, quarter, dime, nickel;
};

string getBalanceString(Coin& coin);
bool makeChanges(int amount, Coin &machine, Coin &back);
Amount getAmount(Coin &machine);

int main()
{
	int exitCode;
	Coin machine;
	Coin back;

	int purchaseAmount = -1;
	int amount = -1;
	int validTransactions = 0;

	cout << "Author: Uchenna Onuigbo\n";
	cout << "Vending Machine Version 1" << endl;
	cout << "Fill up machine with changes. Please wait..." << endl;
	cout << "Enter the # of quarters, dimes and nickels in this order." << endl;
	cin >> machine.quarter >> machine.dime >> machine.nickel;
	cout << "There are " << machine.quarter << " quarter(s), " << machine.dime << " dime(s), and " << machine.nickel << " nickle(s)." << endl;
	cout << "Initial machine balance is " << getBalanceString(machine) << "." << endl;
	cout << "One-dollar bill or coins will be accepted." << endl;
	cout << "Only amount between 0 and 100 and multiple of 5 is accepted." << endl;
	cout << "Enter 0 to stop the program." << endl;
	cout << "Machine is now ready." << endl;

	while (purchaseAmount != 0)
	{
		cout << "Enter the purchase amount [0 - 100]." << endl;
		cin >> purchaseAmount;

		if (purchaseAmount == 0)
		{
			cout << "Final report is being generated ..." << endl;
			cout << "There are " << validTransactions << " valid transactions." << endl;
			cout << "Number of dollars :" << endl;
			cout << "Number of quarters: " << endl;
			cout << "Number of dimes: " << endl;
			cout << "Number of nickles: " << endl;
			cout << "Machine balance: " << getBalanceString(machine) << endl;
			cout << "Machine is shutting down." << endl;
			break;
		}

		cout << "You entered a purchase amount of " << purchaseAmount << " cent(s)." << endl;

		if (purchaseAmount > 100)
		{
			cout << "Invalid amount (outside valid range). Try again." << endl;
			continue;
		}

		if (purchaseAmount % 5 != 0)
		{
			cout << "Invalid amount (not a multiple of 5). Try again." << endl;
			continue;
		}

		int insertedAmount = 0;
		int option = 0;

		while (option != 1 && option != 2)
		{
			cout << "Select an option, 1 for dollar bill, 2 for coins" << endl;
			cin >> option;
		}

		string optionString = "dollar";

		switch (option)
		{
			case 1:
				insertedAmount = 100;
				cout << "You entered an amount of 100." << endl;
				break;

			case 2:
				optionString = "coins";
				int currentAmount = -1;
				int totalAmount = 0;
				cout << "Please insert your coins." << endl;

				while (currentAmount != 0 && insertedAmount < 100)
				{
					cin >> currentAmount;

					if (currentAmount == 25 || currentAmount == 10 || currentAmount == 5)
					{
						insertedAmount += currentAmount;
					}
				}

				cout << "You entered an amount of " << insertedAmount << " cents." << endl;

				break;
		}

		cout << "Processing your purchase ..." << endl;

		int amount = insertedAmount - purchaseAmount;

		bool areChangesValid = makeChanges(amount, machine, back);

		if (areChangesValid)
		{
			validTransactions++;
		}
		else
		{
			cout << "Insufficient changes." << endl;
			cout << "Your transaction cannot be processed." << endl;
			cout << "Please take back your " << optionString << "." << endl;
		}
	}

	return 0;
}

string getBalanceString(Coin& coin) {
	int balance = (25 * coin.quarter) + (10 * coin.dime) + (5 * coin.nickel);
	int dollars = balance / 100;
	int cents = balance % 100;
	string centsString = to_string(cents);

	if (centsString.length() < 2) {
		centsString += "0";
	}

	return "$" + to_string(dollars) + "." + to_string(cents);
}

bool isDivisable(int number1, int number2)
{
	bool valid = true;
	if (number1 % number2 != 0)
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
	int initialNumberOfQuarters = machine.quarter;
	int initialNumberOfDimes = machine.dime;
	int initialNumberOfNickels = machine.nickel;

	back.quarter = 0;
	back.dime = 0;
	back.nickel = 0;

	int remainingAmount = amount;

	while (remainingAmount >= 25 && machine.quarter > 0)
	{
		remainingAmount -= 25;
		back.quarter++;
		machine.quarter--;
	}

	while (remainingAmount >= 10 && machine.dime > 0)
	{
		remainingAmount -= 10;
		back.dime++;
		machine.dime--;
	}

	while (remainingAmount >= 5 && machine.nickel > 0)
	{
		remainingAmount -= 10;
		back.nickel++;
		machine.nickel--;
	}

	if (remainingAmount == 0)
	{
		return true;
	}

	return false;
}

Amount getAmount(Coin &machine)
{
	Amount amount;

	while (machine.quarter >= 4)
	{
		machine.quarter -= 4;
		amount.dollar++;
	}

	amount.quarter = machine.quarter;

	while (machine.dime >= 10)
	{
		machine.quarter -= 10;
		amount.dollar++;
	}

	amount.dime = machine.dime;

	while (machine.nickel >= 20)
	{
		machine.nickel -= 10;
		amount.dollar++;
	}
}