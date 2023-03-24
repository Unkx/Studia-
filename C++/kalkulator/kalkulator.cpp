#include <iostream>
#include <cmath>
using namespace std;

int main() {
    int a,b;
    int dzialanie;
    int wynik;

    cout << "Co Chcesz Wykonac" << endl << "1. Dodawanie" << endl << "2. Odejmowanie" << endl << "3. Mnozenie" 
    << endl << "4. Dzielenie" << endl << "5.Pierwiastkowanie" << endl <<"6. Potegowanie" << endl << "Wybierz inną liczbę by wyjść" << endl;
    cin >> dzialanie;

    switch (dzialanie)
     {
        case 1: 
            cout << "Podaj dwie liczby:" << endl;
            cin >> a >> b;
            cout <<"wynik : "<< a + b << endl; 
            break;
        case 2 :
            cout << "Podaj dwie liczby:" << endl;
            cin >> a >> b;
            cout <<"wynik : "<< a - b << endl;  
            break;
        case 3:
            cout << "Podaj dwie mnozne:" << endl;
            cin >> a >> b;
            cout <<"wynik : "<< a * b << endl;  
            break;
        case 4:
            cout << "Podaj dzielną i dzielnik:" << endl; 
            cin >> a >> b;
            cout <<"wynik : "<< a / b << endl;
            break;
        case 5:
            cout << "Podaj liczbę " << endl;
            cin >> a ;
            cout <<"wynik : "<< sqrt(a) << endl;
            break;
        case 6:
            cout << "Podaj podstawę i wykładnik:" << endl;
            cin >> a >> b;
            cout <<"wynik : "<< pow(a,b) << endl;
            break;
        }


}