#include <iostream>
using namespace std;

int main() {
  cout << "podaj liczbe" << endl;
  int decimal, binarna = 0, remainder, product = 1;
  cin >> decimal;
  while (decimal != 0) {
    remainder = decimal % 2;
    binarna = binarna + (remainder * product);
    decimal = decimal / 2;
    product *= 10;
  }
  cout << "Liczba w kodzie binarnym: " << binarna ;
  return 0;
}