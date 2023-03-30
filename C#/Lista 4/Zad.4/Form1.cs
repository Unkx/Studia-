namespace Zad._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        internal class Klient
        {
            int id;
            string imie;
            string nazwisko;
            int rokUrodzenia;
            static int liczbaOsob = 0;
            int koszyk;
            string ulubionyAutor;
            string ulubionaKsiazka;
            string kupionaKsiazka;
            int rokWydania;
        }
    }
}