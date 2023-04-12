public class Bookstore
{
    protected string Imie;
    protected string Nazwisko;
    protected int Wiek;
    protected string Adres;
    protected int Koszyk;
    protected string UlubionyAutor;
    protected string UlubionaKsiazka;
    protected string KupionaKsiazka;
    protected int RokWydania;
    protected int PrzeczytaneStrony;

    public Bookstore(string Imie, string Nazwisko, int Wiek, string Adres, int Koszyk, string UlubionyAutor, string UlubionaKsiazka, string KupionaKsiazka, int RokWydania, int PrzeczytaneStrony)
    {
        this.Imie = Imie;
        this.Nazwisko = Nazwisko;
        this.Wiek = Wiek;
        this.Adres = Adres;
        this.Koszyk = Koszyk;
        this.UlubionyAutor = UlubionyAutor;
        this.UlubionaKsiazka = UlubionaKsiazka;
        this.KupionaKsiazka = KupionaKsiazka;
        this.RokWydania = RokWydania;
        this.PrzeczytaneStrony = PrzeczytaneStrony;
    }

    public Bookstore()
    {
        this.Imie = Imie;
        this.Nazwisko = Nazwisko;
        this.Wiek = Wiek;
        this.Adres = Adres;
        this.Koszyk = Koszyk;
        this.UlubionyAutor = UlubionyAutor;
        this.UlubionaKsiazka = UlubionaKsiazka;
        this.KupionaKsiazka = KupionaKsiazka;
        this.RokWydania = RokWydania;
        this.PrzeczytaneStrony = PrzeczytaneStrony;
    }

    public virtual string[] Wypisz()
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
            "Rok Wydania :" + RokWydania,
            "Przeczytane Strony :" + PrzeczytaneStrony,
            "=================================="
        };
        return clientInfo;
    }

}