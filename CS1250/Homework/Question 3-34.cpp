#include <iostream>
using namespace std;
int main()
{
	double salary, monthly;
	cout << "What is your annual salary ? ";
	cin >> salary;
	monthly = static_cast<int>(salary) / 12;
	cout << "Your monthly wages are " << monthly << endl;
	system("PAUSE");
	return 0;
}