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

bool makeChanges(int amount, Coin &machine, Coin &back);
string getBalanceString(Coin& coin, int dollars);
void printFinalReport(int validTransactions, int insertedDollars, Coin &machine);
void initializeMachine(Coin &machine);

int main()
{
	Coin machine;
	int insertedDollars = 0;
	int purchaseAmount = -1;
	int amount = -1;
	int validTransactions = 0;

	initializeMachine(machine);

	while (purchaseAmount != 0)
	{
		Coin back;
		int insertedQuarters = 0;
		int insertedDimes = 0;
		int insertedNickels = 0;
		int insertedTotal = 0;
		int option = 0;
		string optionString = "dollar";

		cout << "Enter the purchase amount [0 - 100]." << endl;
		cin >> purchaseAmount;

		if (purchaseAmount == 0)
		{
			printFinalReport(validTransactions, insertedDollars, machine);
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

		while (option != 1 && option != 2)
		{
			cout << "Select an option, 1 for dollar bill, 2 for coins" << endl;
			cin >> option;
		}		

		switch (option)
		{
		case 1:
			insertedTotal = 100;
			insertedDollars++;
			cout << "You entered an amount of 100." << endl;
			break;

		case 2:
			optionString = "coins";
			int currentAmount = -1;
			int totalAmount = 0;

			cout << "Please insert your coins." << endl;

			while (currentAmount != 0 && insertedTotal < 100)
			{
				cin >> currentAmount;

				switch (currentAmount)
				{
				case 25:
					insertedTotal += currentAmount;
					insertedQuarters++;
					break;
				case 10:
					insertedTotal += currentAmount;
					insertedDimes++;
					break;
				case 5:
					insertedTotal += currentAmount;
					insertedNickels++;
					break;
				default:
					break;
				}
			}

			cout << "You entered an amount of " << insertedTotal << " cents." << endl;
			break;
		}

		if (insertedTotal < purchaseAmount)
		{
			cout << "Insufficient amount." << endl;
			cout << "Your transaction cannot be processed." << endl;
			continue;
		}
		else
		{
			machine.quarter += insertedQuarters;
			machine.dime += insertedDimes;
			machine.nickel += insertedNickels;
		}

		cout << "Processing your purchase ..." << endl;

		int amount = insertedTotal - purchaseAmount;
		bool areChangesValid = makeChanges(amount, machine, back);

		if (areChangesValid)
		{
			validTransactions++;
			int totalChange = back.quarter * 25 + back.nickel * 5 + back.dime * 10;

			cout << "Your change of " << totalChange << " is given as:" << endl;
			cout << "    quarters: " << back.quarter << endl;
			cout << "    dimes: " << back.dime << endl;
			cout << "    nickels: " << back.nickel << endl;
		}
		else
		{
			cout << "Insufficient changes." << endl;
			cout << "Your transaction cannot be processed." << endl;
			cout << "Please take back your " << optionString << "." << endl;

			machine.quarter -= insertedQuarters;
			machine.dime -= insertedDimes;
			machine.nickel -= insertedNickels;
		}

		cout << endl;
	}

	cin >> amount;

	return 0;
}

string getBalanceString(Coin& coin, int dollars) {
	int balance = (25 * coin.quarter) + (10 * coin.dime) + (5 * coin.nickel);
	int currentDollars = dollars + (balance / 100);
	int cents = balance % 100;
	string centsString = to_string(cents);

	if (centsString.length() < 2) {
		centsString += "0";
	}

	return "$" + to_string(currentDollars) + "." + to_string(cents);
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
		remainingAmount -= 5;
		back.nickel++;
		machine.nickel--;
	}

	if (remainingAmount == 0)
	{
		return true;
	}

	machine.quarter = initialNumberOfQuarters;
	machine.dime = initialNumberOfDimes;
	machine.nickel = initialNumberOfNickels;

	return false;
}

void initializeMachine(Coin &machine)
{
	cout << "Author: Uchenna Onuigbo\n";
	cout << "Vending Machine Version 1" << endl;
	cout << "Fill up machine with changes. Please wait..." << endl;
	cout << "Enter the # of quarters, dimes and nickels in this order." << endl;
	cin >> machine.quarter >> machine.dime >> machine.nickel;
	cout << "There are " << machine.quarter << " quarter(s), " << machine.dime << " dime(s), and " << machine.nickel << " nickle(s)." << endl;
	cout << "Initial machine balance is " << getBalanceString(machine, 0) << "." << endl;
	cout << "One-dollar bill or coins will be accepted." << endl;
	cout << "Only amount between 0 and 100 and multiple of 5 is accepted." << endl;
	cout << "Enter 0 to stop the program." << endl;
	cout << "Machine is now ready." << endl;
	cout << endl;
}

void printFinalReport(int validTransactions, int insertedDollars, Coin &machine)
{
	cout << "Final report is being generated ..." << endl;
	cout << "There are " << validTransactions << " valid transactions." << endl;
	cout << "Number of dollars: " << insertedDollars << endl;
	cout << "Number of quarters: " << machine.quarter << endl;
	cout << "Number of dimes: " << machine.dime << endl;
	cout << "Number of nickles: " << machine.nickel << endl;
	cout << "Machine balance: " << getBalanceString(machine, insertedDollars) << endl;
	cout << "Machine is shutting down." << endl;
}