using System;
using System.Xml.Linq;


class Store : Bookstore
{
    int Ksiazki;
    int LiczbaPracownikow;
    string Sklep;
    string email;

    public Store(string Imie, string Nazwisko, int Wiek, string Adres,int Koszyk,string UlubionyAutor,string UlubionaKsiazka,string KupionaKsiazka,int RokWydania,int PrzeczytaneStrony,DateTime Data ,int Ksiazki, int LiczbaPracownikow, string sklep, string email)
        : base(Imie, Nazwisko, Wiek, Adres, Koszyk, UlubionyAutor, UlubionaKsiazka, KupionaKsiazka, RokWydania, PrzeczytaneStrony,Data)
    {

        this.Ksiazki = Ksiazki;
        this.LiczbaPracownikow = LiczbaPracownikow;
        this.Sklep = sklep;
        this.email = email;
    }
    public Store()
    {
        this.LiczbaPracownikow = 0;
        this.Ksiazki = 0;
        this.Sklep = "-";
        this.email = "-";

    }
    public Store(Store o) :base(o)
    {
        this.LiczbaPracownikow = o.LiczbaPracownikow;
        this.Ksiazki = o.Ksiazki;
        this.Sklep = o.Sklep;
        this.email = o.email;

    }

    public override void Wypisz(ListBox ls)
    {
        base.Wypisz(ls);
        ls.Items.Add("Tytuł Książki\t" + Sklep);
        ls.Items.Add("Książki:\t" + Ksiazki);
        ls.Items.Add("Nazwa Sklepu:\t" + Sklep);        
        ls.Items.Add("Email:\t" + email);
        ls.Items.Add("==================================");
    }



}
