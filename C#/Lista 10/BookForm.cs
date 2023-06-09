﻿using System;
using System.Collections;
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
            Book s1 = new Book(txtImie.Text, txtNazwisko.Text, Convert.ToInt32(this.txtWiek.Text), txtAdres.Text, Convert.ToInt32(this.txtKoszyk.Text), txtUlubionyAutor.Text, txtUlubionaKsiazka.Text, txtKupionaKsiazka.Text, Convert.ToInt32(this.txtRokWydania.Text), Convert.ToInt32(this.txtPrzeczytaneStrony.Text), dateCzas.Value, txtImieAutora.Text, txtNazwiskoAutora.Text, txtTytul.Text, Convert.ToInt32(this.txtRokWyd.Text), Convert.ToInt32(this.txtPrzeczytaneKs.Text));

            Okno.listP.Add(s1); //dodanie obiektu do listy
            listBoxBook.Items.Clear(); //wyczyszczenie listBoxa
            Okno.listP[Okno.listP.Count - 1].Wypisz(listBoxBook);
            ClearTextBoxes(); //wyczyszczenie pól tekstowych i innych elementów

            Lista.listBoxData = new List<string>();
            foreach (var item in listBoxBook.Items)
            {
                Lista.listBoxData.Add(item.ToString());
            }

            Lista form4 = new Lista();

            

            pictureZdjecie2.SizeMode = PictureBoxSizeMode.Zoom;
            //pictureZdjecie2.Image = new Bitmap("C:\\Users\\mi140\\OneDrive\\Pulpit\\Bez nazwy-1.jpg");//ścierzka dla laptopa
            pictureZdjecie2.SizeMode = PictureBoxSizeMode.StretchImage;

            // Przekształcenie listy Okno.listP do listy obiektów typu Book
            double sredniaStron = ObliczSredniaPrzeczytanychStron();
            MessageBox.Show("Średnia ilość przeczytanych stron: " + sredniaStron);


            Random random = new Random();
            Color randomColor = Color.FromArgb(random.Next(216), random.Next(256), random.Next(256));

            // Zmiana koloru tła formularza
            this.BackColor = randomColor;
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


    }
}







