#include <iostream>
using namespace std;

int main()
{
	int sales, company;

	// How much did the company generate?
	company = 4600000;

	// How much of total sales were generated by the East Coast division?
	sales = company * .62;

	// Find East Coast sales from total sales.
	cout << "$" << sales << " of sales were generated by the East Coast division." << endl;

	system("PAUSE");
	return 0;
}