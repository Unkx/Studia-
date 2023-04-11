using System.Xml.Linq;

public class Store : Bookstore
{
    int Ksiazki;
    int LiczbaPracownikow;
    string Sklep;
    string email;

    public Store(string Imie, string Nazwisko, int Wiek, string Adres,int Koszyk,string UlubionyAutor,string UlubionaKsiazka,string KupionaKsiazka,int RokWydania,int PrzeczytaneStrony,int Ksiazki, int LiczbaPracownikow, string sklep, string email)
        : base(Imie, Nazwisko, Wiek, Adres, Koszyk, UlubionyAutor, UlubionaKsiazka, KupionaKsiazka, RokWydania, PrzeczytaneStrony)
    {
        this.Imie = Imie;
        this.Nazwisko = Nazwisko;
        this.Wiek = Wiek;
        this.Adres = Adres;
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
    public Store(Store o)
    {
        this.LiczbaPracownikow = o.LiczbaPracownikow;
        this.Ksiazki = o.Ksiazki;
        this.Sklep = o.Sklep;
        this.email = o.email;

    }

    public class Class1
    {
        public static string SeparateName(string fullName)
        {
            string[] wordsInText = fullName.Split(' ');
            return wordsInText[0];
        }
    }

    public string[] Wypisz()
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
            "==================================",

        };
        return clientInfo;
    }

}
