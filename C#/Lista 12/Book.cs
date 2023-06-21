using WinFormsApp1;

class Book : Bookstore
{
    int id;
    string imieAutora;
    string nazwiskoAutora;
    string tytul;
    int rokWydania;
    int przeczytaneStrony;
    protected string Tytul;

    public static bool operator ==(Book book1, Book book2)
    {
        if (ReferenceEquals(book1, book2))
        {
            return true;
        }

        if (ReferenceEquals(book1, null) || ReferenceEquals(book2, null))
        {
            return false;
        }

        return book1.imieAutora == book2.imieAutora &&
               book1.nazwiskoAutora == book2.nazwiskoAutora &&
               book1.tytul == book2.tytul &&
               book1.rokWydania == book2.rokWydania &&
               book1.przeczytaneStrony == book2.przeczytaneStrony;
    }

    public static bool operator !=(Book book1, Book book2)
    {
        return !(book1 == book2);
    }

    public Book(string Imie, string Nazwisko, int Wiek, string Adres,int Koszyk,string UlubionyAutor,string UlubionaKsiazka,string KupionaKsiazka,int RokWydania,int PrzeczytaneStrony ,DateTime Data,string imieAutora, string nazwiskoAutora,string tytul, int rokWydania,int przeczytaneStrony)
        : base(Imie, Nazwisko, Wiek, Adres,Koszyk,UlubionyAutor,UlubionaKsiazka,KupionaKsiazka,RokWydania,PrzeczytaneStrony,Data)
    {
       
        this.imieAutora = imieAutora;
        this.nazwiskoAutora = nazwiskoAutora;
        this.tytul = tytul;
        this.rokWydania = rokWydania;
        this.przeczytaneStrony = przeczytaneStrony;
        this.id = id;
        this.Tytul = tytul;

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

    //lista 8//
    public double Pole3 { get; set; }
    public override void Zapisz(StreamWriter writer)
    {
        base.Zapisz(writer);
        writer.WriteLine(Pole3);
    }

    public override void Wczytaj(StreamReader reader)
    {
        base.Wczytaj(reader);
        Pole3 = double.Parse(reader.ReadLine());
    }
}
