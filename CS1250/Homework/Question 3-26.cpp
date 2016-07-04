// This program calculates the total of a retail sale.

#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	double saleAmount, taxRate, tax, saleTotal;

	// Find the amount of the sale.
	cout << "What is the amount of the sale? ";
	cin >> saleAmount;

	// Find the sales tax rate.
	cout << "What is the sales tax rate? (Please enter as a decimal) ";
	cin >> taxRate;

	// Display the amount of sales tax.
	tax = saleAmount * taxRate;
	cout << setprecision(2) << fixed << showpoint << "The amount of sales tax is: $" << tax << endl;

	// Display the total of the sale.
	saleTotal = saleAmount + tax;
	cout << setprecision(2) << fixed << showpoint << "The total of the sale is: $" << saleTotal << endl;
	system("PAUSE");
	return 0;
}