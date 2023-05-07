using System.Xml.Linq;

public class Store : Bookstore
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

    public override string[] Wypisz()
    {
        string[] clientInfo = new string[]
        {
            "==================================",
            "\tTwoje dane : ",
            "Imię :\t" + Imie,
            "Nazwisko :\t" + Nazwisko,
            "Wiek:\t" + Wiek,
            "Adres:\t" + Adres,
            "Koszyk:\t" + Koszyk,
            "Twój Ulubiony Autor :" + UlubionyAutor,
            "Ulubiona Książka :" + UlubionaKsiazka,
            "Kupiona Książka :" + KupionaKsiazka,
            "Rok Wydania Zakupionej Książki:" + RokWydania,
            "Przeczytane Strony :" + PrzeczytaneStrony,
            "==================================",
            "Liczba Pracowników:\t" + LiczbaPracownikow,
            "Liczba Książek :\t"+ Ksiazki,
            "Sklep:\t" + Sklep,
            "Email :\t" + email,
            "Data :" + Data,
            "==================================",

        };
        return clientInfo;
    }



    public override void Write(ListBox chuj)
    {
        base.Write(chuj);

        chuj.Items.Add("Wiek " + Wiek);
    }

  

}
