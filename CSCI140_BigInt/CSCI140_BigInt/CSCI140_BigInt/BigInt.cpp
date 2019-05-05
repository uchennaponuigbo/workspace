#include "BigInt.h"
#include <iostream>
#include <string>
using namespace std;


BigInt::BigInt(string term) //value is always first stored here
{
	this->expr = term;
	this->invalidReason = "";
	this->valid = false;

	for (int i = 0; i < Max_Digits; i++)
	{
		this->digits[i] = 0;
	}

	this->setValue(term);
}


BigInt::~BigInt()
{
}


bool BigInt::setValue(string term) //converts properly now
{
	int length = term.length();
	this->expr = term;
	// Check if term is smaller htan max length
	if (length > Max_Digits) {
		this->valid = false;
		this->invalidReason = "too large";
		return false;
	}

	// Check if term is a valid number
	std::string::const_iterator it = term.begin();
	while (it != term.end() && ::isdigit(*it)) ++it;
	this->valid = !term.empty() && it == term.end();

	if (!this->valid)
	{
		this->invalidReason = "bad digit";
		return this->valid;
	}

	for (int i = 0; i < Max_Digits; i++)
	{
		this->digits[i] = 0;
	}

	for (int i = 0; i < length; i++)
	{
		int parsedValue = std::stoi(string(1, term[length - 1 - i]));
		this->digits[20 - i - 1] = parsedValue;
	}

	this->valid = true;

	return this->valid;
}

string BigInt::getValue() const
{
	return expr;
}

string BigInt::getInvalidReason() const
{
	return this->invalidReason;
}

bool BigInt::isValid() const //used after math calculation, the const prevents conversions
{
	return valid;
}

BigInt BigInt::add(const BigInt& otherBigInt) const
{
	string term = otherBigInt.getValue();
	int otherDigits[Max_Digits];
	string computedTerm = "";

	for (int i = 0; i < Max_Digits; i++)
	{
		otherDigits[i] = 0;
	}

	for (int i = 0; i < term.length(); i++)
	{
		int parsedValue = std::stoi(string(1, term[term.length() - 1 - i]));
		otherDigits[20 - i - 1] = parsedValue;
	}
	
	int carry = 0; 

	for (int i = Max_Digits - 1; i >= 0; i--)
	{
		int num = this->digits[i] + otherDigits[i] + carry;
		int computedValue = num % 10;
		computedTerm = std::to_string(computedValue) + computedTerm;
		carry = num / 10;
	}	

	if (carry > 0)
	{
		computedTerm = std::to_string(carry) + computedTerm;
	}

	BigInt computedInt = BigInt(computedTerm);

	return BigInt(computedTerm);
}


BigInt BigInt::sub(const BigInt& otherBigInt) const
{
	string term = otherBigInt.getValue();

	if (stoi(term) > stoi(this->expr))
	{
		return BigInt("Invalid");
	}

	int otherDigits[Max_Digits];
	string computedTerm = "";

	for (int i = 0; i < Max_Digits; i++)
	{
		otherDigits[i] = 0;
	}

	for (int i = 0; i < term.length(); i++)
	{
		int parsedValue = std::stoi(string(1, term[term.length() - 1 - i]));
		otherDigits[20 - i - 1] = parsedValue;
	}

	int borrow = 0;

	for (int i = Max_Digits - 1; i >= 0; i--)
	{
		int currentSubTerm = this->digits[i];
		bool isCarryOver = false;

		if (borrow > 0 && currentSubTerm == 0)
		{
			currentSubTerm = 10;
			isCarryOver = true;
		}

		int num = currentSubTerm - otherDigits[i] - borrow;

		if (num < 0)
		{
			num = 10 + num;
			borrow = 1;
		}
		else if(!isCarryOver)
		{
			borrow = 0;
		}

		computedTerm = std::to_string(num) + computedTerm;
	}

	BigInt computedInt = BigInt(computedTerm);

	return BigInt(computedTerm);
}

BigInt BigInt::mul(const BigInt& otherBigInt) const
{
	return this->add(otherBigInt);
}

void BigInt::print() const
{
	if (!this->valid)
	{
		cout << "";
		return;
	}

	string term = "";
	bool atFirstNonZeroTerm = false;

	for (int i = 0; i < Max_Digits; i++)
	{
		if (!atFirstNonZeroTerm && this->digits[i] == 0)
		{
			continue;
		}

		atFirstNonZeroTerm = true;
		term += std::to_string(this->digits[i]);
	}

	if (!atFirstNonZeroTerm)
	{
		term += "0";
	}

	cout <<  term;
}