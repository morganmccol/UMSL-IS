/*
PROJECT 7
Written by Morgan McCollum
This program reads test scores from a file
and arranges them into a 2D array.
*/

#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	const int NUM_STUDENTS = 5; // Number of students
	const int NUM_SCORES = 3; // Number of test scores
	double scores[NUM_STUDENTS][NUM_SCORES] = { { 90, 80, 100 },
												{ 70, 90, 60 },
												{ 60, 70, 100 },
												{ 80, 70, 80 },
												{ 90, 80, 90 } };

	int count = 0;
	double total, highest;
	double test_average, student_average;

	// Print average per student (5); single line, 2 decimals
	cout << "Average per student: ";
	for (int row = 0; row < NUM_STUDENTS; row++)
	{
		total = 0;

		for (int col = 0; col < NUM_SCORES; col++)
			total += scores[row][col];

		student_average = total / NUM_SCORES;

		cout << setprecision(2) << fixed;
		cout << student_average << " ";
	}
	cout << endl;

	// Print average per test (3); single line, 2 decimals
	cout << "Average per test: ";
	for (int col = 0; col < NUM_SCORES; col++)
	{
		total = 0;

		for (int row = 0; row < NUM_STUDENTS; row++)
			total += scores[row][col];
		
		test_average = total / NUM_STUDENTS;

		cout << setprecision(2) << fixed;
		cout << test_average << " ";
	}
	cout << endl;

	// Print overall best score; single line
	highest = scores[0][0];

	for (count = 1; count < scores[0][0]; count++)
	{
		if (scores[count][0] > highest)
		{
			highest = scores[count][0];
		}
	}
	cout << "Highest overall score: " << highest << endl;
	
	// Display scores that are As (> 90); single line
	int greater = 0;
	if (scores[NUM_STUDENTS][NUM_SCORES] >= 90)
	{
		greater++;
		cout << "Number of A's: " << greater << endl;
	}
	system("PAUSE");
	return 0;
}
