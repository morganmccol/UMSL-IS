/*
PROJECT 6
Written by Morgan McCollum
This program allows a user to play a game of
Rock, Paper, Scissors against the computer!
*/

#include <iostream>
#include <fstream>
#include <cstdlib>
#include <ctime>
#include <string>

using namespace std;

int main()
{
	int menu();
	void winner(int, int);

	string choice, computer, again;
	int player, random;

	do
	{
		// Generate a random number between 1 and 3
		unsigned seed = time(0);
		srand(seed);
		random = 1 + rand() % 3;

		if (random == 1)
		{
			computer = "rock";
		}
		else if (random == 2)
		{
			computer = "paper";
		}
		else if (random == 3)
		{

			computer = "scissors";
		}

		// Display the menu and receive user input
		menu();

		// Display computer's choice
		cout << "The computer has chosen: " << computer << endl;

		// Send computer and user input to function and declare a winner
		winner(random, player);

		// Display a loop for multiple games until user quits
		cout << "Play again? ";
		cin >> again;
	} while (again == "yes" || again == "YES" || again == "y");

	return 0;
}

int menu(string choice, int player)
{
	cout << "WELCOME TO ROCK, PAPER, SCISSORS" << endl;
	cout << "Please choose a move: ";

	// User enters choice of "rock", "paper", or "scissors"
	cin >> choice;

	// Validate choice and return as a number 1-3
	if (choice == "rock" || choice == "Rock" || choice == "ROCK")
	{
		return player = 1;
	}
	else if (choice == "paper" || choice == "Paper" || choice == "PAPER")
	{
		return player = 2;
	}
	else if (choice == "scissors" || choice == "Scissors" || choice == "SCISSORS")
	{
		return player = 3;
	}
	else
	{
		cout << "Invalid choice" << endl;
		return 1;
	}
}

void winner(int random, int player)
{
	// Rock = 1, Paper = 2, Scissors = 3
	if (random == 1 && player == 2)
	{
		cout << "Paper wraps rock!" << endl;
		cout << "You win!" << endl;
	}
	else if (random == 2 && player == 1)
	{
		cout << "Paper wraps rock!" << endl;
		cout << "Computer wins!" << endl;
	}
	else if (random == 1 && player == 3)
	{
		cout << "Rock smashes scissors!" << endl;
		cout << "Computer wins!" << endl;
	}
	else if (random == 3 && player == 1)
	{
		cout << "Rock smashes scissors!" << endl;
		cout << "You win!" << endl;
	}
	else if (random == 2 && player == 3)
	{
		cout << "Scissors cut paper!" << endl;
		cout << "You win!" << endl;
	}
	else if (random == 3 && player == 2)
	{
		cout << "Scissors cut paper!" << endl;
		cout << "Computer wins!" << endl;
	}
	else if (random == player)
	{
		cout << "The game is a tie. Please play again." << endl;
	}
}
