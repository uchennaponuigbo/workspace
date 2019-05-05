#include "BigInt.h"
#include <iostream>
#include <string>
using namespace std;

BigInt::BigInt(string s) //value is always first stored here
{
	expr = s;
	valid = true;
	for (int i = 0; i < Max_Digits; i++)
	{
		digits[i] = 0;
	}
}

BigInt::~BigInt()
{
}

bool BigInt::setValue(string s) //converts properly now
{
	if (expr.length() < Max_Digits) //try converting to array in setvalue, >
	{
		int strLen = expr.length();
		for (int i = 0; expr[i] != '\0'; i++)
		{
			char currentChar = expr.at(i);
			if (currentChar<(char)'0' || currentChar>(char)'9')
			{
				//cout << "Error! Invalid Characters!" << endl;
				valid = false;
				break;
				

			}
			else
			{
				digits[Max_Digits - (strLen - i)] = expr[i] - '0';
				expr = s;
				valid = true;

			}		//valid = false;	
		}	
	}
	else
	{
		/*expr = s;
		valid = true;*/
		valid = false;
	}
	return valid;
}

string BigInt::getValue() const
{
	return expr;
}

bool BigInt::isValid() const //used after math calculation, the const prevents conversions
{
	
	
	return valid;
}

//BigInt BigInt::add(const BigInt &r) const
//{
//	//read section in book about declaring class variables
//	BigInt sum[Max_Digits];
//	
//	int carry = 0; 
//	for (int i = Max_Digits - 1; i >= 0; i--)
//	{
//		//sum.digits = digits + r.digits + carry;
//		int num = digits[i] + r[i] + carry;
//		sum->digits[i] = num % 10;
//		carry = num / 10;
//
//		if (i == 0 && carry > 0) //these lines may not be needed
//			valid = true;
//	}
//	return sum[Max_Digits];
//}

//BigInt BigInt::subtract(const BigInt &r) const
//{
//	/*int borrow = 0;
//	for (int i = Max_Digits - 1; i >= 0; i--)
//	{
//		int num = sub1[i] - sub2[i] - borrow;
//		if (num < 0)
//		{
//			num += 10;
//			borrow++;
//		}
//		diff[i] = num;
//	}*/
//}

//void BigInt::print() const
//{
//	/*for (int i = 0; i < Max_Digits; i++)
//		cout << digits[i];*/
//	
//	for (int i = Max_Digits - 1; i >= 0; i--)
//	{
//		if (digits[i]) break;
//	}
//	// digit is now the index of the most significant non-zero digit, or -1
//	// If digit is -1 then print '0' and return. This is a special case for 0.
//	// Otherwise execute a loop. At each step, print numbers[digit]
//	// and decrement digit.
//	// You will also want to keep track of how many digits you've printed
//	// on this line. If it's 20 then print a new line and reset the counter.
//}
