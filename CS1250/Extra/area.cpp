// Fix the area.
#include <iostream>
using namespace std;

int main()
{
	double width, length, area;
 
	cout << "What is the room's width? ";
	cin >> width;

	cout << "What is the room's length? ";
	cin >> length;

	area = width * length;
	cout << "The total area of the room is " << area << endl;
	system("PAUSE");
	return 0;
}