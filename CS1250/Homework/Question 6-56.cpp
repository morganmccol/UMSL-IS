// This program adds two numbers entered by the user.
#include <iostream>
using namespace std;

int product(int, int, int);

int main()
{
	int value1, value2, value3;
	return 0;
}

int product(int value1, int value2, int value3)
{
	cout << product(2, 5, 10); // prints 100
	cout << product(2, 5); // prints 10
	cout << product(2); // prints 2
	return value1 * value2 * value3;
}