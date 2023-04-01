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
            this.imie = "-";
            this.nazwisko = "-";
            this.rokUrodzenia = 2000;
            this.koszyk = 2;
            this.ulubionyAutor = "-";
            this.ulubionaKsiazka = "-";
            this.kupionaKsiazka = "-";
            this.rokWydania = 365434;


        }
        public Klient(int id, string imie, string nazwisko, int rokUrodzenia, int koszyk, string ulubionyAutor, string ulubionaKsiazka, string kupionaKsiazka, int rokWydania)
        {
            liczbaOsob += 1;
            this.id = liczbaOsob;
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.rokUrodzenia = rokUrodzenia;
            this.koszyk = koszyk;
            this.ulubionyAutor = ulubionyAutor;
            this.ulubionaKsiazka = ulubionaKsiazka;
            this.kupionaKsiazka = kupionaKsiazka;
            this.rokWydania = rokWydania;
        }

        public Klient(Klient o)
        {
            liczbaOsob += 1;
            this.id = liczbaOsob;
            this.imie = o.imie;
            this.nazwisko = o.nazwisko;
            this.rokUrodzenia = o.rokUrodzenia;
            this.koszyk = o.koszyk;
            this.ulubionyAutor = o.ulubionyAutor;
            this.ulubionaKsiazka = o.ulubionaKsiazka;
            this.kupionaKsiazka = o.kupionaKsiazka;
            this.rokWydania = o.rokWydania;
        }

        ~Klient()
        {
            MessageBox.Show("Likwidacja obiektu klasy Klient");
        }

        public void Wypisz(ListBox lb)
        {
            lb.Items.Add("id:\t\t" + id);
            lb.Items.Add("Imię i nazwisko:\t" + imie + " " + nazwisko);
            lb.Items.Add("Rok urodzenia:\t" + rokUrodzenia);
            lb.Items.Add("Wiek:\t\t" + ObliczWiek()); //wywołanie metody prywatnej
            lb.Items.Add("");
        }
        private int ObliczWiek()
        {
            return DateTime.Now.Year - rokUrodzenia;
        }
    }

}
 
