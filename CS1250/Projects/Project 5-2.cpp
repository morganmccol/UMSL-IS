/*
PROJECT 5-2
Written by Morgan McCollum
This program reads a number and the name of a data
file from the user and tells the user what word is
in the file and how many times the number shows up!
*/

#include <iostream>
#include <fstream>
#include <string>

using namespace std;

int main()
{

	int number, check, count = 0;
	ifstream inputFile;
	string filename, word;

	// Read a number 1-100 from user
	cout << "Give a number 1-100: ";
	cin >> number;

	// Validate input number
	while (number < 1 || number > 100)
	{
		cout << "ERROR: invalid number!" << endl;
		cout << "Give a number 1 - 100: ";
		cin >> number;
	}

	// Read the name of a data file
	cout << "Give a filename: ";
	cin >> filename;
	inputFile.open(filename.c_str());

	// Validate file
	while (!inputFile)
	{
		cout << "ERROR: invalid filename!" << endl;
		cout << "Give a filename : ";
		cin >> filename;
		inputFile.open(filename.c_str());
	}

	// Tell user what word is in file
	inputFile >> word;
		
	// Tell user how many times the number shows up
	while (inputFile >> check)
	{
		if (check == number)
		count++;
	}

	// Display the result
	cout << "The file contains the word " << word
		 << " and the number " << number << " appears "
		 << count << " times" << endl;
	
	// Close file
	inputFile.close();
	return 0;
}
