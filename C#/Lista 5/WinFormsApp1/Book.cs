class Book : Bookstore
{
    string imieAutora;
    string nazwiskoAutora;
    string tytul;
    int rokWydania;
    int przeczytaneStrony;

    public Book(string Imie, string Nazwisko, int Wiek, string Adres,int Koszyk,string UlubionyAutor,string UlubionaKsiazka,string KupionaKsiazka,int RokWydania,int PrzeczytaneStrony ,string imieAutora, string nazwiskoAutora,string tytul, int rokWydania,int przeczytaneStrony)
        : base(Imie, Nazwisko, Wiek, Adres,Koszyk,UlubionyAutor,UlubionaKsiazka,KupionaKsiazka,RokWydania,PrzeczytaneStrony)
    {
       
        this.imieAutora = imieAutora;
        this.nazwiskoAutora = nazwiskoAutora;
        this.tytul = tytul;
        this.rokWydania = rokWydania;
        this.przeczytaneStrony = przeczytaneStrony;
       
    }

    public Book(Book o) : base(o)
    {
        this.imieAutora = o.imieAutora;
        this.nazwiskoAutora = o.nazwiskoAutora;
        this.tytul = o.tytul;
        this.rokWydania = o.rokWydania;
        this.przeczytaneStrony = o.przeczytaneStrony;


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
            "Rok Wydania :" + RokWydania,
            "Przeczytane Strony :" + PrzeczytaneStrony,
            "==================================",
            "Imie Autora:\t" + imieAutora,
            "Nazwisko Autora:\t"+ nazwiskoAutora,
            "Tytuł Książki\t" + tytul,
            "Rok Wydania:\t" + rokWydania,
            "Przeczytane Strony :" + przeczytaneStrony,
            "==================================",

        };
        return clientInfo;
    }

}
