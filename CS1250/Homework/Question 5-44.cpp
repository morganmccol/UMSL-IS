#include <iostream>
#include <fstream>
using namespace std;

int main()
{
	// Open output file "Numbers.txt"
	ofstream outputFile("Numbers.txt");

	// Use loop to write numbers 1 to 100
	for (int num = 1; num <= 100; num++)
	{
		cout << num << endl;
	}

	// Close file
	outputFile.close();

	system("PAUSE");
	return 0;
}
