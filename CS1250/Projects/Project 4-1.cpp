/*
PROJECT 4-1
Written by Morgan McCollum
This program finds magic dates!
*/

#include <iostream>
using namespace std;

int main()
{
	int day, month, year;

	// Ask for date
	cout << "Please enter a month, day, and two-digit year." << endl;

	// Receive date
	cout << "Month: (in numeric form) ";
	cin >> month;
	cout << "Day: ";
	cin >> day;
	cout << "Year: (two digits) ";
	cin >> year;

	// Is it magic?
	if (month * day == year)
		cout << "The date is magic!";
	else
		cout << "The date is not magic...";


	system("PAUSE");
	return 0;
}
