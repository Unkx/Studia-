#include <iostream>
using namespace std;
void dane()
{
    cout << "Podaj liczby" << endl;
	int x;
}
void obliczenia()
{
	int a1,a2,a3,a4,a5;
	cin >> a1 >> a2 >> a3 >> a4;
	if(a1 < a2 && a1 < a3)
        cout << "3 największa: " << a1;

    // check if n2 is the largest number
    else if(a2 < a1 && a2 < a3)
        cout << "3 największa : " << a2;
    
    // if neither n1 nor n2 are the largest, n3 is the largest
    else 
        cout << "3 największa : " << a3;
}
int main()
{
    dane();
	obliczenia();
}