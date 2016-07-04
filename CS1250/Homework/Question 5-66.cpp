// This program adds two numbers entered by the user.
#include <iostream>
using namespace std;

int main()
{
	int num1, num2;
	char again;

	do
	{
		cout << "Enter a number : ";
		cin >> num1;
		cout << "Enter another number : ";
		cin >> num2;
		cout << "Their sum is " << (num1 + num2) << endl;
		cout << "Do you want to do this again ? ";
		cin >> again;
	} while (again == 'y' || again == 'Y');
	system("PAUSE");
	return 0;
}
