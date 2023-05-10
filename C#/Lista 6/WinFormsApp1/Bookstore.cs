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
            "Data :" + Data,
            "=================================="
        };
        return clientInfo;
    }

    public class PhotoClass
    {
        private Image photo ;

        public PhotoClass(string photoPath)
        {
            try
            {
                photo = Image.FromFile(photoPath);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error loading photo: " + e.Message);
            }
            Photo = Image.FromFile(photoPath);
        }

        public Image Photo
        {
            get { return photo; }
            // Make the setter private to prevent external code from modifying the photo field
            private set { photo = value; }
        }

        // Add a method to update the photo field
        public void UpdatePhoto(string photoPath)
        {
            try
            {
                Photo = Image.FromFile(photoPath);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error loading photo: " + e.Message);
            }
        }
<<<<<<< HEAD
=======

        public Image Photo
        {
            get { return photo; }
            set { photo = value; }
        }
>>>>>>> 25b8928c75a7f0908a89092c37d61efabbc4c2d5
    }
}