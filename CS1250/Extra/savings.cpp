// This program calculates balance in a savings account.
#include <iostream>
using namespace std;

int main()
{
	double starting, deposit, withdrawal, balance, monthly, interest, total;

	// Get the starting balance.
	cout << "What is your starting balance? ";
	cin >> starting;

	// Get the total deposits.
	cout << "How much did you deposit? ";
	cin >> deposit;

	// Get the total withdrawals.
	cout << "How much did you withdrawal? ";
	cin >> withdrawal;

	// Calculate new balance.
	balance = starting + (deposit - withdrawal);

	// Get the interest.
	cout << "How much interest do you earn? ";
	cin >> interest;

	// Caluclate balance with interest.
	monthly = balance * interest;
	total = balance + monthly;

	// Display the balance.
	cout << "You have $" << total << endl;
	cout << "You are rich! ";
	system("PAUSE");
	return 0;
}
