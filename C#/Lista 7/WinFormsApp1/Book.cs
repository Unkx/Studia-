﻿class Book : Bookstore
{
    string imieAutora;
    string nazwiskoAutora;
    string tytul;
    int rokWydania;
    int przeczytaneStrony;

    public Book(string Imie, string Nazwisko, int Wiek, string Adres,int Koszyk,string UlubionyAutor,string UlubionaKsiazka,string KupionaKsiazka,int RokWydania,int PrzeczytaneStrony ,DateTime Data,string imieAutora, string nazwiskoAutora,string tytul, int rokWydania,int przeczytaneStrony)
        : base(Imie, Nazwisko, Wiek, Adres,Koszyk,UlubionyAutor,UlubionaKsiazka,KupionaKsiazka,RokWydania,PrzeczytaneStrony,Data)
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

    public override void Wypisz(ListBox ls)
    {
        base.Wypisz(ls);
        ls.Items.Add("Imie Autora:\t" + imieAutora);
        ls.Items.Add("Nazwisko Autora:\t" + nazwiskoAutora);
        ls.Items.Add("Tytuł Książki\t" + tytul);
        ls.Items.Add("Rok Wydania:\t" + rokWydania);
        ls.Items.Add("Przeczytane Strony :" + przeczytaneStrony);
        ls.Items.Add("==================================");

    }

}
