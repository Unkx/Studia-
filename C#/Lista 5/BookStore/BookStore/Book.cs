using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    internal class Book
    {
        int id;
        string imieAutora;
        string nazwiskoAutora;
        string rokUrodzenia;
        int rokWydania;
        string KolorOkladki;
        string kupionaKsiazka;
        int przeczytaneStrony;

        public Book() : base() { }

        /*public Book()
        {
            liczbaOsob += 1;
            this.id = liczbaOsob;
            this.imieAutora = "-";
            this.nazwiskoAutora = "-";
            this.rokWydania = 2003;
            this.KolorOkładki = "-";
            this.kupionaKsiazka = "-";
            this.przeczytaneStrony = "-";


        }
        public Book(string imie, string nazwisko, int rokUrodzenia, int wiek, int koszyk, string ulubionyAutor, string ulubionaKsiazka, string kupionaKsiazka, int rokWydania, int przeczytaneStrony)
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

        public Book(Book o)
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
        */
        public string[] Wypisz()
        {
            string[] clientInfo = new string[]
            {
            "ID:\t\t" + id,
            "Imię i nazwisko:\t" + imieAutora + " " + nazwiskoAutora,
            "Rok urodzenia:\t" + rokUrodzenia,
            "Kupiona książka:\t" + kupionaKsiazka,
            "Rok wydania:\t" + rokWydania,
            "Kolor okładki:\t" + KolorOkladki,
            "Przeczytane strony:\t" + przeczytaneStrony,
            "=================================="
            };
            return clientInfo;
        }

    }
}

