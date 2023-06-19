using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

public abstract class Bookstore : IComparable<Bookstore>
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
    public int PrzeczytaneStrony;
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
        ls.Items.Add("\tTwoje dane : ");
        ls.Items.Add("Imię :\t" + Imie);
        ls.Items.Add("Nazwisko :\t" + Nazwisko);
        ls.Items.Add("Adres:\t" + Adres);
        ls.Items.Add("Koszyk:\t" + Koszyk);
        ls.Items.Add("Twój Ulubiony Autor :" + UlubionyAutor);
        ls.Items.Add("Ulubiona Książka :" + UlubionaKsiazka);
        ls.Items.Add("Kupiona Książka :" + KupionaKsiazka);
        ls.Items.Add("Rok Wydania :" + RokWydania);
        ls.Items.Add("Przeczytane Strony :" + PrzeczytaneStrony);
        ls.Items.Add("Data :" + DateTime.Now.ToString("dd.MM.yy"));
        ls.Items.Add("==================================");
    }

    public class PhotoClass
    {
        private Image photo;

        public PhotoClass(string photoPath)
        {
            try
            {
                photo = Image.FromFile("bez-nazwy1");
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

    public static bool operator ==(Bookstore s1, Bookstore s2)
    {
        return s1.Imie == s2.Imie && s1.Nazwisko == s2.Nazwisko;
    }

    public static bool operator !=(Bookstore s1, Bookstore s2)
    {
        return !(s1 == s2);
    }

    private void CompareSklepObjects(Bookstore s1, Bookstore s2)
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

    //lista 8//
    public int Pole1 { get; set; }
    public string Pole2 { get; set; }
    public virtual void Zapisz(StreamWriter writer)
    {
        writer.WriteLine(Imie);
        writer.WriteLine(Nazwisko);
        writer.WriteLine(Wiek);
        writer.WriteLine(Adres);
        writer.WriteLine(Koszyk);
        writer.WriteLine(UlubionyAutor);
        writer.WriteLine(UlubionaKsiazka);
        writer.WriteLine(KupionaKsiazka);
        writer.WriteLine(RokWydania);
        writer.WriteLine(PrzeczytaneStrony);
        writer.WriteLine(Data);
    }

    public virtual void Wczytaj(StreamReader reader)
    {
        Imie = reader.ReadLine();
        Nazwisko = reader.ReadLine();
        Wiek = Convert.ToInt32(reader.ReadLine());
        Adres = reader.ReadLine();
        Koszyk = Convert.ToInt32(reader.ReadLine());
        UlubionyAutor = reader.ReadLine();
        UlubionaKsiazka = reader.ReadLine();
        RokWydania = Convert.ToInt32(reader.ReadLine());
        PrzeczytaneStrony = Convert.ToInt32(reader.ReadLine());
        DateTime.TryParse(reader.ReadLine(), out DateTime date);
        Data = date;
    }
    public int CompareTo(Bookstore other)
    {
        int lastNameComparison = string.Compare(this.Nazwisko, other.Nazwisko, StringComparison.CurrentCulture);
        if (lastNameComparison != 0)
        {
            return lastNameComparison;
        }

        int firstNameComparison = string.Compare(this.Imie, other.Imie, StringComparison.CurrentCulture);
        if (firstNameComparison != 0)
        {
            return firstNameComparison;
        }

        return this.Data.CompareTo(other.Data);
        
    }


}
