/*
PROJECT 5-1
Written by Morgan McCollum
This program displays calories burned from running on a treadmill.
*/

#include <iostream>
using namespace std;

int main()
{
	int minutes;
	double calories = 3.9;

	// Display the base amount.
	cout << "You burn " << calories << " calories a minute while running on a treadmill." << endl;

	// Calculate time on treadmill.
	for (minutes = 10; minutes < 35; minutes += 5)
	{
		cout << "After " << minutes << " minutes, " << (calories*minutes) << " calories are burned." << endl;
	}
	system("PAUSE");
	return 0;
}
