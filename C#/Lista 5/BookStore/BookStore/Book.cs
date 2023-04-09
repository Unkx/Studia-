using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    internal class Book
    {
        static int liczbaOsob = 0;
        int id;
        string imieAutora;
        string nazwiskoAutora;
        string rokUrodzenia;
        int rokWydania;
        string KolorOkladki;
        string kupionaKsiazka;
        int przeczytaneStrony;


        public Book()
        {
            liczbaOsob += 1;
            this.id = liczbaOsob;
            this.imieAutora = "-";
            this.nazwiskoAutora = "-";
            this.rokWydania = 2003;
            this.KolorOkladki = "-";
            this.kupionaKsiazka = "-";
            this.przeczytaneStrony = 2004;


        }
        public Book(string imieAutora, string nazwiskoAutora, int rokWydania, string KolorOkladki, string kupionaKsiazka , int przeczytaneStrony)
        {
            liczbaOsob += 1;
            this.id = liczbaOsob;
            this.imieAutora = imieAutora;
            this.nazwiskoAutora = nazwiskoAutora;
            this.rokWydania = rokWydania;
            this.KolorOkladki = KolorOkladki;
            this.kupionaKsiazka = kupionaKsiazka;
            this.przeczytaneStrony = przeczytaneStrony;
        }

        public Book(Book o)
        {
            liczbaOsob += 1;
            this.id = liczbaOsob;
            this.imieAutora = o.imieAutora;
            this.nazwiskoAutora = o.nazwiskoAutora;
            this.rokWydania = o.rokWydania;
            this.KolorOkladki = o.KolorOkladki;
            this.kupionaKsiazka = o.kupionaKsiazka;
            this.przeczytaneStrony = o.przeczytaneStrony;
        }
        
        public string[] Wypisz()
        {
            string[] clientInfo = new string[]
            {
            "ID:\t\t" + id,
            "Imię i nazwisko:\t" + imieAutora + " " + nazwiskoAutora,
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

