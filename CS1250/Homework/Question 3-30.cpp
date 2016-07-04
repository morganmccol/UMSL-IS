#include <iostream>
using namespace std;

int main()
{
	int number1, number2, product;

	cout << "Enter two numbers and I will multiply\n";
	cout << "them for you. \n";
	cin >> number1 >> number2;
	product = number1 * number2;
	cout << product;
	system("PAUSE");
	return 0;
}