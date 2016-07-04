/*
PROJECT 3
Written by Morgan McCollum
This program displays the results of an election
*/

#include <iostream>
#include <iomanip>
#include <string>
using namespace std;

int main()
{
	string name1, name2, name3;
	double vote1, vote2, vote3, total;
	double pct1, pct2, pct3;

	// First candidate
	cout << "Give name: ";
	cin >> name1;
	cout << "Give votes: ";
	cin >> vote1;

	// Second candidate
	cout << "Give name: ";
	cin >> name2;
	cout << "Give votes: ";
	cin >> vote2;

	// Third candidate
	cout << "Give name: ";
	cin >> name3;
	cout << "Give votes: ";
	cin >> vote3;

	// Calculate percentage
	total = vote1 + vote2 + vote3;
	pct1 = vote1 / total;
	pct1 *= 100;
	pct2 = vote2 / total;
	pct2 *= 100;
	pct3 = vote3 / total;
	pct3 *= 100;
	cout << endl;

	// Display results
	cout << setw(8) << left << name1 << " ";
	cout << setw(8) << right << vote1 << " ";
	cout << setw(8) << setprecision(1) << fixed << pct1 << "%" << endl;

	cout << setw(8) << left << name2 << " ";
	cout << setw(8) << right << noshowpoint << setprecision(0) << vote2 << " ";
	cout << setw(8) << setprecision(1) << fixed << pct2 << "%" << endl;

	cout << setw(8) << left << name3 << " ";
	cout << setw(8) << right << noshowpoint << setprecision(0) << vote3 << " ";
	cout << setw(8) << setprecision(1) << fixed << pct3 << "%" << endl << endl;

	// Display total votes
	cout << noshowpoint << setprecision(0) << "Total votes " << total << endl;
	return 0;
}
