using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad._4
{
    internal class Klient
    {
        int id;
        string imie;
        string nazwisko;
        int rokUrodzenia;
        static int liczbaOsob = 0;
        int koszyk;
        string ulubionyAutor;
        string ulubionaKsiazka;
        string kupionaKsiazka;
        int rokWydania;

        public Klient()
        {
            liczbaOsob += 1;
            this.id = liczbaOsob;
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.rokUrodzenia = rokUrodzenia;
            this.koszyk = 2;
            this.ulubionyAutor = "-";
            this.ulubionaKsiazka = "-";
            this.kupionaKsiazka = "-";
            this.rokWydania = 365434;


        }
    }

}
 
