#include <iostream>
using namespace std;
float a1, a2, b1, b2, c1, c2, x, y;
float w, wx, wy;
void dane()
{
	cout << "Podaj a1: ";
	cin >> a1;
	cout << "Podaj a2: ";
	cin >> a2;
	cout << "Podaj b1: ";
	cin >> b1;
	cout << "Podaj b2: ";
	cin >> b2;
	cout << "Podaj c1: ";
	cin >> c1;
	cout << "Podaj c2: ";
	cin >> c2;
}
void obliczenia()
{
	w = a1 * b2 - a2 * b1;
	wx = c1 * b2 - b1 * c2;
	wy = a1 * c2 - c1 * a2;
	x = wx / w;
	y = wy / w;

	if (w == 0 && wx==0 && wy==0)
	{
        
		cout << "Uklad,ma nieskonczenie wiele rozwiazan.";
	}
	if (w == 0 && (wx != 0 || wy != 0))
	{
		cout << "Uklad jest sprzeczny";
	}	
	if (w != 0)
	{
		cout << "Posiada jedno rozwiazanie: ";
	}
wynik:
	cout << endl << "x=" << x << endl << "y=" << y;
	
}	
int main()
{
	dane();
	obliczenia();
	return 0;
}