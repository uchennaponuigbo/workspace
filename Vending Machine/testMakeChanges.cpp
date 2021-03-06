// Created by T. Vo for CSCI 140 Spring 2019.
// A test driver to test makeChanges function.

#include <iostream>

using namespace std;

struct Coin  // Coin consists of quarters, dimes, and nickels 
{     
	int q, d, n; 
}; 

bool makeChanges(int amount, Coin &machine, Coin &back);
	// amount – change amount to give back
	// machine – current quarters, dimes, and nickels in machine     
	// back – quarters, dimes, and nickels to give back     
	// return true for sufficient changes; return false otherwise 

void printCoin(Coin c);			// help with testing/debugging

int main()
{
	Coin machine, change;
	bool valid;
	int changeAmount;

	// test case 1
	machine.q = 2;
	machine.d = 4;
	machine.n = 4;
	changeAmount = 35;

	// can also input data
	// cin >> machine.q >> machine.d >> machine.n;

	cout << "Coin before: " << endl;
	printCoin(machine);
	valid = makeChanges(changeAmount, machine, change);
	if (valid)
	{
		cout << "Coin after: " << endl;
		printCoin(machine);
		cout << "Changes: " << endl;
		printCoin(change);
	}
	else
		cout << "Not a valid transaction." << endl;

    return 0;
}

bool makeChanges(int amount, Coin &machine, Coin &back)
{
	bool valid = true;

	// simulate one test case; need to replace with actual processing
	back.q = 2;
	back.d = 1;
	back.n = 1;
	machine.q -= back.q;
	machine.d -= back.d;
	machine.n -= back.n;

	return valid;
}


void printCoin(Coin c)
{
	cout << "    Quarters:   " << c.q << endl;
	cout << "    Dimes:      " << c.d << endl;
	cout << "    Nickels:    " << c.n << endl << endl;
}

