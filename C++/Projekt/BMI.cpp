#include <iostream>
#include <cmath>
#include <iomanip>
#include <locale.h>
#include <conio.h>

using namespace std;

int main(){
        setlocale(LC_CTYPE, "Polish");
        int number;
        cout << "WITAMY W KALKULATORZE BMI !" << endl;

        int waga;
        double wzrost, wynik;

        cout << "PODAJ WAGĘ : " <<  endl; 
        cout << "> ";
        cin >> waga ; 

        cout << "PODAJ WZROST : " <<  endl;
        cout << "> ";
        cin  >> wzrost ;
                    

        cout << "TwOJE BMI WYNOSI :" << endl;
                
        wynik = waga/ pow(wzrost,2) ;
        printf("%.2f",wynik) ;

        if(wynik < 16){
            cout << endl << "TwOJE BMI WSKAZUJE NA WYGŁODZENIE" << endl;
        }
        else if(wynik >= 17){
            cout << endl << "SKRAJNA NADWAGA" << endl;
        }
        else if(wynik >= 18.45){
            cout << endl << "NIEDOWAGA" << endl;
        }
        else if(wynik >= 25){
            cout << endl << "I STOPIEŃ OTYŁOŚCI" << endl;
        }
        else if(wynik >= 30){
            cout << endl << "II STOPIEŃ OTYŁOŚCI" << endl;
        }
        else if(wynik >= 35){
            cout << endl << "NADWAGA 2 STOPNIA" << endl;
        }
        else {
            cout << endl << "SKRAJNA NADWAGA" << endl;
        }
        //https://bmi-online.pl//
    }