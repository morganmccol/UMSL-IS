#include <iostream>
using namespace std;

int main()
{
	// Send an array plus an extra integer
	// and the function will return the number of times
	// that value is found in the array

	// int numbers [SIZE]; is initalized
	// SIZE 7 contains {1,2,3,2,3,3,3}
	// x = counter (numbers, SIZE, 3); will return 4 in x

	int counter(int numbers, int SIZE[], int search);

	int SIZE[7] = {1,2,3,2,3,3,3};
	
	int numbers = 0;
	int x = counter(numbers, SIZE, 7);
	cout << x;

	system("PAUSE");
	return 0;
}

int counter(int numbers, int SIZE[], int search)
{
	int counter = 0;
	for (int i = 0; i < search; i++)
		if (SIZE[i] == numbers)
			counter++;
	return counter;
}