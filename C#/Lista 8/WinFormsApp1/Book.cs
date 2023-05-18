using WinFormsApp1;

class Book : Bookstore
{
    string imieAutora;
    string nazwiskoAutora;
    string tytul;
    int rokWydania;
    int przeczytaneStrony;

<<<<<<< HEAD
    public static bool operator == (Book Book1 , Book Book2)
    {
        return Book1.imieAutora  == Book2.imieAutora &&
            Book1.nazwiskoAutora == Book2.nazwiskoAutora &&
            Book1.tytul == Book2.tytul &&
            Book1.rokWydania == Book2.rokWydania&&
            Book1.przeczytaneStrony == Book2.przeczytaneStrony;
    }
    public static bool operator !=(Book Book1, Book Book2)
    {
        return Book1.imieAutora != Book2.imieAutora ||
        Book1.nazwiskoAutora != Book2.nazwiskoAutora ||
        Book1.tytul != Book2.tytul ||
        Book1.rokWydania != Book2.rokWydania ||
        Book1.przeczytaneStrony != Book2.przeczytaneStrony;
    }
    
=======
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

>>>>>>> ecc2faf91635b10d71a1bcf475654a13e3091659
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
