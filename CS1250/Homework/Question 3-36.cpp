#include <iostream>
#include <iomanip>
#include <string>
using namespace std;

int main()
{
	string userInput;
	cout << "What is your name ? ";
	getline(cin, userInput);
	cout << "Hello " << userInput << endl;
	system("PAUSE");
	return 0;
}