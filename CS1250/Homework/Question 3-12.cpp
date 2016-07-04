#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	double divSales;
	cout << "Enter the sales.";
	cin >> divSales;
	cout << setprecision(2) << fixed << showpoint << setw(8) << divSales << endl;
	system("PAUSE");
	return 0;
}