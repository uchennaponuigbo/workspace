#pragma once
#ifndef BIGINT
#define BIGINT

#include <iostream>
#include <string>
using namespace std;

const int Max_Digits = 20;

class BigInt
{
private:
	int digits[Max_Digits];
	bool valid;
	string expr;
	string invalidReason;
public:
	BigInt(string term = "0");
	~BigInt();
	bool setValue(string term);
	string getValue() const;
	void print() const;
	bool isValid() const;
	string getInvalidReason() const;
	BigInt add(const BigInt &otherBigInt) const;
	BigInt sub(const BigInt & otherBigInt) const;
	BigInt mul(const BigInt& otherBigInt) const;
	//bool equal(const BigInt &r) const;
	
};

//http://www.cplusplus.com/forum/beginner/154852/
//http://www.cplusplus.com/forum/beginner/110671/
//https://sourceforge.net/projects/cpp-bigint/
//https://github.com/topics/biginteger?l=c%2B%2B

#endif BIGINT