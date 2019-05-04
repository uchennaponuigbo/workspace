#pragma once
#include<iostream>
#include<string>

using namespace std;
const int Max_Digits = 20;
class BigInt
{
private:
	int digits[Max_Digits];
	bool valid; 
	string expr; 
public:
	BigInt(string s = "0");

	bool setValue(string s);

	string getValue() const; 
		//returns string value like "1234", used like cout << ClassVar.getValue(); in main

	//BigInt add(const BigInt &r) const; //set valid to true for integer overflow

	//BigInt subtract(const BigInt &r) const;

	bool isValid() const;

	//bool equal(const BigInt &r) const;

	//void print() const;
	~BigInt();
};

//http://www.cplusplus.com/forum/beginner/154852/
//http://www.cplusplus.com/forum/beginner/110671/
//https://sourceforge.net/projects/cpp-bigint/
//https://github.com/topics/biginteger?l=c%2B%2B