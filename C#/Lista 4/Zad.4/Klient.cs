using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Zad._4
{
    public class Klient
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
        int przeczytaneStrony;

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
            this.rokWydania = 2003;
            this.przeczytaneStrony = 20;


        }
        public Klient(int id, string imie, string nazwisko, int rokUrodzenia, int koszyk, string ulubionyAutor, string ulubionaKsiazka, string kupionaKsiazka, int rokWydania, int przeczytaneStrony)
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
            this.przeczytaneStrony = przeczytaneStrony;
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
            this.przeczytaneStrony = o.przeczytaneStrony;
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
            lb.Items.Add("Wiek:\t\t" + ObliczWiek());
            lb.Items.Add("Twój koszyk:\t" + koszyk);
            lb.Items.Add("Ulubiony Autor:\t" + ulubionyAutor);
            lb.Items.Add("Ulubiona książka:" + ulubionaKsiazka);
            lb.Items.Add("Kupiona książka:" + kupionaKsiazka);
            lb.Items.Add("Rok wydania:\t" + rokWydania + "\n");
        }
        private int ObliczWiek()
        {
            return DateTime.Now.Year - rokUrodzenia;
        }

        private void StronyPrzeczytane()
        {
            // prywatna metoda dla przeczytanych stron (nie wiem czy potrzebne) // 
        }

        public void Strony()
        {
            if (przeczytaneStrony > 0)
            {

                Console.WriteLine("Klient przeczytał " + przeczytaneStrony);
            }
            else
            {
                Console.WriteLine("Klient jeszcze nie przeczytał zakupionej książki");
            }
        }

    }

}

