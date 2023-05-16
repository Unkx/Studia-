using System;
using System.Xml.Linq;
using WinFormsApp1;


class Store : Bookstore
{
    public string txtImie { get; set; }
    public string txtNazwisko { get; set; }

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

    public static bool operator ==(Store s1, Store s2)
    {
        // Add your comparison logic here
        // For example, compare relevant properties of the Sklep class
        return s1.Imie == s2.Imie && s1.Imie == s2.Imie;
    }

    public static bool operator !=(Store s1, Store s2)
    {
        // Invert the result of the == operator
        return !(s1 == s2);
    }
    private void CompareSklepObjects(Store s1, Store s2)
    {
        if (s1 == s2)
        {
            MessageBox.Show("Sklep objects are equal.");
        }
        else
        {
            MessageBox.Show("Sklep objects are not equal.");
        }
    }



}
