using Microsoft.VisualBasic.Logging;
using System.Xml.Linq;

public abstract class Bookstore
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
    protected DateTime Data;


    public Bookstore(string Imie, string Nazwisko, int Wiek, string Adres, int Koszyk, string UlubionyAutor, string UlubionaKsiazka, string KupionaKsiazka, int RokWydania, int PrzeczytaneStrony, DateTime Data)
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
        this.Data = Data;
    }

    public Bookstore()
    {
        this.Imie = "";
        this.Nazwisko = "";
        this.Wiek = 0;
        this.Adres = "";
        this.Koszyk = 0;
        this.UlubionyAutor = "";
        this.UlubionaKsiazka = "";
        this.KupionaKsiazka = "";
        this.RokWydania = 0;
        this.PrzeczytaneStrony = 0;

    }
    public Bookstore(Bookstore o)
    {
        this.Imie = o.Imie;
        this.Nazwisko = o.Nazwisko;
        this.Wiek = o.Wiek;
        this.Adres = o.Adres;
        this.Koszyk = o.Koszyk;
        this.UlubionyAutor = o.UlubionyAutor;
        this.UlubionaKsiazka = o.UlubionaKsiazka;
        this.KupionaKsiazka = o.KupionaKsiazka;
        this.RokWydania = o.RokWydania;
        this.PrzeczytaneStrony = o.PrzeczytaneStrony;
        this.Data = o.Data;
    }

    public virtual void Wypisz(ListBox ls)
    {
        ls.Items.Add("==================================");
        ls.Items.Add ("\tTwoje dane : ");
        ls.Items.Add("Imię :\t" + Imie);
        ls.Items.Add("Nazwisko :\t" + Nazwisko);
        ls.Items.Add("Adres:\t" + Adres);
        ls.Items.Add("Koszyk:\t" + Koszyk);
        ls.Items.Add("Twój Ulubiony Autor :" + UlubionyAutor);
        ls.Items.Add("Ulubiona Książka :" + UlubionaKsiazka);
        ls.Items.Add("Kupiona Książka :" + KupionaKsiazka);
        ls.Items.Add("Rok Wydania :" + RokWydania);
        ls.Items.Add("Przeczytane Strony :" + PrzeczytaneStrony);
        ls.Items.Add("Data :" + Data);
        ls.Items.Add("==================================");
    }

    public class PhotoClass
    {
        private Image photo;

        public PhotoClass(string photoPath)
        {
            try
            {
                photo = Image.FromFile("http://i.imgur.com/7ikw7ye.png");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error loading photo: " + e.Message);
            }
        }

        public Image Photo
        {
            get { return photo; }
            set { photo = value; }
        }

    }

}