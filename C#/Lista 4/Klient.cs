using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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
        int wiek;
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
            this.wiek = 23;
            this.koszyk = 2;
            this.ulubionyAutor = "-";
            this.ulubionaKsiazka = "-";
            this.kupionaKsiazka = "-";
            this.rokWydania = 2003;
            this.przeczytaneStrony = 20;


        }
        public Klient(string imie, string nazwisko, int rokUrodzenia, int wiek, int koszyk, string ulubionyAutor, string ulubionaKsiazka, string kupionaKsiazka, int rokWydania, int przeczytaneStrony)
        {
            liczbaOsob += 1;
            this.id = liczbaOsob;
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.rokUrodzenia = rokUrodzenia;
            this.wiek = wiek;
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
            this.wiek = o.wiek;
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


        public string[] Wypisz()
        {
            string[] clientInfo = new string[]
            {
            "Imię i nazwisko:\t" + imie + " " + nazwisko,
            "Rok urodzenia:\t" + rokUrodzenia,
            "Wiek:" + wiek,
            "Twój koszyk:\t" + koszyk,
            "Ulubiony Autor:\t" + ulubionyAutor,
            "Ulubiona książka:\t" + ulubionaKsiazka,
            "Kupiona książka:\t" + kupionaKsiazka,
            "Rok wydania:\t" + rokWydania,
            "Przeczytane strony:\t" + przeczytaneStrony,
            "=================================="
            };
            return clientInfo;
         }

    }


}

