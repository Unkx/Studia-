using System.Xml.Linq;

public class Book : Bookstore
{
    string imieAutora;
    string nazwiskoAutora;
    int rokWydania;
    int przeczytaneStrony;

    public Book(string Imie, string Nazwisko, int Wiek, string Adres,int Koszyk,string UlubionyAutor,string UlubionaKsiazka,string KupionaKsiazka,int RokWydania,int PrzeczytaneStrony ,string imieAutora, string nazwiskoAutora, int rokWydania,int przeczytaneStrony)
        : base(Imie, Nazwisko, Wiek, Adres,Koszyk,UlubionyAutor,UlubionaKsiazka,KupionaKsiazka,RokWydania,PrzeczytaneStrony)
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
        this.imieAutora = imieAutora;
        this.nazwiskoAutora = nazwiskoAutora;
        this.rokWydania = rokWydania;
        this.przeczytaneStrony = przeczytaneStrony;
       
    }
    public Book()
    {
        this.imieAutora = "-";
        this.nazwiskoAutora = "-";
        this.rokWydania = 0;
        this.przeczytaneStrony = 0;

    }
    public Book(Book o)
    {
        this.imieAutora = o.imieAutora;
        this.nazwiskoAutora = o.nazwiskoAutora;
        this.rokWydania = o.rokWydania;
        this.przeczytaneStrony = o.przeczytaneStrony;


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
            "Rok Wydania :" + RokWydania,
            "Przeczytane Strony :" + PrzeczytaneStrony,
            "==================================",
            "Imie Autora:\t" + imieAutora,
            "Nazwisko Autora:\t"+ nazwiskoAutora,
            "Rok Wydania:\t" + rokWydania,
            "Przeczytane Strony :" + przeczytaneStrony,
            "==================================",

        };
        return clientInfo;
    }

}
