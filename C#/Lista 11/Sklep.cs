﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    //klasa pochodna//
    public partial class Sklep : Form
    {
        public bool Field4 { get; set; }


        public int Ksiazki { get; private set; }

        List<Store> sklepy;
        public Sklep()
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

            txtUlubionyAutor.Text = "Adam Mickiewicz";
            txtUlubionaKsiazka.Text = "Pan Tadeusz";
            txtKupionaKsiazka.Text = "Auta BmVV";
            txtRokWydania.Text = "2021";
            txtPrzeczytaneStrony.Text = "21";
            txtKsiazki.Text = "2000";
            txtPracownicy.Text = "100";
            txtSklep.Text = "Księgarnia X";
            txtEmail.Text = "KsięgarniaX.com";


        }
        private void ClearTextBoxes()
        {
            txtImie.Clear();
            txtNazwisko.Clear();
            txtWiek.Clear();
            txtAdres.Clear();
            txtKoszyk.Clear();

            txtUlubionyAutor.Clear();
            txtUlubionaKsiazka.Clear();
            txtKupionaKsiazka.Clear();
            txtRokWydania.Clear();
            txtPrzeczytaneStrony.Clear();
            txtKsiazki.Clear();
            txtPracownicy.Clear();
            txtSklep.Clear();
            txtEmail.Clear();

        }


        private void buttonZatwierdz_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                Store s1 = new Store(txtImie.Text, txtNazwisko.Text, Convert.ToInt32(this.txtWiek.Text), txtAdres.Text, Convert.ToInt32(this.txtKoszyk.Text), txtUlubionyAutor.Text, txtUlubionaKsiazka.Text, txtKupionaKsiazka.Text, Convert.ToInt32(this.txtRokWydania.Text), Convert.ToInt32(this.txtPrzeczytaneStrony.Text), dateCzas.Value, Convert.ToInt32(txtKsiazki.Text), Convert.ToInt32(txtPracownicy.Text), txtPracownicy.Text, txtEmail.Text);
                //listBoxStore.Items.AddRange(o1.Wypisz());



                Lista form4 = new Lista();


                Okno.listP.Add(s1); //dodanie obiektu do listy
                listBoxStore.Items.Clear(); //wyczyszczenie listBoxa
                                            //listBoxStore.Items.Add("NOWY STUDENT ZOSTAŁ DODANY DO LISTY: ");
                Okno.listP[Okno.listP.Count - 1].Wypisz(listBoxStore);
                ClearTextBoxes(); //wyczyszczenie pól tekstowych i innych elementów

                Lista.listBoxData = new List<string>();
                foreach (var item in listBoxStore.Items)
                {
                    Lista.listBoxData.Add(item.ToString());
                }


                List<Store> storeList = Okno.listP.Cast<Store>().ToList();
                // Obliczenie i wyświetlenie średniej ilości książek
                double sredniaKsiazek = ObliczSredniaKsiazek(storeList);
                MessageBox.Show("Średnia ilość książek we wszystkich sklepach: " + sredniaKsiazek);



                pictureZdjecie2.SizeMode = PictureBoxSizeMode.Zoom;
                //pictureZdjecie2.Image = new Bitmap("C:\\Users\\mi140\\OneDrive\\Pulpit\\Bez nazwy-2.jpg");//ścierzka dla laptopa
                pictureZdjecie2.SizeMode = PictureBoxSizeMode.StretchImage;
                //pictureZdjecie2.Image = new Bitmap("C:\\Users\\mi140\\Desktop\\bez-nazwy1");//ścierzka dla pc


                Random random = new Random();
                Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

                // Zmiana koloru tła formularza
                this.BackColor = randomColor;
            }
           


        }
        private double ObliczSredniaKsiazek(List<Store> sklepy)
        {
            if (sklepy.Count == 0)
                return 0;

            int sumaKsiazek = 0;

            foreach (Store sklep in sklepy)
            {
                sumaKsiazek += sklep.Ksiazki;
            }

            return (double)sumaKsiazek / sklepy.Count;
        }


        private bool ValidateData()
        {
            // Sprawdzanie poprawności danych w polu txtRokWydania (sprawdzamy, czy wprowadzona wartość jest liczbą większą lub równą zero)
            if (string.IsNullOrEmpty(txtImie.Text))
            {
                MessageBox.Show("Wprowadź swoje imie.");
                return false;
            }
            if (string.IsNullOrEmpty(txtNazwisko.Text))
            {
                MessageBox.Show("Wprowadź swoje nazwisko.");
                return false;
            }
            // Sprawdzanie poprawności danych w polu txtWiek (sprawdzamy, czy wprowadzona wartość jest liczbą)
            if (!int.TryParse(txtWiek.Text, out int wiek))
            {
                MessageBox.Show("Wprowadź poprawny wiek.");
                return false;
            }
            if (string.IsNullOrEmpty(txtAdres.Text))
            {
                MessageBox.Show("Wprowadź prawidłowy adres.");
                return false;
            }
            if (!int.TryParse(txtKoszyk.Text, out int Koszyk) || Koszyk < 0)
            {
                MessageBox.Show("Wprowadź liczbę książkek w koszyku.");
                return false;
            }
            if (string.IsNullOrEmpty(txtUlubionyAutor.Text))
            {
                MessageBox.Show("Wprowadź Imie i nazwisko swojego ulubionego autora.");
                return false;
            }
            if (string.IsNullOrEmpty(txtUlubionaKsiazka.Text))
            {
                MessageBox.Show("Wprowadź tytuł swojej ulubionej książki.");
                return false;
            }
            if (string.IsNullOrEmpty(txtKupionaKsiazka.Text))
            {
                MessageBox.Show("Wprowadź tytuł kupionej książki.");
                return false;
            }
            if (!int.TryParse(txtRokWydania.Text, out int RokWydania) || RokWydania < 0)
            {
                MessageBox.Show("Wprowadź rok wydania książki którą kupiłeś.");
                return false;
            }
            if (!int.TryParse(txtPrzeczytaneStrony.Text, out int PrzeczytaneStrony) || PrzeczytaneStrony < 0)
            {
                MessageBox.Show("Wprowadź przeczytane strony.");
                return false;
            }
            if (!int.TryParse(txtKsiazki.Text , out int Ksiazki) || Ksiazki < 0)
            {
                MessageBox.Show("Wprowadź stan książek na magazynie.");
                return false;
            }
            if (!int.TryParse(txtPracownicy.Text, out int Pracownicy) || Pracownicy < 0)
            {
                MessageBox.Show("Wprowadź liczbę pracowników pracujących w Twojej księgarni.");
                return false;
            }
            if (string.IsNullOrEmpty(txtSklep.Text))
            {
                MessageBox.Show("Wprowadź nazwę sklepu.");
                return false;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Wprowadź swój firmowy email.");
                return false;
            }


            return true;
        }

    }



}

