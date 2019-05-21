// C++Pointers.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include <iostream>
#include <string>
#include <stdio.h>
#include <string>



using namespace std;



void substitute(char* s, char c1, char c2)
{
	
	
		for (; *s; ++s)
			if (*s == c1) *s = c2;

	
}


int main(char* argv[], int argc)
{
	
	char s[] = "label";
	char c1 = 'a';
	char c2 = 'x';

	cout << "Before swap of Char : " << s << endl;

	substitute(s, c1, c2);

	cout << "After swap of Char : " << s << endl;


	cin.get();
}




// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
