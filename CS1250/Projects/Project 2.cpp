/*
PROJECT 2
Written by Morgan McCollum
This program displays items sold in a store!
*/

#include <iostream>
using namespace std;

int main()
{
	double item1, item2, item3, item4, item5;
	double subtotal, salesTax, total;

	// Prices of the five items
	item1 = 12.95;
	item2 = 24.95;
	item3 = 6.95;
	item4 = 14.95;
	item5 = 3.95;

	// Display each item's price
	cout << "Price of item 1 = $" << item1 << endl;
	cout << "Price of item 2 = $" << item2 << endl;
	cout << "Price of item 3 = $" << item3 << endl;
	cout << "Price of item 4 = $" << item4 << endl;
	cout << "Price of item 5 = $" << item5 << endl;

	// Display the subtotal of the sale
	subtotal = item1 + item2 + item3 + item4 + item5;
	cout << "The subtotal of the sale is: $" << subtotal << endl;

	// Display the amount of sales tax
	salesTax = subtotal * 0.06;
	cout << "The amount of sales tax is: $" << salesTax << endl;
	
	// Display the total
	total = subtotal + salesTax;
	cout << "The total is: $" << total << endl;

	system("PAUSE");
	return 0;
}