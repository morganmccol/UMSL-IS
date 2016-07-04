// This program calculates the user's pay.
#include <iostream>
using namespace std;

int main()
{
	double hours, rate, pay;

		// Get the number of hours worked.
		cout << "How many hours did you work? ";
		cin >> hours;

		// Get the hours pay rate.
		cout << "How much do you get paid per hour? ";
		cin >> rate;

		// Calculate the pay.
		pay = hours * rate;

		// Display the pay.
		cout << "You have earned $" << pay << endl;

		// Stay open.
		cout << "Good for you! ";
		system("PAUSE");
		return 0;
}
