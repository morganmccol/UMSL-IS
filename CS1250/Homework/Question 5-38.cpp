#include <iostream>
using namespace std;

int main()
{
	int num;
	int total = 0;

	// Get the number and iterate loop
	for (num = 0; num <= 10; num++)
	{
		cout << "Please enter a number." << endl;
		cin >> num;
		total += num;
	}
	cout << "The total is: " << total << endl;
	system("PAUSE");
	return 0;
}
