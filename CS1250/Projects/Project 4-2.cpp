/*
PROJECT 4-2
Written by Morgan McCollum
This program calculates grams of fat in food.
*/

#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	char choice;
	int calories, fat;
	double fatCal, percent;

	// Display the menu
	cout << "You have the following food choices: " << endl;
	cout << "B - breakfast" << endl;
	cout << "L - lunch" << endl;
	cout << "D - dinner" << endl;
	cout << "Which would you like? " << endl;
	cin >> choice;

	// Set the numeric output formatting.
	cout << fixed << showpoint << setprecision(1);

	// Respond to menu selection
	switch (choice)
	{
	case 'B': // Breakfast
	case 'b':
			// Ask for the number of calories and fat grams
			cout << "How many calories are in your food?" << endl;
		cin >> calories;
		if (calories < 0)
		{
			cout << "Number of calories cannot be less than 0." << endl;
			break;
		}

		cout << "How many grams of fat?" << endl;
		cin >> fat;
		if (fat < 0)
		{
			cout << "Number of fat grams cannot be less than 0." << endl;
			break;
		}

		// Determine how many calories come from fat grams
		fatCal = fat * 9;
		percent = (fatCal / calories) * 100;

		// Input validation
		{
			if (fatCal < calories)
			{
				if (percent <= 10)
				{
					cout << percent << "% of calories come from fat." << endl;
					cout << "This food is low in fat!" << endl;
				}
				else
				{
					cout << percent << "% of calories come from fat." << endl;
				}
			}
			else
			{
				cout << "Calories from fat cannot be greater than the total number of calories." << endl;
				break;
			}
		}
		break;

	case 'L':	// Lunch
	case 'l':
			// Ask for the number of calories and fat grams
			cout << "How many calories are in your food?" << endl;
		cin >> calories;
		if (calories < 0)
		{
			cout << "Number of calories cannot be less than 0." << endl;
			break;
		}

		cout << "How many grams of fat?" << endl;
		cin >> fat;
		if (fat < 0)
		{
			cout << "Number of fat grams cannot be less than 0." << endl;
			break;
		}

		// Determine how many calories come from fat grams
		fatCal = fat * 9;
		percent = (fatCal / calories) * 100;

		// Input validation
		{
			if (fatCal < calories)
			{
				if (percent <= 20)
				{
					cout << percent << "% of calories come from fat." << endl;
					cout << "This food is low in fat!" << endl;
				}
				else
				{
					cout << percent << "% of calories come from fat." << endl;
				}
			}
			else
			{
				cout << "Calories from fat cannot be greater than the total number of calories." << endl;
				break;
			}
		}
		break;

	case 'D': // Dinner
	case 'd':
			// Ask for the number of calories and fat grams
			cout << "How many calories are in your food?" << endl;
		cin >> calories;
		if (calories < 0)
		{
			cout << "Number of calories cannot be less than 0." << endl;
			break;
		}

		cout << "How many grams of fat?" << endl;
		cin >> fat;
		if (fat < 0)
		{
			cout << "Number of fat grams cannot be less than 0." << endl;
			break;
		}

		// Determine how many calories come from fat grams
		fatCal = fat * 9;
		percent = (fatCal / calories) * 100;

		// Input validation
		{
			if (fatCal < calories)
			{
				if (percent <= 30)
				{
					cout << percent << "% of calories come from fat." << endl;
					cout << "This food is low in fat!" << endl;
				}
				else
				{
					cout << percent << "% of calories come from fat." << endl;
				}
			}
			else
			{
				cout << "Calories from fat cannot be greater than the total number of calories." << endl;
				break;
			}
		}
		break;

	default:
		cout << choice << " is not a valid menu choice." << endl;
	}
	system("PAUSE");
	return 0;
}