using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class BookForm : Form
    {
        public BookForm()
        {
            InitializeComponent();
        }
        private void buttonUzupelnij_Click(object sender, EventArgs e)
        {
            txtImie.Text = "Jan";
            txtNazwisko.Text = "Masło";
            txtWiek.Text = "18";
            txtAdres.Text = "Oleska, Opole";
            txtKoszyk.Text = "20";

            txtImieAutora.Text = "Andrzej";
            txtNazwiskoAutora.Text = "Mleko";
            txtTytul.Text = "Poradnik majstra";
            txtRokWyd.Text = "2000";
            txtPrzeczytaneStrony.Text = "69";


            txtUlubionyAutor.Text = "Paweł X";
            txtUlubionaKsiazka.Text = "Pod Zamkiem";
            txtKupionaKsiazka.Text = "Harry";
            txtRokWydania.Text = "2020";
            txtPrzeczytaneKs.Text = "33";
        }

        private void ClearTextBoxes()
        {
            txtImie.Clear();
            txtNazwisko.Clear();
            txtWiek.Clear();
            txtAdres.Clear();
            txtKoszyk.Clear();

            txtImieAutora.Clear();
            txtNazwiskoAutora.Clear();
            txtTytul.Clear();
            txtRokWyd.Clear();
            txtPrzeczytaneStrony.Clear();

            txtUlubionyAutor.Clear();
            txtUlubionaKsiazka.Clear();
            txtKupionaKsiazka.Clear();
            txtRokWydania.Clear();
            txtPrzeczytaneKs.Clear();
        }

        private void buttonZaladuj_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {


                Book s1 = new Book(txtImie.Text, txtNazwisko.Text, Convert.ToInt32(this.txtWiek.Text), txtAdres.Text, Convert.ToInt32(this.txtKoszyk.Text), txtUlubionyAutor.Text, txtUlubionaKsiazka.Text, txtKupionaKsiazka.Text, Convert.ToInt32(this.txtRokWydania.Text), Convert.ToInt32(this.txtPrzeczytaneStrony.Text), dateCzas.Value, txtImieAutora.Text, txtNazwiskoAutora.Text, txtTytul.Text, Convert.ToInt32(this.txtRokWyd.Text), Convert.ToInt32(this.txtPrzeczytaneKs.Text));

                Okno.listP.Add(s1); // Dodanie obiektu do listy
                listBoxBook.Items.Clear(); // Wyczyszczenie listBoxa

                foreach (Book book in Okno.listP)
                {
                    book.Wypisz(listBoxBook); // Wyświetlenie wszystkich obiektów w listBoxBook
                }

                ClearTextBoxes(); // Wyczyszczenie pól tekstowych i innych elementów

                // Aktualizacja ListBoxData2
                Lista.listBoxData2 = listBoxBook.Items.Cast<string>().ToList();

                Lista form4 = new Lista();

                pictureZdjecie2.SizeMode = PictureBoxSizeMode.Zoom;
                pictureZdjecie2.SizeMode = PictureBoxSizeMode.StretchImage;

                double sredniaStron = ObliczSredniaPrzeczytanychStron();
                MessageBox.Show("Średnia ilość przeczytanych stron we wszystkich sklepach: " + sredniaStron);

                Random random = new Random();
                Color randomColor = Color.FromArgb(random.Next(216), random.Next(256), random.Next(256));

                // Zmiana koloru tła formularza
                this.BackColor = randomColor;
            }
        }

        private double ObliczSredniaPrzeczytanychStron()
        {
            if (Okno.listP.Count == 0)
                return 0;

            int sumaStron = 0;

            foreach (Book book in Okno.listP)
            {
                sumaStron += book.PrzeczytaneStrony;
            }

            return (double)sumaStron / Okno.listP.Count;
        }

        private bool ValidateData()
        {
            try
            {
                // Sprawdzanie poprawności danych w polu txtRokWydania (sprawdzamy, czy wprowadzona wartość jest liczbą większą lub równą zero)
                if (string.IsNullOrEmpty(txtImie.Text))
                {
                    MessageBox.Show("Wprowadź swoje imię.");
                    throw new ArgumentException("Imie is required.");
                }
                if (string.IsNullOrEmpty(txtNazwisko.Text))
                {
                    MessageBox.Show("Wprowadź swoje nazwisko.");
                    throw new ArgumentException("Nazwisko is required.");
                }
                // Sprawdzanie poprawności danych w polu txtWiek (sprawdzamy, czy wprowadzona wartość jest liczbą)
                if (!int.TryParse(txtWiek.Text, out int wiek))
                {
                    MessageBox.Show("Wprowadź poprawny wiek.");
                    throw new ArgumentException("Invalid age.");
                }
                if (string.IsNullOrEmpty(txtAdres.Text))
                {
                    MessageBox.Show("Wprowadź prawidłowy adres.");
                    throw new ArgumentException("Adres is required.");
                }
                if (!int.TryParse(txtKoszyk.Text, out int Koszyk) || Koszyk < 0)
                {
                    MessageBox.Show("Wprowadź liczbę książek w koszyku.");
                    throw new ArgumentException("Invalid number of books in the cart.");
                }
                if (string.IsNullOrEmpty(txtUlubionyAutor.Text))
                {
                    MessageBox.Show("Wprowadź imię i nazwisko swojego ulubionego autora.");
                    throw new ArgumentException("UlubionyAutor is required.");
                }
                if (string.IsNullOrEmpty(txtUlubionaKsiazka.Text))
                {
                    MessageBox.Show("Wprowadź tytuł swojej ulubionej książki.");
                    throw new ArgumentException("UlubionaKsiazka is required.");
                }
                if (string.IsNullOrEmpty(txtKupionaKsiazka.Text))
                {
                    MessageBox.Show("Wprowadź tytuł kupionej książki.");
                    throw new ArgumentException("KupionaKsiazka is required.");
                }
                if (!int.TryParse(txtRokWydania.Text, out int RokWydania) || RokWydania < 0)
                {
                    MessageBox.Show("Wprowadź rok wydania książki, którą kupiłeś.");
                    throw new ArgumentException("Invalid year of publication.");
                }
                if (!int.TryParse(txtPrzeczytaneStrony.Text, out int PrzeczytaneStrony) || PrzeczytaneStrony < 0)
                {
                    MessageBox.Show("Wprowadź liczbę przeczytanych stron.");
                    throw new ArgumentException("Invalid number of read pages.");
                }
                if (string.IsNullOrEmpty(txtImieAutora.Text))
                {
                    MessageBox.Show("Wprowadź imię autora.");
                    throw new ArgumentException("ImieAutora is required.");
                }
                if (string.IsNullOrEmpty(txtNazwiskoAutora.Text))
                {
                    MessageBox.Show("Wprowadź nazwisko autora.");
                    throw new ArgumentException("NazwiskoAutora is required.");
                }
                if (string.IsNullOrEmpty(txtTytul.Text))
                {
                    MessageBox.Show("Wprowadź tytuł książki.");
                    throw new ArgumentException("Tytul is required.");
                }
                if (!int.TryParse(txtRokWyd.Text, out int RokWyd) || RokWyd < 0)
                {
                    MessageBox.Show("Wprowadź rok wydania książki.");
                    throw new ArgumentException("Invalid year.");
                }
                if (!int.TryParse(txtPrzeczytaneKs.Text, out int PrzeczytaneKs) || PrzeczytaneKs < 0)
                {
                    MessageBox.Show("Wprowadź liczbę przeczytanych stron.");
                    throw new ArgumentException("Invalid number of read pages.");
                }

                return true;
            }
            catch (ArgumentException ex)
            {
                // Handle the exception
                Console.WriteLine("Validation error: " + ex.Message);
                return false;
            }
        }
    }
}
